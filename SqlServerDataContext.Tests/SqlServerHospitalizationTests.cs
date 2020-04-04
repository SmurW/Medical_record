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
    public class SqlServerHospitalizationTests
    {
        [TestMethod]
        [Description("Получение числа госпитализаций пациента по Id пациента")]
        public async Task GetCountHospitalizationsByPatientIdAsync_WhenPatientId1_ThenCount1()
        {
            int patientId = 1;
            int countHosps = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<int> result = await sut.Hospitalizations
                .GetCountHospitalizationsByPatientIdAsync(patientId);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(countHosps, result.Value);
        }

        [TestMethod]
        [Description("Получение госпитализаций пациента по Id пациента")]
        public async Task GetHospitalizationsByPatientIdAsync_WhenPatientId1_ReturnsOneHospitalization()
        {
            int patientId = 1;
            int countHosps = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<List<Hospitalization>> result = await sut.Hospitalizations
                .GetHospitalizationsByPatientIdAsync(patientId);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(countHosps, result.Value.Count);
        }

        [TestMethod]
        [Description("Добавление госпитализации для корректного Id пациента")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddHospitalizationAsync_WhenPatientId1_ThenSuccess()
        {
            int patientId = 3;
            var hosp = new Hospitalization
            {
                PatientId = patientId,
                StartHospitalizationDate = new DateTime(year: 2015, month: 3, day: 29),
                EndHospitalizationDate = new DateTime(year: 2015, month: 4, day: 15),
                MedicalOrganization = "Гор.болница №1",
                DefinitiveDiagnosis = "Тяжелое воспаление хитрости"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Hospitalizations.AddHospitalizationAsync(hosp);

            Assert.IsTrue(result.HasValue);
        }
    }
}
