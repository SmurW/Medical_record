using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Name { get; set; }
        public DateTime ArrivalDate { get; set; } = DateTime.Now;
        public string ArrivalPackages { get; set; }
        public DateTime ShelfLife { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public string QuantityPackage { get; set; }
        public string RestPackages { get; set; }
        public string RemainedUnits { get; set; }

        public void AddMedicine()
        {

        }

    }
}
