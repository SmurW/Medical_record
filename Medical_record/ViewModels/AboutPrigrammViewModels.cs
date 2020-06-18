using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_record.ViewModels
{
   
    public class AboutPrigrammViewModels
    {
        private readonly AppController _appController;

        public AboutPrigrammViewModels(AppController appController)
        {
            _appController = appController
                ?? throw new ArgumentNullException(nameof(appController));
        }
    }
}
