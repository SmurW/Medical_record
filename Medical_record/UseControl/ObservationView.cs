using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medical_record.UseControl.ViewModels;
using Medical_record.Data.Models;

namespace Medical_record.UseControl
{
    public partial class ObservationView : UserControl
    {
        private BindingSource _bsObs;

        public ObservationViewModel ViewModel { get; }

        public ObservationView(ObservationViewModel observationViewModel)
        {
            InitializeComponent();
            ViewModel = observationViewModel;

            _bsObs = new BindingSource();
            _bsObs.DataSource = ViewModel.Observations;

            _textBoxStartDate.DataBindings.Add("Text",
                _bsObs, nameof(Observation.StartObservationDate), true);
            _textBoxEndDate.DataBindings.Add("Text",
                _bsObs, nameof(Observation.EndObservationDate), true);
            _textBoxDiagnosis.DataBindings.Add("Text", _bsObs, nameof(Observation.DiagnosisName));
            _textBoxDoctor.DataBindings.Add("Text", _bsObs, nameof(Observation.DoctorFio));

            _bsObs.CurrentItemChanged += _bsObs_CurrentItemChanged;
            ViewModel.NextClicked += (s, e) => _bsObs.MoveNext();
            ViewModel.PreviousClicked += (s, e) => _bsObs.MovePrevious();
            this.Load += ObservationView_Load;
        }

        private void ObservationView_Load(object sender, EventArgs e)
        {
            _labelCount.Text = $"1/{_bsObs.Count}";
        }

        private void _bsObs_CurrentItemChanged(object sender, EventArgs e)
        {
            _labelCount.Text = $"{_bsObs.IndexOf(_bsObs.Current) + 1}/{_bsObs.Count}";
        }
    }
}
