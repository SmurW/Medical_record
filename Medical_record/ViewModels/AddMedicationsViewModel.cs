using Medical_record.Data.Models;
using Medical_record.Utils;
using System;

namespace Medical_record.ViewModels
{
    public class AddMedicationsViewModel
    {
        private readonly AppController _appController;

        public AddMedicationsViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ArrivalDate { get; set; } = DateTime.Now;
        public int ArrivalPackages { get; set; }
        public DateTime ShelfLife { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public int QuantityPackage { get; set; }
        public int RestPackages { get; set; }
        public int RemainedUnits { get; set; }

        internal void SetMedications(Medications medications)
        {
            Id = medications.Id;
            Name = medications.Name;
            Description = medications.Description;
            ArrivalDate = medications.ArrivalDate;
            ArrivalPackages = medications.ArrivalPackages;
            ShelfLife = medications.ShelfLife;
            QuantityPackage = medications.QuantityPackage;
            RestPackages = medications.RestPackages;
            RemainedUnits = medications.RemainedUnits;
        }

        internal async void SaveMedications()
        {
            Result<string> result = new Result<string>("Данные не заполнены");
            var medications = GetMedications();
            if (Id == 0)
            {
                //запоминаем
                try
                {
                    result = await _appController.DataContext
                    .Medications.AddMedicationsAsync(medications);
                }
                catch (Exception ex)
                {
                    //_appController.MessageService.ShowErrorMessage(result.Error);
                }
                
            }
            else
            {
                //обновляем
                result = await _appController.DataContext
                    .Medications.UpdateMedicationsAsync(medications);
            }

            if (result.HasValue)
            {
                _appController.MessageService.ShowInfoMessage(result.Value);
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
            }
        }

        private Medications GetMedications()
        {
            return new Medications
            {
                Id = Id,
                Name = Name,
                Description = Description,
                ArrivalDate = ArrivalDate,
                ArrivalPackages = ArrivalPackages,
                ShelfLife = ShelfLife,
                QuantityPackage = QuantityPackage,
                RestPackages = RestPackages,
                RemainedUnits = RemainedUnits,
            };
        }
    }
}
