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

namespace Medical_record.Forms
{
    public partial class DoctorsView : Form
    {
        private DoctorsViewModel _viewModel;

        public DoctorsView(DoctorsViewModel doctorsViewModel)
        {
            InitializeComponent();
            _viewModel = doctorsViewModel;

            //DGV
            _dataGridViewDoctors.AutoGenerateColumns = false;
            _dataGridViewDoctors.DataSource = _viewModel.Doctors;
            _columnOrderNumber.DataPropertyName = nameof(Doctor.OrderNumber);
            _columnFirstName.DataPropertyName = nameof(Doctor.FirstName);
            _columnLastName.DataPropertyName = nameof(Doctor.LastName);
            _columnMiddleName.DataPropertyName = nameof(Doctor.MiddleName);
            _columnSpec.DataPropertyName = nameof(Doctor.SpecializationName);

            //привязка текстбоксов
            _textBoxLastName.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.LastName), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxFirstName.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxMiddleName.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.MiddleName), true, DataSourceUpdateMode.OnPropertyChanged);

            //привязка комбобокса
            _comboBoxSpecialization.DataSource = _viewModel.Specializations;
            _comboBoxSpecialization.DisplayMember = nameof(Specialization.Name);

            _buttonSave.Click += ButtonSave_Click;
            this.Load += DoctorsView_Load;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _viewModel.SaveDoctor(_comboBoxSpecialization.SelectedItem);

            _textBoxFirstName.Text = String.Empty;
            _textBoxLastName.Text = String.Empty;
            _textBoxMiddleName.Text = String.Empty;
            _textBoxLastName.Focus();
        }

        private async void DoctorsView_Load(object sender, EventArgs e)
        {
            await _viewModel.LoadDataAsync();
        }
    }
}
