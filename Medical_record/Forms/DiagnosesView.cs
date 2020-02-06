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
    public partial class DiagnosesView : Form
    {
        private readonly DiagnosesViewModel _diagnosesViewModel;

        public DiagnosesView(DiagnosesViewModel diagnosesViewModel)
        {
            InitializeComponent();
            _diagnosesViewModel = diagnosesViewModel ??
                throw new ArgumentNullException(nameof(diagnosesViewModel));

            _buttonAddDiagnosis.Click += (s, e) => _diagnosesViewModel.ShowDiagnosisView();
            _buttonUpdateDiagnosis.Click += (s, e) => _diagnosesViewModel.ShowDiagnosisView();
        }
    }
}
