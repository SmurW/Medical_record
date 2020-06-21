using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
   public class TestUsersDataContext : IUserDataContext
    {
        private readonly DataSource _dataSource;

        public TestUsersDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddUserAsync(Users users)
        {
            users.Id = 1;
            if (_dataSource.Users.Count > 0)
            {
                users.Id = _dataSource.Users.Max(d => d.Id) + 1;
            }
            _dataSource.Users.Add(users);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {users.Login}", String.Empty));
        }

        public Task<Result<List<Users>>> GetUserAsync()
        {
            return Task.FromResult(new Result<List<Users>>(_dataSource.Users));
        }

        public Task<Result<List<Users>>> GetUsersLikeAsync(string value)
        {
            return Task.FromResult(
                   new Result<List<Users>>(
                       _dataSource.Users.Where(d => d.Login.Contains(value)).ToList()));
        }

        public Task<Result<string>> RemoveUserAsync(int id)
        {
            var us = _dataSource.Users.FirstOrDefault(d => d.Id == id);
            if (us == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _dataSource.Users.Remove(us);
            return Task.FromResult(new Result<string>("Успешно удален", String.Empty));
        }

        public Task<Result<string>> UpdateUserAsync(Users users)
        {
            var us = _dataSource.Users.FirstOrDefault(d => d.Id == users.Id);
            if (us == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            us.Login = users.Login;
            us.Password = users.Password;
            return Task.FromResult(new Result<string>("Успешно обновлен", String.Empty));
        }

    }
}
