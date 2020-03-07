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
    public class SqlServerHealthGroupsTests
    {
        [TestMethod]
        [Description("Получение полного списка групп здаровья, удаленные исключены")]
        public async Task GetHealthGroupsAsync_ReturnsListHealthGroups()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<HealthGroup>> result = await sut.HealthGroups.GetHealthGroupsAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение групп здаровья по cуществующему Id")]
        public async Task GetHealthGroupsByIdAsync_WhenValidId_ReturnsHealthGroups()
        {
            var id = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<HealthGroup> result = await sut.HealthGroups.GetHealthGroupByIdAsync(id);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(id, result.Value.Id);
            Assert.IsFalse(string.IsNullOrEmpty(result.Value.Title));
        }

        [TestMethod]
        [Description("Получение групп здаровья по не существ. Id приводит к возвр.ошибки")]
        public async Task GetHealthGroupsByIdAsync_WhenNotValidId_ReturnsError()
        {
            var id = 1000;
            IDataContext sut = new MsSqlDataContext();

            Result<HealthGroup> result = await sut.HealthGroups.GetHealthGroupByIdAsync(id);

            Assert.IsFalse(result.HasValue);
            Assert.IsFalse(string.IsNullOrEmpty(result.Error));
        }
    }
}
