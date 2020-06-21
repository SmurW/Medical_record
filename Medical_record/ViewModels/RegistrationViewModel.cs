using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_record.ViewModels
{
    public class RegistrationViewModel
    {
        private readonly AppController _appController;
        private AddExaminationViewModel _examinationVM;
        private AddHospitalizationViewModel _hospitalizationVM;
        private AddObservationViewModel _observationVM;

        public RegistrationViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public string Residence { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportUFMS { get; set; }
        public DateTime PassportIssueDate { get; set; } = DateTime.Now;
        public string PassportDepCode { get; set; }

        /// <summary>
        /// Сохранение в БД пацента
        /// </summary>
        internal async void SavePatient()
        {
            var result = new Result<string>("Данные не заполнены");
            Patient patient = GetPatient();
            if (Id == 0)
            {
                try
                {
                    //запоминаем нового
                    result = await _appController.DataContext
                        .Patients.AddPatientAsync(patient);
                }
                catch (Exception)
                {

                    //_appController.MessageService.ShowErrorMessage(result.Error);
                }
                
            }
            else
            {
                //обновляем уже существующего
                result = await _appController.DataContext
                    .Patients.UpdatePatientAsync(patient);
            }

            if (!result.HasValue)
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
                return;
            }

            if (Id == 0)
            {
                //получаем Id пациента
                var resultId = await _appController.DataContext
                    .Patients.GetLastAddedPatientIdAsync();
                if (resultId.HasValue)
                {
                    Id = resultId.Value;
                }
                else
                {
                    _appController.MessageService.ShowErrorMessage(resultId.Error);
                    return;
                }
            }
            _appController.MessageService.ShowInfoMessage(result.Value);
        }

        /// <summary>
        /// Сохранение наблюдения
        /// </summary>
        /// <returns></returns>
        private async Task SaveObservationAsync()
        {
            //получаем экз. наблюдения
            var ob = _observationVM.GetObservation();
            //присваиваем Id текущего пациента
            ob.PatientId = Id;
            //сохраняем в БД
            var result = await _appController.DataContext
                .Observations.AddObservationAsync(ob);
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
        /// Сохранение госпитализации
        /// </summary>
        /// <returns></returns>
        private async Task SaveHospitalizationAsync()
        {
            var hosp = _hospitalizationVM.GetHospitalization();
            hosp.PatientId = Id;
            var result = await _appController.DataContext
                .Hospitalizations.AddHospitalizationAsync(hosp);
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
        /// Сохранение записи врачебного осмотра
        /// </summary>
        /// <returns></returns>
        private async Task SaveExaminationAsync()
        {
            var exam = _examinationVM.GetExamination();
            exam.PatientId = Id;
            Result<string> result = await _appController.DataContext
                .Examinations.AddExaminationAsync(exam);
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
        /// Получение экземпляра Patient из
        /// свойств этой вьюмодели и отображенной uc
        /// </summary>
        /// <returns></returns>
        private Patient GetPatient()
        {
            var result = new Patient
            {
                Id = Id,
                CardNumber = CardNumber,
                FirstName = FirstName,
                LastName = LastName,
                MiddleName = MiddleName,
                Birthdate = Birthdate,
                PassportDepCode = PassportDepCode,
                PassportIssueDate = PassportIssueDate,
                PassportNumber = PassportNumber,
                PassportSeries = PassportSeries,
                PassportUFMS = PassportUFMS,
                RegistrationDate = RegistrationDate,
                Residence = Residence,
                Sex = Sex
            };
            return result;
        }

        /// <summary>
        /// Извлечение из Patient значений свойств для этой вьюмодели
        /// </summary>
        /// <param name="patient"></param>
        internal void SetPatient(Patient patient)
        {
            Id = patient.Id;
            CardNumber = patient.CardNumber;
            FirstName = patient.FirstName;
            LastName = patient.LastName;
            MiddleName = patient.MiddleName;
            Sex = patient.Sex;
            Birthdate = patient.Birthdate;
            RegistrationDate = patient.RegistrationDate;
            Residence = patient.Residence;
            PassportNumber = patient.PassportNumber;
            PassportSeries = patient.PassportSeries;
            PassportUFMS = patient.PassportUFMS;
            PassportDepCode = patient.PassportDepCode;
            PassportIssueDate = patient.PassportIssueDate;
        }

        /// <summary>
        /// Получение запрашиваемой uc для отображения
        /// </summary>
        /// <param name="key">ключ (см. AppController) связанный с uc</param>
        /// <returns></returns>
        internal async Task<UserControl> GetUcViewAsync(string key)
        {
            //получаем экземпляр
            dynamic uc = _appController.GetUcViewInput(key);
            switch (key)
            {
                case "Ob":
                    _observationVM = uc.ViewModel;
                    _observationVM.ButtonSaveClicked += AddVM_ButtonSaveClicked;
                    await SetupObservationUc();
                    break;
                case "Ex":
                    _examinationVM = uc.ViewModel;
                    _examinationVM.ButtonSaveClicked += AddVM_ButtonSaveClicked;
                    await SetupExaminationUc();
                    break;
                case "Ho":
                    _hospitalizationVM = uc.ViewModel;
                    _hospitalizationVM.ButtonSaveClicked += AddVM_ButtonSaveClicked;
                    await SetupHospitalizationUc();
                    break;
                default:
                    throw new ArgumentException(nameof(key));
            }
            
            return uc as UserControl;
        }

        /// <summary>
        /// В Осмотре, Наблюдении или Госпитализации нажали кнопку сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddVM_ButtonSaveClicked(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                var message = "Необходимо сначала сохранить данные о пациенте!";
                _appController.MessageService.ShowInfoMessage(message);
                return;
            }

            switch ((sender as IInputUcViewModel).Tag)
            {
                case "Ob":
                    await SaveObservationAsync();
                    break;
                case "Ex":
                    await SaveExaminationAsync();
                    break;
                case "Ho":
                    await SaveHospitalizationAsync();
                    break;
                default:
                    throw new Exception("Не удалось определить вьюмодель для сохранения.");
            }
        }

        /// <summary>
        /// Подгрузка данных в AddObservationViewModel
        /// </summary>
        /// <returns></returns>
        private async Task SetupObservationUc()
        {
            //Получаем количество наблюдений для текущего пациента
            if (Id == 0)
            {
                //пациент еще не сохранен в БД
                _observationVM.Count = "1";
            }
            else
            {
                var count = await _appController.DataContext
                    .Observations.GetCountObservationsByPatientIdAsync(Id);
                if (count.HasValue)
                {
                    _observationVM.Count = $"{count.Value + 1}";
                }
            }

            //Получаем диагнозы
            var diags = await _appController.DataContext.Diagnoses.GetDiagnosesAsync();
            if (diags.HasValue)
            {
                _observationVM.Diagnoses.Clear();
                diags.Value.ForEach(d => _observationVM.Diagnoses.Add(d));
            }

            //Получаем докторов
            var docs = await _appController.DataContext.Doctors.GetDoctorsAsync();
            if (docs.HasValue)
            {
                _observationVM.Doctors.Clear();
                docs.Value.ForEach(d => _observationVM.Doctors.Add(d));
            }
        }

        /// <summary>
        /// Подгрузка данных в AddExaminationViewModel
        /// </summary>
        /// <returns></returns>
        private async Task SetupExaminationUc()
        {
            if (Id == 0)
            {
                _examinationVM.Count = "1";
            }
            else
            {
                var count = await _appController.DataContext
                    .Examinations.GetCountExaminationsByPatientIdAsync(Id);
                if (count.HasValue)
                {
                    _examinationVM.Count = $"{count.Value + 1}";
                }
            }

            //Получаем диагнозы
            var diags = await _appController.DataContext
                .Diagnoses.GetDiagnosesAsync();
            if (diags.HasValue)
            {
                _examinationVM.Diagnoses.Clear();
                diags.Value.ForEach(d => _examinationVM.Diagnoses.Add(d));
            }

            //Получаем докторов
            var docs = await _appController.DataContext.Doctors.GetDoctorsAsync();
            if (docs.HasValue)
            {
                _examinationVM.Doctors.Clear();
                docs.Value.ForEach(d => _examinationVM.Doctors.Add(d));
            }

            //Получаем группы здоровья
            var groups = await _appController.DataContext
                .HealthGroups.GetHealthGroupsAsync();
            if (groups.HasValue)
            {
                _examinationVM.HealthGroups.Clear();
                groups.Value.ForEach(g => _examinationVM.HealthGroups.Add(g));
            }
        }

        /// <summary>
        /// Подгрузка данных в AddHospitalizationViewModel
        /// </summary>
        /// <returns></returns>
        private async Task SetupHospitalizationUc()
        {
            //Получаем количество наблюдений для текущего пациента
            if (Id == 0)
            {
                //пациент еще не сохранен в БД
                _hospitalizationVM.Count = "1";
            }
            else
            {
                var count = await _appController.DataContext
                    .Hospitalizations.GetCountHospitalizationsByPatientIdAsync(Id);
                if (count.HasValue)
                {
                    _hospitalizationVM.Count = $"{count.Value + 1}";
                }
            }
        }
    }
}
