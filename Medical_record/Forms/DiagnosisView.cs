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
    public partial class DiagnosisView : Form
    {
        private DiagnosisViewModel _viewModel;

        public DiagnosisView(DiagnosisViewModel diagnosisViewModel)
        {
            InitializeComponent();
            _viewModel = diagnosisViewModel;

            _textBoxDescr.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.Description), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxName.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.Name), true, DataSourceUpdateMode.OnPropertyChanged);

            _buttonSave.Click += (s, e) => _viewModel.SaveDiagnosis();
        }
    }
}
