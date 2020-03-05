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
    public class SqlServerProceduresTests
    {
        [TestMethod]
        [Description("Получение полного списка процедур, удаленные исключены")]
        public async Task GetProceduresAsync_ReturnsListProcedures()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Procedure>> result = await sut.Procedures.GetProceduresAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка процедур отсортированных по Названию процедуры")]
        public async Task GetProceduresOrderByAsync_WhenOrderByName_ReturnsListProcedures()
        {
            var key = "Name";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Procedure>> result = await sut.Procedures.GetProceduresOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка процедур отсортированных по Описанию процедуры")]
        public async Task GetProceduresOrderByAsync_WhenOrderByDescription_ReturnsListProcedures()
        {
            var key = "Description";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Procedure>> result = await sut.Procedures.GetProceduresOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка процедур у которых Name начинается с заданного значения")]
        public async Task GetProceduresLikeAsync_WhenSearchNameLike_ReturnsListProcedures()
        {
            var value = "Пр";
            var name = "Процедура 1";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Procedure>> result = await sut.Procedures.GetProceduresLikeAsync(value);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
            Assert.AreEqual(name, result.Value[0].Name);
        }

        [TestMethod]
        [Description("Добавление новой процедуры с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddProceduresAsync_WhenValidProcedures_ThenSuccess()
        {
            var diag = new Procedure
            {
                Name = "Новая процедура из теста",
                Description = "Новое описание из теста"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Procedures.AddProcedureAsync(diag);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Обновление процедуры с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task UpdateProceduresAsync_WhenValidProcedures_ThenSuccess()
        {
            var diag = new Procedure
            {
                Id = 1,
                Name = "Новая 1 процедура из теста",
                Description = "Новое 1 описание из теста"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Procedures.UpdateProcedureAsync(diag);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Удаление процедуры с корректным Id")]
        [Ignore("Требуется отдельный запуск")]
        public async Task RemoveProceduresAsync_WhenValidProceduresId_ThenSuccess()
        {
            int id = 5;
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Procedures.RemoveProcedureAsync(id);

            Assert.IsTrue(result.HasValue);
        }
    }
}

