using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class ProceduresViewModel
    {
        private readonly AppController _appController;

        public ProceduresViewModel(AppController appController)
        {
            _appController = appController;
        }

        internal void ShowAddProceduresView()
        {
            _appController.ShowAddProceduresView();
        }
    }
}
