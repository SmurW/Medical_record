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
    }
}
