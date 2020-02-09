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
            _textBoxSearchByName.DataBindings.Add("Text",
                _viewModel, nameof(_viewModel.FindInput), true, DataSourceUpdateMode.OnPropertyChanged);

            _buttonAdd.Click += (s, e) => _viewModel.ShowDiagnosisView();
            _buttonUpdate.Click += (s, e)
                => _viewModel.ShowDiagnosisView(_bsDiagnoses.Current as Diagnosis); 
            _buttonRemove.Click += (s, e)
                => _viewModel.RemoveDiagnosis(_bsDiagnoses.Current as Diagnosis);

            _viewModel.DiagnosesChanged += ViewModel_DiagnosesChanged;
            _comboBoxSelectSort.SelectedValueChanged += ComboBoxSelectSort_SelectedValueChanged;
            this.Activated += DiagnosesView_Activated;
        }

        /// <summary>
        /// Активация формы приводит к перечитыванию данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DiagnosesView_Activated(object sender, EventArgs e)
        {
            _comboBoxSelectSort.Text = String.Empty;
            await _viewModel.LoadDataAsync();
            ReloadBindingSource();
        }

        /// <summary>
        /// Сортировка диагнозов после выбора в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ComboBoxSelectSort_SelectedValueChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (String.IsNullOrEmpty(cb.Text))
                return;

            await _viewModel.LoadDataSortedByAsync(cb.Text);
            ReloadBindingSource();
        }

        /// <summary>
        /// Обновление источника данных после поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewModel_DiagnosesChanged(object sender, EventArgs e)
        {
            _comboBoxSelectSort.Text = String.Empty;
            ReloadBindingSource();
        }

        /// <summary>
        /// Перезагрузка данных в источник данных для DGV
        /// </summary>
        private void ReloadBindingSource()
        {
            _bsDiagnoses.Clear();
            _viewModel.Diagnoses.ForEach(d => _bsDiagnoses.Add(d));
        }
    }
}
