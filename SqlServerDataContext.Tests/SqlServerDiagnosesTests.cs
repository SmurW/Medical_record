using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Data.Models;
using Medical_record.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlServerDataContext.Tests
{
    [TestClass]
    public class SqlServerDiagnosesTests
    {
        [TestMethod]
        [Description("Получение полного списка диагнозов, удаленные исключены")]
        public async Task GetDiagnosesAsync_ReturnsListDiagnoses()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Diagnosis>> result = await sut.Diagnoses.GetDiagnosesAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count == 3 );
        }

        [TestMethod]
        [Description("Получение списка диагнозов отсортированных по Названию диагноза")]
        public async Task GetDiagnosesOrderByAsync_WhenOrderByName_ReturnsListDiagnoses()
        {
            var key = "Name";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Diagnosis>> result = await sut.Diagnoses.GetDiagnosesOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count == 3);
        }

        [TestMethod]
        [Description("Получение списка диагнозов отсортированных по Описанию диагноза")]
        public async Task GetDiagnosesOrderByAsync_WhenOrderByDescription_ReturnsListDiagnoses()
        {
            var key = "Description";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Diagnosis>> result = await sut.Diagnoses.GetDiagnosesOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count == 3);
        }

        [TestMethod]
        [Description("Получение списка диагнозов у которых Name начинается с заданного значения")]
        public async Task GetDiagnosesLikeAsync_WhenSearchNameLike_ReturnsListDiagnoses()
        {
            var value = "Гр";
            var name = "Грипп";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Diagnosis>> result = await sut.Diagnoses.GetDiagnosesLikeAsync(value);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count == 1);
            Assert.AreEqual(name, result.Value[0].Name);
        }
    }
}
