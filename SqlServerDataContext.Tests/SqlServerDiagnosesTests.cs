using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Data.Models;
using Medical_record.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка диагнозов отсортированных по Названию диагноза")]
        public async Task GetDiagnosesOrderByAsync_WhenOrderByName_ReturnsListDiagnoses()
        {
            var key = "Name";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Diagnosis>> result = await sut.Diagnoses.GetDiagnosesOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка диагнозов отсортированных по Описанию диагноза")]
        public async Task GetDiagnosesOrderByAsync_WhenOrderByDescription_ReturnsListDiagnoses()
        {
            var key = "Description";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Diagnosis>> result = await sut.Diagnoses.GetDiagnosesOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
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

        [TestMethod]
        [Description("Получение диагноза по cуществующему Id")]
        public async Task GetDiagnosisByIdAsync_WhenValidId_ReturnsDiagnosis()
        {
            var id = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<Diagnosis> result = await sut.Diagnoses.GetDiagnosisByIdAsync(id);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(id, result.Value.Id);
            Assert.IsFalse(string.IsNullOrEmpty(result.Value.Name));
            Assert.IsFalse(string.IsNullOrEmpty(result.Value.Description));
        }

        [TestMethod]
        [Description("Получение диагноза по не существ. Id приводит к возвр.ошибки")]
        public async Task GetDiagnosisByIdAsync_WhenNotValidId_ReturnsError()
        {
            var id = 1000;
            IDataContext sut = new MsSqlDataContext();

            Result<Diagnosis> result = await sut.Diagnoses.GetDiagnosisByIdAsync(id);

            Assert.IsFalse(result.HasValue);
            Assert.IsFalse(string.IsNullOrEmpty(result.Error));
        }

        [TestMethod]
        [Description("Добавление нового диагноза с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddDiagnosisAsync_WhenValidDiagnosis_ThenSuccess()
        {
            var diag = new Diagnosis
            {
                Name = "Новый диагноз из теста",
                Description = "Новое описание из теста"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Diagnoses.AddDiagnosisAsync(diag);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Обновление диагноза с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task UpdateDiagnosisAsync_WhenValidDiagnosis_ThenSuccess()
        {
            var diag = new Diagnosis
            {
                Id = 1,
                Name = "Новый диагноз из теста",
                Description = "Новое описание из теста"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Diagnoses.UpdateDiagnosisAsync(diag);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Удаление диагноза с корректным Id")]
        [Ignore("Требуется отдельный запуск")]
        public async Task RemoveDiagnosisAsync_WhenValidDiagnosisId_ThenSuccess()
        {
            int id = 5;
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Diagnoses.RemoveDiagnosisAsync(id);

            Assert.IsTrue(result.HasValue);
        }
    }
}
