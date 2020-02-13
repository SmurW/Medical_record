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
        private DoctorsViewModel _doctorsViewModel;

        public DoctorsView(DoctorsViewModel doctorsViewModel)
        {
            InitializeComponent();
            _doctorsViewModel = doctorsViewModel;

            //привязка текстбоксов
            _textBoxLastName.DataBindings.Add("Text", _doctorsViewModel,
                nameof(_doctorsViewModel.Doctors), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxFirstName.DataBindings.Add("Text", _doctorsViewModel,
                nameof(_doctorsViewModel.Doctors), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxMiddleName.DataBindings.Add("Text", _doctorsViewModel,
                nameof(_doctorsViewModel.Doctors), true, DataSourceUpdateMode.OnPropertyChanged);

            //привязка сомбобокса
            _comboBoxSpecialization.DataSource = _doctorsViewModel.Specializations;
            _comboBoxSpecialization.DisplayMember = nameof(Specialization.Name);
            _comboBoxSpecialization.DataBindings.Add("SelectedItem", _doctorsViewModel, nameof(_doctorsViewModel.SelectedSpecializations));
        }
        
    }
}
