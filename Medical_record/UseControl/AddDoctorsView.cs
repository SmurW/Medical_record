using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_record.UseControl
{
    public partial class AddDoctorsView : UserControl
    {
        public AddDoctorsViewModel ViewModel { get; }

        public AddDoctorsView(AddDoctorsViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;

            _dateTimePickerDateInspection.DataBindings.Add("Value",
                ViewModel, nameof(ViewModel.DateInspection),
                true, DataSourceUpdateMode.OnPropertyChanged);

            _comboBoxDiagnosisDisease.DataSource = ViewModel.Diagnoses;
            _comboBoxDiagnosisDisease.DisplayMember = nameof(Diagnosis.Name);
            _comboBoxDiagnosisDisease.DataBindings.Add("SelectedItem",
                ViewModel, nameof(ViewModel.SelectedDiagnosis));
            _comboBoxHealthGroup.DataBindings.Add("Text", ViewModel, nameof(ViewModel.HealtGroup));

            _labelCount.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Count));

            _buttonSaveDoctors.Click += (s, e) => ViewModel.SaveDoctorNotes();
        }
    }
}
