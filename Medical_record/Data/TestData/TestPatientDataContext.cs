using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
    public class TestPatientDataContext : IPatientDataContext
    {
        private readonly DataSource _dataSource;

        public TestPatientDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddPatientAsync(Patient patient)
        {
            patient.Id = 1;
            if (_dataSource.Patients.Count > 0)
            {
                patient.Id = _dataSource.Patients.Max(p => p.Id) + 1;
            }
            _dataSource.Patients.Add(patient);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {patient.LastName} {patient.FirstName} {patient.MiddleName}",
                String.Empty));
        }

        public Task<Result<int>> GetLastAddedPatientIdAsync()
        {
            return Task.FromResult(new Result<int>(_dataSource.Patients.Last().Id));
        }

        public Task<Result<List<Patient>>> GetPatientsAsync()
        {
            return Task.FromResult(new Result<List<Patient>>(_dataSource.Patients));
        }

        public Task<Result<List<Patient>>> GetPatientsByCardNumberAsync(string cardNumber)
        {
            var patients = _dataSource.Patients.Where(p => p.CardNumber.StartsWith(cardNumber)).ToList();
            return Task.FromResult(new Result<List<Patient>>(patients));
        }

        public Task<Result<List<Patient>>> GetPatientsByLastNameAsync(string lastName)
        {
            var patients = _dataSource.Patients.Where(p => p.LastName.StartsWith(lastName)).ToList();
            return Task.FromResult(new Result<List<Patient>>(patients));
        }

        public Task<Result<string>> RemovePatientAsync(int id)
        {
            var pt = _dataSource.Patients.FirstOrDefault(p => p.Id == id);
            if (pt == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _dataSource.Patients.Remove(pt);
            return Task.FromResult(new Result<string>("Успешно удален", String.Empty));
        }

        public Task<Result<string>> UpdatePatientAsync(Patient patient)
        {
            var pt = _dataSource.Patients.FirstOrDefault(p => p.Id == patient.Id);
            if (pt == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            pt.Birthdate = patient.Birthdate;
            pt.CardNumber = patient.CardNumber;
            pt.FirstName = patient.FirstName;
            pt.LastName = patient.LastName;
            pt.MiddleName = patient.MiddleName;
            pt.PassportDepCode = patient.PassportDepCode;
            pt.PassportIssueDate = patient.PassportIssueDate;
            pt.PassportNumber = patient.PassportNumber;
            pt.PassportSeries = patient.PassportSeries;
            pt.PassportUFMS = patient.PassportUFMS;
            pt.RegistrationDate = patient.RegistrationDate;
            pt.Residence = patient.Residence;
            pt.Sex = patient.Sex;

            return Task.FromResult(new Result<string>("Успешно обновлен", String.Empty));
        }
    }
}
