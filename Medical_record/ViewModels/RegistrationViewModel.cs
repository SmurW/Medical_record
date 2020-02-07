using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class RegistrationViewModel
    {
        private readonly AppController _appController;
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

        internal async void SavePatient()
        {
            Result<string> result = new Result<string>("Error");
            if (Id == 0)
            {
                //запоминаем нового
                Patient patient = GetPatient();
                result = await _appController.DataContext.AddPatientAsync(patient);
            }
            else
            {
                //обновляем уже существующего
                Patient patient = GetPatient();
                result = await _appController.DataContext.UpdatePatientAsync(patient);
            }

            if (result.HasValue)
            {
                MessagesService.ShowInfoMessage(result.Value);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

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
    }
}
