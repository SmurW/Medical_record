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
    public partial class MainForm_MedicalRecord : Form
    {
        private readonly MainViewModel _viewModel;

        public MainForm_MedicalRecord(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel ??
                throw new ArgumentNullException(nameof(viewModel));

            _buttonCard.Click += (s, e) => _viewModel.ShowCardView();
            _buttonDiagnoses.Click += (s, e) => _viewModel.ShowDiagnosesView();
            _buttonMedications.Click += (s, e) => _viewModel.ShowMedicationsView();
            _buttonProcedures.Click += (s, e) => _viewModel.ShowProceduresView();
            _buttonDoctors.Click += (s, e) => _viewModel.ShowDoctorsView();
        }
    }
}
