using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class DiagnosesViewModel
    {
        private readonly AppController _appController;

        public DiagnosesViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        /// <summary>
        /// Коллекция диагнозов
        /// </summary>
        public List<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();

        /// <summary>
        /// Коллекция диагнозов изменилась
        /// </summary>
        public event EventHandler DiagnosesChanged;

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
                                         .GetDiagnosesLikeAsync(_FindInput.Trim());
                if (result.HasValue)
                {
                    SetAndOrderDiagnoses(result);
                }
                else
                {
                    MessagesService.ShowErrorMessage(result.Error);
                }
            }

            DiagnosesChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Переход к форме ввода диагноза
        /// </summary>
        internal void ShowDiagnosisView() => _appController.ShowDiagnosisView();
        internal void ShowDiagnosisView(Diagnosis diagnosis)
            => _appController.ShowDiagnosisView(diagnosis);

        /// <summary>
        /// Загрузка диагнозов из БД
        /// </summary>
        /// <returns></returns>
        internal async Task LoadDataAsync()
        {
            var result = await _appController.DataContext.GetDiagnosesAsync();
            if (result.HasValue)
            {
                SetAndOrderDiagnoses(result);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Удаление диагноза
        /// </summary>
        /// <param name="diagnosis"></param>
        internal async void RemoveDiagnosis(Diagnosis diagnosis)
        {
            var message = $"Вы согласны удалить диагноз {diagnosis.Name}?";
            bool agreeRemove = MessagesService.GetAgree(message);
            if (!agreeRemove)
                return;

            var result = await _appController.DataContext.RemoveDiagnosisAsync(diagnosis.Id);
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

            var result = await _appController.DataContext.GetDiagnosesOrderByAsync(key);
            if (result.HasValue)
            {
                SetAndOrderDiagnoses(result);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Присвоение и пронумеровывание диагнозов
        /// </summary>
        /// <param name="result"></param>
        private void SetAndOrderDiagnoses(Result<List<Diagnosis>> result)
        {
            Diagnoses = result.Value;
            int num = 0;
            Diagnoses.ForEach(d => d.OrderNumber = ++num);
        }
    }
}
