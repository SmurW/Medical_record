using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class MedicationsViewModel
    {
        private readonly AppController _appController;

        public MedicationsViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        /// <summary>
        /// Переход к форме ввода лекарств
        /// </summary>
        internal void ShowAddMedicationsView() => _appController.ShowAddMedicationsView();
        internal void ShowAddMedicationsView(Medications medications)
            => _appController.ShowAddMedicationsView(medications);

        /// <summary>
        /// Коллекция лекарств
        /// </summary>
        public List<Medications> Medications { get; set; } = new List<Medications>();


        /// <summary>
        /// Коллекция лекарств изменилась
        /// </summary>
        public event EventHandler MedicationsChanged;

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
                                         .GetMedicationsLikeAsync(_FindInput.Trim());
                if (result.HasValue)
                {
                    SetAndOrderMedications(result);
                }
                else
                {
                    MessagesService.ShowErrorMessage(result.Error);
                }
            }

            MedicationsChanged?.Invoke(this, EventArgs.Empty);
        }

        

        /// <summary>
        /// Загрузка лекарств из БД
        /// </summary>
        /// <returns></returns>
        internal async Task LoadDataAsync()
        {
            var result = await _appController.DataContext.GetMedicationsAsync();
            if (result.HasValue)
            {
                SetAndOrderMedications(result);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Удаление лекарства
        /// </summary>
        /// <param name="medications"></param>
        internal async void RemoveMedications(Medications medications)
        {
            var message = $"Вы согласны удалить лекарство {medications.Name}?";
            bool agreeRemove = MessagesService.GetAgree(message);
            if (!agreeRemove)
                return;

            var result = await _appController.DataContext.RemoveMedicationsAsync(medications.Id);
            if (result.HasValue)
            {
                MessagesService.ShowInfoMessage(result.Value);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="propName"></param>
        /// <returns></returns>
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

            var result = await _appController.DataContext.GetMedicationsOrderByAsync(key);
            if (result.HasValue)
            {
                SetAndOrderMedications(result);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Присвоение и пронумеровывание лекарств
        /// </summary>
        /// <param name="result"></param>
        private void SetAndOrderMedications(Result<List<Medications>> result)
        {
            Medications = result.Value;
            int num = 0;
            Medications.ForEach(d => d.OrderNumber = ++num);
        }
    }
}
