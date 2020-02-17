using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using System;
using System.Windows.Forms;

namespace Medical_record.UseControl
{
    public partial class HospitalizationView : UserControl
    {
        private BindingSource _bsHosps;

        public HospitalizationViewModel ViewModel { get; }

        public HospitalizationView(HospitalizationViewModel hospitalizationViewModel)
        {
            InitializeComponent();
            ViewModel = hospitalizationViewModel;

            _bsHosps = new BindingSource();
            _bsHosps.DataSource = ViewModel.Hospitalizations;

            _textBoxStartDate.DataBindings.Add("Text",
                _bsHosps, nameof(Hospitalization.StartHospitalizationDate), true);
            _textBoxEndDate.DataBindings.Add("Text",
                _bsHosps, nameof(Hospitalization.EndHospitalizationDate), true);
            _textBoxDiag.DataBindings.Add("Text",
                _bsHosps, nameof(Hospitalization.DefinitiveDiagnosis));
            _textBoxMedOrg.DataBindings.Add("Text",
                _bsHosps, nameof(Hospitalization.MedicalOrganization));

            _bsHosps.CurrentItemChanged += _bsHosps_CurrentItemChanged;
            ViewModel.NextClicked += (s, e) => _bsHosps.MoveNext();
            ViewModel.PreviousClicked += (s, e) => _bsHosps.MovePrevious();
            this.Load += HospitalizationView_Load;
        }

        private void HospitalizationView_Load(object sender, EventArgs e)
        {
            _labelCount.Text = $"1/{_bsHosps.Count}";
        }

        private void _bsHosps_CurrentItemChanged(object sender, EventArgs e)
        {
            _labelCount.Text = $"{_bsHosps.IndexOf(_bsHosps.Current) + 1}/{_bsHosps.Count}";
        }
    }
}
