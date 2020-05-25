using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Data.Models;
using Medical_record.Utils;


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
        }
    }
}
