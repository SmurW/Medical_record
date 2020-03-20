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
    public class SqlServerDoctorsTests
    {
        [TestMethod]
        [Description("Получение полного списка докторов, удаленные исключены")]
        public async Task GetDoctorsAsync_ReturnsListDoctors()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Doctor>> result = await sut.Doctors.GetDoctorsAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Получение доктора по cуществующему Id")]
        public async Task GetDoctorByIdAsync_WhenValidId_ReturnsDoctor()
        {
            var id = 1;
            IDataContext sut = new MsSqlDataContext();

            Result<Doctor> result = await sut.Doctors.GetDoctorByIdAsync(id);

            Assert.IsTrue(result.HasValue);
            Assert.AreEqual(id, result.Value.Id);
            Assert.IsFalse(string.IsNullOrEmpty(result.Value.LastName));
            Assert.IsFalse(string.IsNullOrEmpty(result.Value.FirstName));
            Assert.IsFalse(string.IsNullOrEmpty(result.Value.MiddleName));
            Assert.IsFalse(string.IsNullOrEmpty(result.Value.SpecializationName));
        }

        [TestMethod]
        [Description("Добавление нового доктора с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddDoctorAsync_WhenValidDoctor_ThenSuccess()
        {
            var doc = new Doctor
            {
                LastName = "Новенков",
                FirstName = "Новый",
                MiddleName = "Новенкович",
                SpecializationId = 4
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Doctors.AddDoctorAsync(doc);

            Assert.IsTrue(result.HasValue);
        }
    }
}
