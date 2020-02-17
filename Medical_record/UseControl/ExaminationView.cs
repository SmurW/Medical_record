using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using System;
using System.Windows.Forms;

namespace Medical_record.UseControl
{
    public partial class ExaminationView : UserControl
    {
        private BindingSource _bsExams;

        public ExaminationViewModel ViewModel { get; }

        public ExaminationView(ExaminationViewModel examinationViewModel)
        {
            InitializeComponent();
            ViewModel = examinationViewModel;

            _bsExams = new BindingSource();
            _bsExams.DataSource = ViewModel.Examinations;

            _textBoxDate.DataBindings.Add("Text",
                _bsExams, nameof(Examination.ExaminationDate), true);
            _textBoxGroup.DataBindings.Add("Text", _bsExams, nameof(Examination.HelthGroupTitle));
            _textBoxDiagnosis.DataBindings.Add("Text", _bsExams, nameof(Examination.DiagnosisName));
            _textBoxDoctor.DataBindings.Add("Text", _bsExams, nameof(Examination.DoctorFio));

            _bsExams.CurrentItemChanged += _bsExams_CurrentItemChanged;
            ViewModel.NextClicked += (s, e) => _bsExams.MoveNext();
            ViewModel.PreviousClicked += (s, e) => _bsExams.MovePrevious();
            this.Load += ExaminationView_Load;
        }

        private void ExaminationView_Load(object sender, EventArgs e)
        {
            _labelCount.Text = $"1/{_bsExams.Count}";
        }

        private void _bsExams_CurrentItemChanged(object sender, EventArgs e)
        {
            _labelCount.Text = $"{_bsExams.IndexOf(_bsExams.Current) + 1}/{_bsExams.Count}";
        }
    }
}
