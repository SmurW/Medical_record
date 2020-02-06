using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class DoctorsViewModel
    {
        private readonly AppController _appController;

        public DoctorsViewModel(AppController appController)
        {
            _appController = appController;
        }
    }
}
