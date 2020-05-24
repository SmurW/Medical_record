using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;

namespace SqlServerDataContext.Tests
{
    [TestClass]
    public class SqlServerObservationsTests
    {
        [TestMethod]
        [Description("Получение полного списка наблюдений по Id пациента")]
        public async Task GetObservationsByPatientIdAsync_ReturnsObservations()
        {
            int patientId = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<List<Observation>> result =
                await sut.Observations.GetObservationsByPatientIdAsync(patientId);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение количества наблюдений по Id пациента")]
        public async Task GetCountObservationsByPatientIdAsync_ReturnsCountObservations()
        {
            int patientId = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<int> result =
                await sut.Observations.GetCountObservationsByPatientIdAsync(patientId);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value > 0);
        }

        [TestMethod]
        [Description("Добавление нового наблюдения")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddObservationAsync_ReturnSuccess()
        {
            var observation = new Observation
            {
                PatientId = 1,
                DiagnosisId = 1,
                DoctorId = 1,
                StartObservationDate = DateTime.Parse("10.04.2019"),
                EndObservationDate = DateTime.Parse("20.04.2019")
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Observations.AddObservationAsync(observation);

            Assert.IsTrue(result.HasValue);
        }
    }
}
