using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_record.ViewModels
{
    public class AutorizationsViewModels
    {
        private readonly AppController _appController;
        private string _Users;

        public AutorizationsViewModels(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        internal void SetUsers(Users users)
        {
            Id = users.Id;
            Login = users.Login;
            Password = users.Password;
        }

        /// <summary>
        /// Сохранение в БД пользователя
        /// </summary>
        internal async void SaveUser()
        {
            var result = new Result<string>("Error");
            Users users = GetUser();
            if (Id == 0)
            {
                //запоминаем нового
                result = await _appController.DataContext
                    .Users.AddUserAsync(users);
            }
            //else
            //{
            //    //обновляем уже существующего
            //    result = await _appController.DataContext
            //        .Users.UpdateUserAsync(users);
            //}

            //if (!result.HasValue)
            //{
            //    _appController.MessageService.ShowErrorMessage(result.Error);
            //    return;
            //}
          //  _appController.MessageService.ShowInfoMessage(result.Value);
            
            
        }
        internal void ShowAutorizationView() => _appController.ShowAutorizationView();
        internal void ShowAutorizationView(Users users) => _appController.ShowAutorizationView(users);

        internal async void ReadUser()
        {
            var user = new Users();
            var result = await _appController.DataContext
               .Users.GetUserAsync();

            if (result.HasValue)
            {
                if (result.Value.Count > 0 && result.Value.Count == user.Id)
                {
                    ShowAutorizationView();
                }
            }
        }

        /// <summary>
        /// Получение экземпляра Users из
        /// свойств этой вьюмодели и отображенной uc
        /// </summary>
        /// <returns></returns>
        public Users GetUser()
        {
            var result = new Users
            {
                Id = Id,
                Login = Login,
                Password = Password
                
            };
            return result;
        }

        internal void SetCurrentUserLogin(string users)
        {
            _Users = users;
        }

        /// <summary>
        /// Коллекция пациентов
        /// </summary>
        public BindingList<Users> Users { get; private set; } = new BindingList<Users>();

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        internal async void RemoveUser(Users users)
        {
            var message = $"Вы согласны удалить {users.Login}?";
            bool agreeRemove = _appController.MessageService.GetAgree(message);
            if (!agreeRemove)
                return;

            var result = await _appController.DataContext
                .Users.RemoveUserAsync(users.Id);
            if (result.HasValue)
            {
                _appController.MessageService.ShowInfoMessage(result.Value);
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
            }
        }

        internal async void Hellouser(Users users)
        {
            var message = $"Привет {users.Login}!";

            var result = await _appController.DataContext
               .Users.GetUserAsync();

            if (result.HasValue)
            {
                if (result.Value.Count > 0)
                {
                     message = $"Привет {users.Login}";
                }
            }
            
        }
    }
}
