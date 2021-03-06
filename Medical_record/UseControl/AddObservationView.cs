﻿using Medical_record.Data.Models;
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
    public partial class AddObservationView : UserControl
    {
        public AddObservationViewModel ViewModel { get; }

        public AddObservationView(AddObservationViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;

            _dateTimePickerStart.DataBindings.Add("Value",
                ViewModel, nameof(ViewModel.StartObservationDate),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _dateTimePickerEnd.DataBindings.Add("Value",
                ViewModel, nameof(ViewModel.EndObservationDate),
                true, DataSourceUpdateMode.OnPropertyChanged);

            _comboBoxDiagnosis.DataSource = ViewModel.Diagnoses;
            _comboBoxDiagnosis.DisplayMember = nameof(Diagnosis.Name);
            _comboBoxDiagnosis.ValueMember = nameof(Diagnosis.Id);
            _comboBoxDiagnosis.DataBindings.Add(nameof(_comboBoxDiagnosis.SelectedValue),
                ViewModel, nameof(ViewModel.DiagnosisId));

            _comboBoxDoctor.DataSource = ViewModel.Doctors;
            _comboBoxDoctor.DisplayMember = nameof(Doctor.SpecAndFio);
            _comboBoxDoctor.ValueMember = nameof(Doctor.Id);
            _comboBoxDoctor.DataBindings.Add(nameof(_comboBoxDoctor.SelectedValue),
                ViewModel, nameof(ViewModel.DoctorId));

            _labelCount.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Count));

            _buttonSave.Click += (s, e) => ViewModel.SaveObservation();
        }

    }
}
