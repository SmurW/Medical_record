﻿using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class ProceduresViewModel
    {
        private readonly AppController _appController;

        public ProceduresViewModel(AppController appController)
        {
            _appController = appController;
        }

        /// <summary>
        /// Коллекция процедур
        /// </summary>
        public List<Procedure> Procedures { get; set; } = new List<Procedure>();

        /// <summary>
        /// Коллекция процедур изменилась
        /// </summary>
        public event EventHandler ProceduresChanged;

        /// <summary>
        /// Строка поиска
        /// </summary>
        private string _FindInput;
        public string FindInput
        {
            get { return _FindInput; }
            set
            {
                _FindInput = value;
                HandlingFindInput();
            }
        }

        /// <summary>
        /// Работа с данными поиска
        /// </summary>
        private async void HandlingFindInput()
        {
            if (String.IsNullOrWhiteSpace(_FindInput))
            {
                await LoadDataAsync();
            }
            else
            {
                var result = await _appController.DataContext
                                         .Procedures.GetProceduresLikeAsync(_FindInput.Trim());
                if (result.HasValue)
                {
                    SetAndOrderProcedures(result);
                }
                else
                {
                    _appController.MessageService.ShowErrorMessage(result.Error);
                }
            }

            ProceduresChanged?.Invoke(this, EventArgs.Empty);
        }

        internal async void RemoveProcedure(Procedure procedure)
        {
            var message = $"Вы согласны удалить процедуру {procedure.Name}?";
            bool agreeRemove = _appController.MessageService.GetAgree(message);
            if (!agreeRemove)
                return;

            var result = await _appController.DataContext
                .Procedures.RemoveProcedureAsync(procedure.Id);
            if (result.HasValue)
            {
                _appController.MessageService.ShowInfoMessage(result.Value);
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Переход к форме ввода процедуры
        /// </summary>
        internal void ShowAddProceduresView() => _appController.ShowAddProceduresView();
        internal void ShowAddProceduresView(Procedure procedure)
            => _appController.ShowAddProceduresView(procedure);

        internal async Task LoadDataSortedByAsync(string propName)
        {
            string key = String.Empty;
            if (propName.Contains("Наим"))
            {
                key = "Name";
            }
            else
            {
                key = "Description";
            }

            var result = await _appController.DataContext
                .Procedures.GetProceduresOrderByAsync(key);
            if (result.HasValue)
            {
                SetAndOrderProcedures(result);
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Загрузка процедур из БД
        /// </summary>
        /// <returns></returns>
        internal async Task LoadDataAsync()
        {
            var result = await _appController.DataContext.Procedures.GetProceduresAsync();
            if (result.HasValue)
            {
                SetAndOrderProcedures(result);
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Присвоение и пронумеровывание
        /// </summary>
        /// <param name="result"></param>
        private void SetAndOrderProcedures(Result<List<Procedure>> result)
        {
            Procedures = result.Value;
            int num = 0;
            Procedures.ForEach(p => p.OrderNumber = ++num);
        }
    }
}
