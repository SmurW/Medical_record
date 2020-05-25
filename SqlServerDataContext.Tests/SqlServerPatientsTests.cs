using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Data.Models;
using Medical_record.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqlServerDataContext.Tests
{
    [TestClass]
    public class SqlServerPatientsTests
    {
        [TestMethod]
        [Description("Получение полного списка пациентов, удаленные исключены")]
        public async Task GetPatientsAsync_ReturnsListPatients()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Patient>> result = await sut.Patients.GetPatientsAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description ("Получение последнего добавленого id пациента")]
        public async Task GetLastAddedPatientIdAsync_ReturnsPatientsId()
        {
            IDataContext sut = new MsSqlDataContext();
            
            Result<int> result = await sut.Patients.GetLastAddedPatientIdAsync();

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description ("Получение пациентов по фамилии")]
        public async Task GetPatientsByLastNameAsync_ReturnListPatientsByLastName()
        {
            var key = "Мухина";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Patient>> result = await sut.Patients.GetPatientsByLastNameAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }


        [TestMethod]
        [Description ("Получение пациентов по номеру карты")]
        public async Task GetPatientsByCardNumberAsync_ReturnListPatientsByCardNumber()
        {
            var key = "2345";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Patient>> result = await sut.Patients.GetPatientsByCardNumberAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Добавление нового пациента с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddPatientsAsync_WhenValidPatients_ThenSuccess()
        {
            var patients = new Patient
            {
                CardNumber = "Новый номер пациента 1",
                LastName = "Новый пациент 1",
                FirstName = "Новый пациент 1",
                MiddleName = "Новый пациент 1",
                Sex = "Новый пол пациента 1",
                Birthdate = DateTime.Parse("23.03.1984"),
                RegistrationDate = DateTime.Parse("13.05.2005"),
                Residence = "Новая улица пациента 1",
                PassportNumber = "Нвоый номер паспорта 1",
                PassportSeries = "Новая серия паспорта 1",
                PassportUFMS = "ТП №13 отдела УФМС России 1",
                PassportIssueDate = DateTime.Parse("11.11.1995"),
                PassportDepCode = "Новый код паспорта 1"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Patients.AddPatientAsync(patients);

            Assert.IsTrue(result.HasValue);
        }
       
        [TestMethod]
        [Description("Обновление пациента с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task UpdatePatientsAsync_WhenValidPatients_ThenSuccess()
        {
            var patients = new Patient
            {
                Id = 1,
                CardNumber = "Новый номер пациента 2",
                LastName = "Новый пациент 2",
                FirstName = "Новый пациент 2",
                MiddleName = "Новый пациент 2",
                Sex = "Новый пол пациента 2",
                Birthdate = DateTime.Parse("23.03.1984"),
                RegistrationDate = DateTime.Parse("13.05.2005"),
                Residence = "Новая улица пациента 2",
                PassportNumber = "Нвоый номер паспорта 2",
                PassportSeries = "Новая серия паспорта 2",
                PassportUFMS = "ТП №13 отдела УФМС России 2",
                PassportIssueDate = DateTime.Parse("11.11.1995"),
                PassportDepCode = "Новый код паспорта 2"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Patients.UpdatePatientAsync(patients);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Удаление пациента с корректным Id")]
        //[Ignore("Требуется отдельный запуск")]
        public async Task RemovePatientsAsync_WhenValidPatientsId_ThenSuccess()
        {
            int id = 5;
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Patients.RemovePatientAsync(id);

            Assert.IsTrue(result.HasValue);
        }
    }
}
