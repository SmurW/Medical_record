using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class CardViewModel
    {
        private readonly AppController _appController;

        public CardViewModel(AppController appController)
        {
            _appController = appController
                ?? throw new ArgumentNullException(nameof(appController));
        }

        internal void ShowRegistrationView()
        {
            _appController.ShowRegistrationView();
        }
    }
}
