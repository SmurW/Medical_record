using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class CardViewModel
    {
        private readonly AppController _appController;

        public CardViewModel(AppController appController)
        {
            _appController = appController
                ?? throw new ArgumentNullException(nameof(appController));
        }

        /// <summary>
        /// Коллекция пациентов
        /// </summary>
        public List<Patient> Patients { get; private set; } = new List<Patient>();

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
            var result = await _appController.DataContext.GetPatientsAsync();
            if (result.HasValue)
            {
                Patients = result.Value;
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Удаление пациента
        /// </summary>
        internal async void RemovePatient(Patient patient)
        {
            var message = $"Вы согласны удалить запись о пациенте с картой №{patient.CardNumber}?";
            bool agreeRemove = MessagesService.GetAgree(message);
            if (!agreeRemove)
                return;

            var result = await _appController.DataContext.RemovePatientAsync(patient.Id);
            if (result.HasValue)
            {
                MessagesService.ShowInfoMessage(result.Value);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }
    }
}
