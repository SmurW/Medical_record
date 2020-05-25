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
    public class SqlServerExaminationsTests
    {
        [TestMethod]
        [Description("Получение полного списка осмотров по Id пациента")]
        public async Task GetExaminationsByPatientIdAsync_ReturnsExaminations()
        {
            int patientId = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<List<Examination>> result =
                await sut.Examinations.GetExaminationsByPatientIdAsync(patientId);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
            Assert.IsNotNull(result.Value[0].Diagnosis);
            Assert.IsNotNull(result.Value[0].Doctor);
            Assert.IsNotNull(result.Value[0].HealthGroup);
        }

        [TestMethod]
        [Description("Получение количества осмотров по Id пациента")]
        public async Task GetCountExaminationsByPatientIdAsync_ReturnsCountExaminations()
        {
            int patientId = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<int> result =
                await sut.Examinations.GetCountExaminationsByPatientIdAsync(patientId);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value > 0);
        }

        [TestMethod]
        [Description("Добавление нового осмотра")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddExaminationAsync_ReturnSuccess()
        {
            var exam = new Examination
            {
                ExaminationDate = DateTime.Parse("18.04.2019"),
                PatientId = 1,
                DiagnosisId = 1,
                HealthGroupId = 1,
                DoctorId = 3,
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Examinations.AddExaminationAsync(exam);

            Assert.IsTrue(result.HasValue);
        }
    }
}
