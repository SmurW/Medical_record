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
    public class SqlServerUsersTest
    {
        [TestMethod]
        [Description("Получение полного списка пользователей, удаленные исключены")]
        public async Task GetUsersAsync_ReturnsListUsers()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Users>> result = await sut.Users.GetUserAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }

        [TestMethod]
        [Description("Добавление нового пользователя с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task AddUsersAsync_WhenValidUser_ThenSuccess()
        {
            var user = new Users
            {
                Login = "Admin",
                Password = "1234"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Users.AddUserAsync(user);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Обновление пользователя с корректными свойствами успешно")]
        [Ignore("Требуется отдельный запуск")]
        public async Task UpdateUsersAsync_WhenValidUsers_ThenSuccess()
        {
            var users = new Users
            {
                Id = 5,
                Login = "Новый логин пользователя 2",
                Password = "Новый пароль пользователя 2"
            };
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Users.UpdateUserAsync(users);

            Assert.IsTrue(result.HasValue);
        }

        [TestMethod]
        [Description("Удаление пользователя с корректным Id")]
        [Ignore("Требуется отдельный запуск")]
        public async Task RemoveUsersAsync_WhenValidUsersId_ThenSuccess()
        {
            int id = 5;
            IDataContext sut = new MsSqlDataContext();

            Result<string> result = await sut.Users.RemoveUserAsync(id);

            Assert.IsTrue(result.HasValue);
        }
    }
}
