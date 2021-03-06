﻿using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_record.ViewModels
{
    public class CardViewModel
    {
        private readonly AppController _appController;
        private ExaminationViewModel _examinationVM;
        private HospitalizationViewModel _hospitalizationVM;
        private ObservationViewModel _observationVM;
        private int _currentPatientId;
        private Action _showNext;
        private Action _showPrev;

        public CardViewModel(AppController appController)
        {
            _appController = appController
                ?? throw new ArgumentNullException(nameof(appController));
        }

        public event EventHandler DataLoading;
        public event EventHandler DataLoaded;

        /// <summary>
        /// Коллекция пациентов
        /// </summary>
        public BindingList<Patient> Patients { get; private set; } = new BindingList<Patient>();

        /// <summary>
        /// Ключ поиска по Фамилии
        /// </summary>
        private bool _LastNameChecked = true;
        public bool LastNameChecked
        {
            get => _LastNameChecked;
            set
            {
                _LastNameChecked = value;
                InputSearch = String.Empty;
            }
        }

        /// <summary>
        /// Значение строки поиска
        /// </summary>
        private string _InputSearch;
        public string InputSearch
        {
            get => _InputSearch;
            set
            {
                _InputSearch = value;
                InputSearchChanged();
            }
        }

        /// <summary>
        /// Строка поиска изменилась
        /// </summary>
        private async void InputSearchChanged()
        {
            if (String.IsNullOrWhiteSpace(InputSearch))
            {
                await LoadDataAsync();
            }
            else
            {
                await SearchAndLoadDataAsync();
            }
        }

        /// <summary>
        /// Поиск и загрузка данных о пациентах
        /// </summary>
        /// <returns></returns>
        private async Task SearchAndLoadDataAsync()
        {
            DataLoading?.Invoke(this, EventArgs.Empty);
            Patients.Clear();

            Result<List<Patient>> result = null;
            if (LastNameChecked)
            {
                result = await _appController.DataContext
                    .Patients.GetPatientsByLastNameAsync(InputSearch.Trim());
            }
            else
            {
                result = await _appController.DataContext
                    .Patients.GetPatientsByCardNumberAsync(InputSearch.Trim());
            }
            LoadPatients(result);

            DataLoaded?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Переход к созданию нового пациента
        /// </summary>
        internal void ShowRegistrationView() => _appController.ShowRegistrationView();

        /// <summary>
        /// Переход к редактированию пациента
        /// </summary>
        /// <param name="patient"></param>
        internal void ShowRegistrationView(Patient patient) =>
            _appController.ShowRegistrationView(patient);

        /// <summary>
        /// Загрузка списка пациентов
        /// </summary>
        /// <returns></returns>
        internal async Task LoadDataAsync()
        {
            DataLoading?.Invoke(this, EventArgs.Empty);
            Patients.Clear();

            var result = await _appController.DataContext.Patients.GetPatientsAsync();
            LoadPatients(result);

            DataLoaded?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Заполнение коллекции Пациентов
        /// полученным результатом из БД
        /// </summary>
        /// <param name="result"></param>
        private void LoadPatients(Result<List<Patient>> result)
        {
            if (result.HasValue)
            {
                if (result.Value.Count > 0)
                {
                    result.Value.ForEach(p => Patients.Add(p));
                    _currentPatientId = result.Value.First().Id;
                }
                else
                {
                    _currentPatientId = 0;
                }
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
                _currentPatientId = 0;
            }
        }

        /// <summary>
        /// Удаление пациента
        /// </summary>
        internal async void RemovePatient(Patient patient)
        {
            var message = $"Вы согласны удалить запись о пациенте с картой №{patient.CardNumber}?";
            bool agreeRemove = _appController.MessageService.GetAgree(message);
            if (!agreeRemove)
                return;

            var result = await _appController.DataContext
                .Patients.RemovePatientAsync(patient.Id);
            if (result.HasValue)
            {
                _appController.MessageService.ShowInfoMessage(result.Value);
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Установка Id текущего отображаемого пациента
        /// </summary>
        /// <param name="id">id пациента</param>
        internal void SetCurrentPatientId(int id)
        {
            _currentPatientId = id;
            _observationVM = null;
            _examinationVM = null;
            _hospitalizationVM = null;
        }

        /// <summary>
        /// Получение запрашиваемой uc для отображения
        /// </summary>
        /// <param name="key">ключ (см. AppController) связанный с uc</param>
        /// <returns></returns>
        internal async Task<UserControl> GetUcViewAsync(string key)
        {
            //получаем экземпляр
            dynamic uc = _appController.GetUcViewOutput(key);
            switch (key)
            {
                case "Ob":
                    _observationVM = uc.ViewModel;
                    await SetupObservationVM();
                    break;
                case "Ex":
                    _examinationVM = uc.ViewModel;
                    await SetupExaminationVM();
                    break;
                case "Ho":
                    _hospitalizationVM = uc.ViewModel;
                    await SetupHospitalizationVM();
                    break;
                default:
                    throw new ArgumentException(nameof(key));
            }

            return uc as UserControl;
        }

        /// <summary>
        /// Подгрузка данных для Госпитализаций
        /// </summary>
        /// <returns></returns>
        private async Task SetupHospitalizationVM()
        {
            if (_currentPatientId < 1)
                return;

            //загружаем из БД Госпитализации для текущ.пациента
            var hosps = await _appController
                .DataContext.Hospitalizations.GetHospitalizationsByPatientIdAsync(_currentPatientId);
            if (!hosps.HasValue)
                return;

            //передаем данные во вьюмодель
            _hospitalizationVM.SetHospitalizations(hosps.Value);
            //ссылки на переходы
            _showNext = _hospitalizationVM.ShowNext;
            _showPrev = _hospitalizationVM.ShowPrevious;
        }

        /// <summary>
        /// Подгрузка данных для Осмотров
        /// </summary>
        /// <returns></returns>
        private async Task SetupExaminationVM()
        {
            if (_currentPatientId < 1)
                return;

            //загружаем осмотры из БД
            Result<List<Examination>> exams = await _appController
                .DataContext.Examinations.GetExaminationsByPatientIdAsync(_currentPatientId);
            if (!exams.HasValue)
                return;

            //загрузка доп.данных из БД
            foreach (Examination exam in exams.Value)
            {
                var diag = await _appController.DataContext
                    .Diagnoses.GetDiagnosisByIdAsync(exam.DiagnosisId);
                if (diag.HasValue)
                    exam.Diagnosis = diag.Value;

                var doc = await _appController.DataContext
                    .Doctors.GetDoctorByIdAsync(exam.DoctorId);
                if (doc.HasValue)
                    exam.Doctor = doc.Value;

                var hg = await _appController.DataContext
                    .HealthGroups.GetHealthGroupByIdAsync(exam.HealthGroupId);
                if (hg.HasValue)
                    exam.HealthGroup = hg.Value;
            }
            //передаем данные во вьюмодель
            _examinationVM.SetDiagnoses(exams.Value);
            //ссылки на переходы
            _showNext = _examinationVM.ShowNext;
            _showPrev = _examinationVM.ShowPrevious;
        }

        /// <summary>
        /// Подгрузка данных для Наблюдений
        /// </summary>
        /// <returns></returns>
        private async Task SetupObservationVM()
        {
            if (_currentPatientId < 1)
                return;

            //загружаем из БД Наблюдения для текущ.пациента
            var obs = await _appController
                .DataContext.Observations.GetObservationsByPatientIdAsync(_currentPatientId);
            if (!obs.HasValue)
                return;

            //подгрузка доп.данных из БД
            foreach (Observation ob in obs.Value)
            {
                var diag = await _appController.DataContext
                    .Diagnoses.GetDiagnosisByIdAsync(ob.DiagnosisId);
                if (diag.HasValue)
                    ob.Diagnosis = diag.Value;

                var doc = await _appController.DataContext
                    .Doctors.GetDoctorByIdAsync(ob.DoctorId);
                if (doc.HasValue)
                    ob.Doctor = doc.Value;
            }
            //передаем данные во вьюмодель
            _observationVM.SetObservations(obs.Value);
            //ссылки на переходы
            _showNext = _observationVM.ShowNext;
            _showPrev = _observationVM.ShowPrevious;
        }

        /// <summary>
        /// Переход к предыд. наблюдению, осмотру, госпитализации
        /// </summary>
        internal void PrevAddition() => _showPrev?.Invoke();

        /// <summary>
        /// Переход к след. наблюдению, осмотру, госпитализации
        /// </summary>
        internal void NextAddition() => _showNext?.Invoke();
    }
}
