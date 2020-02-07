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
    public partial class DiagnosesView : Form
    {
        private readonly DiagnosesViewModel _viewModel;
        private readonly BindingSource _bsDiagnoses;

        public DiagnosesView(DiagnosesViewModel diagnosesViewModel)
        {
            InitializeComponent();
            _viewModel = diagnosesViewModel ??
                throw new ArgumentNullException(nameof(diagnosesViewModel));

            _bsDiagnoses = new BindingSource();
            _bsDiagnoses.DataSource = typeof(List<Diagnosis>);
            _dataGridViewDiagnoses.AutoGenerateColumns = false;
            _dataGridViewDiagnoses.DataSource = _bsDiagnoses;
            _columnOrderNumber.DataPropertyName = nameof(Diagnosis.OrderNumber);
            _columnName.DataPropertyName = nameof(Diagnosis.Name);
            _columnDescr.DataPropertyName = nameof(Diagnosis.Description);

            _buttonAdd.Click += (s, e) => _viewModel.ShowDiagnosisView();
            _buttonUpdate.Click += (s, e) => _viewModel.ShowDiagnosisView();

            this.Activated += DiagnosesView_Activated;
        }

        /// <summary>
        /// Активация формы приводит к перечитыванию данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DiagnosesView_Activated(object sender, EventArgs e)
        {
            await _viewModel.LoadDataAsync();
            if (_bsDiagnoses.Count != 0)
            {
                _bsDiagnoses.Clear();
            }
            _viewModel.Diagnoses.ForEach(d => _bsDiagnoses.Add(d));
        }
    }
}
