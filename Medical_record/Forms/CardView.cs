using Medical_record.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_record.Forms
{
    public partial class CardView : Form
    {
        private readonly CardViewModel _cardViewModel;

        public CardView(CardViewModel cardViewModel)
        {
            InitializeComponent();
            _cardViewModel = cardViewModel ??
                throw new ArgumentNullException(nameof(cardViewModel));

            _buttonAddPatient.Click += (s, e) => _cardViewModel.ShowRegistrationView();
            _buttonUpdatePatient.Click += (s, e) => _cardViewModel.ShowRegistrationView();
        }
    }
}
