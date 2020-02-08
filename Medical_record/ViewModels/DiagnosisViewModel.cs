using Medical_record.Data.Models;
using Medical_record.Utils;
using System;

namespace Medical_record.ViewModels
{
    public class DiagnosisViewModel
    {
        private readonly AppController _appController;

        public DiagnosisViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        internal void SetDiagnosis(Diagnosis diagnosis)
        {
            Id = diagnosis.Id;
            Name = diagnosis.Name;
            Description = diagnosis.Description;
        }

        internal async void SaveDiagnosis()
        {
            Result<string> result = new Result<string>("Error");
            if (Id == 0)
            {
                //запоминаем
                var diagnosis = GetDiagnosis();
                result = await _appController.DataContext.AddDiagnosisAsync(diagnosis);
            }
            else
            {
                //обновляем
                var diagnosis = GetDiagnosis();
                result = await _appController.DataContext.UpdateDiagnosisAsync(diagnosis);
            }

            if (result.HasValue)
            {
                MessagesService.ShowInfoMessage(result.Value);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        private Diagnosis GetDiagnosis()
        {
            return new Diagnosis
            {
                Id = Id,
                Name = Name,
                Description = Description,
            };
        }
    }
}
