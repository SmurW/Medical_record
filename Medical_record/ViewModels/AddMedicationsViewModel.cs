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
        public string ArrivalPackages { get; set; }
        public DateTime ShelfLife { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public string QuantityPackage { get; set; }
        public string RestPackages { get; set; }
        public string RemainedUnits { get; set; }

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
            Result<string> result = new Result<string>("Error");
            var medications = GetMedications();
            if (Id == 0)
            {
                //запоминаем
                result = await _appController.DataContext.AddMedicationsAsync(medications);
            }
            else
            {
                //обновляем
                result = await _appController.DataContext.UpdateMedicationsAsync(medications);
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
