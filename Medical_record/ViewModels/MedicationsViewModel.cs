using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medical_record.Data.Models;

namespace Medical_record.ViewModels
{
    public class MedicationsViewModel
    {
        private readonly AppController _appController;

        public MedicationsViewModel(AppController appController)
        {
            _appController = appController;
        }

        internal void ShowAddMedicationsView()
        {
            _appController.ShowAddMedicationsView();
        }

        public List<Medications> Medications { get; set; } = new List<Medications>();
    }
}
