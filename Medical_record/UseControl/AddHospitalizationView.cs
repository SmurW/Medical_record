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
    public partial class AddHospitalizationView : UserControl
    {
        public AddHospitalizationViewModel ViewModel { get; }

        public AddHospitalizationView(AddHospitalizationViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;

            _dateTimePickerStart.DataBindings.Add("Value",
                ViewModel, nameof(ViewModel.StartHospitalizationDate),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _dateTimePickerEnd.DataBindings.Add("Value",
                ViewModel, nameof(ViewModel.EndHospitalizationDate),
                true, DataSourceUpdateMode.OnPropertyChanged);

            _labelCount.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Count));

            _buttonSave.Click += (s, e) => ViewModel.SaveHospitalization();
        }
    }
}
