using Medical_record.Data.Models;
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

namespace Medical_record
{
    public partial class Mainfrom_MedicalRecord : Form
    {
        private readonly MainViewModel _viewModel;
        private readonly AutorizationsViewModels _autorizationsViewModels;
        private readonly BindingSource _bsUsers;

        public Mainfrom_MedicalRecord(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel ??
                throw new ArgumentNullException(nameof(viewModel));

            _buttonCard.Click += (s, e) => _viewModel.ShowCardView();
            _buttonDiagnoses.Click += (s, e) => _viewModel.ShowDiagnosesView();
            _buttonMedications.Click += (s, e) => _viewModel.ShowMedicationsView();
            _buttonProcedures.Click += (s, e) => _viewModel.ShowProceduresView();
            _buttonDoctors.Click += (s, e) => _viewModel.ShowDoctorsView();
            _linkLabel.Click += (s, e) => _viewModel.ShowAboutProgram();
            _buttonEnter.Click += (s, e) => _viewModel.ShowAutorization();

            //привязки 
            Load += Mainfrom_MedicalRecord_Load;
        }

        private void Mainfrom_MedicalRecord_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //var user = _bsUsers.Current as Users;
            //if (user != null)
            //_autorizationsViewModels.SetCurrentUserLogin(user.Login);
            //Text = $"Привет {user.Login}";

        }
    }
}
