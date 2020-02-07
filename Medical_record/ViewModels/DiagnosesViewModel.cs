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
        /// Переход к форме ввода диагноза
        /// </summary>
        internal void ShowDiagnosisView() => _appController.ShowDiagnosisView();

        internal async Task LoadDataAsync()
        {
            Result<List<Diagnosis>> result = await _appController.DataContext.GetAllDiagnosesAsync();
            if (result.HasValue)
            {
                Diagnoses = result.Value;
                int num = 0;
                Diagnoses.ForEach(d => d.OrderNumber = ++num);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }
    }
}
