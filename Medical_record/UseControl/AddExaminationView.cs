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
    public partial class AddExaminationView : UserControl
    {
        public AddExaminationViewModel ViewModel { get; }

        public AddExaminationView(AddExaminationViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;

            _dateTimePicker.DataBindings.Add("Value", ViewModel, nameof(ViewModel.ExaminationDate));
            _labelCount.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Count));

            _comboBoxDiagnosis.DataSource = ViewModel.Diagnoses;
            _comboBoxDiagnosis.DisplayMember = nameof(Diagnosis.Name);
            _comboBoxDiagnosis.ValueMember = nameof(Diagnosis.Id);
            _comboBoxDiagnosis.DataBindings.Add(nameof(_comboBoxDiagnosis.SelectedValue),
                ViewModel, nameof(ViewModel.DiagnosisId));

            _comboBoxHealthGroup.DataSource = ViewModel.HealthGroups;
            _comboBoxHealthGroup.DisplayMember = nameof(HealthGroup.Title);
            _comboBoxHealthGroup.ValueMember = nameof(HealthGroup.Id);
            _comboBoxHealthGroup.DataBindings.Add(nameof(_comboBoxHealthGroup.SelectedValue),
                ViewModel, nameof(ViewModel.HealthGroupId));

            _comboBoxDoctor.DataSource = ViewModel.Doctors;
            _comboBoxDoctor.DisplayMember = nameof(Doctor.SpecAndFio);
            _comboBoxDoctor.ValueMember = nameof(Doctor.Id);
            _comboBoxDoctor.DataBindings.Add(nameof(_comboBoxDoctor.SelectedValue),
                ViewModel, nameof(ViewModel.DoctorId));
        }
    }
}
