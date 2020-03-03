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
    public class SqlServerMedicationsTests
    {
        [TestMethod]
        [Description("Получение полного списка лекарств, удаленные исключены")]
        public async Task GetMedicationsAsync_ReturnsListMedications()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Medications>> result = await sut.Medications.GetMedicationsAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка лекарств отсортированных по Названию")]
        public async Task GetMedicationsOrderByAsync_WhenOrderByName_ReturnsListMedications()
        {
            var key = "Name";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Medications>> result = await sut.Medications.GetMedicationsOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка лекарств отсортированных по Описанию")]
        public async Task GetMedicationsOrderByAsync_WhenOrderByDescription_ReturnsListMedications()
        {
            var key = "Descriptions";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Medications>> result = await sut.Medications.GetMedicationsOrderByAsync(key);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение списка лекарств у которых Name начинается с заданного значения")]
        public async Task GetMedicationsLikeAsync_WhenSearchNameLike_ReturnsListMedications()
        {
            var value = "Ар";
            var name = "Арбидол";
            IDataContext sut = new MsSqlDataContext();

            Result<List<Medications>> result = await sut.Medications.GetMedicationsLikeAsync(value);

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
            Assert.IsTrue(result.Value[0].Name.Contains(name));
        }

        [TestMethod]
        [Description("Добавление нового лекарства с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddMedicationsAsync_WhenValidMedications_ThenSuccess()
        {
            var medics = new Medications
            {
                Name = "Новое лекарство 1",
                Description = "Описание нового лекарства 1",
                ArrivalDate = DateTime.Parse("14.02.2010"),
                ArrivalPackages = 245,
                QuantityPackage = 45,
                RemainedUnits = 13,
                RestPackages = 200,
                ShelfLife = DateTime.Parse("01.07.2011")
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Medications.AddMedicationsAsync(medics);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Обновление лекарства с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task UpdateMedicationsAsync_WhenValidMedications_ThenSuccess()
        {
            var medics = new Medications
            {
                Id = 1,
                Name = "Новое лекарство 2",
                Description = "Описание нового лекарства 2",
                ArrivalDate = DateTime.Parse("14.02.2010"),
                ArrivalPackages = 245,
                QuantityPackage = 45,
                RemainedUnits = 13,
                RestPackages = 200,
                ShelfLife = DateTime.Parse("01.07.2011")
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Medications.UpdateMedicationsAsync(medics);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Удаление лекарства с корректным Id")]
        [Ignore("Требуется отдельный запуск")]
        public async Task RemoveMedicationsAsync_WhenValidMedicationsId_ThenSuccess()
        {
            int id = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Medications.RemoveMedicationsAsync(id);

            Assert.IsTrue(result.HasValue);
        }
    }
}
