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

        internal void ShowDiagnosisView()
        {
            _appController.ShowDiagnosisView();
        }
    }
}
