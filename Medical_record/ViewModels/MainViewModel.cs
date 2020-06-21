using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class MainViewModel
    {
        private readonly AppController _appController;
      //  private readonly AutorizationsViewModels _autorizationsViewModels;

        public MainViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        internal void ShowCardView() => _appController.ShowCardView();
        internal void ShowDiagnosesView() => _appController.ShowDiagnosesView();
        internal void ShowMedicationsView() => _appController.ShowMedicationsView();
        internal void ShowProceduresView() => _appController.ShowProceduresView();
        internal void ShowDoctorsView() => _appController.ShowDoctorsView();
        internal void ShowAboutProgram() => _appController.ShowAboutProgramView();
        internal void ShowAutorization() => _appController.ShowAutorizationView();
      //  internal void GetThisUser() => _autorizationsViewModels.SetCurrentUserLogin();
    }
}
