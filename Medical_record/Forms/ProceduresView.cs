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

namespace Medical_record
{
    public partial class ProceduresView : Form
    {
        private readonly ProceduresViewModel _viewModel;
        private BindingSource _bsProcedures;

        public ProceduresView(ProceduresViewModel proceduresViewModel)
        {
            InitializeComponent();
            _viewModel = proceduresViewModel ??
                throw new ArgumentNullException(nameof(proceduresViewModel));

            _bsProcedures = new BindingSource();
            _bsProcedures.DataSource = typeof(List<Procedure>);
            _dataGridViewProcedures.AutoGenerateColumns = false;
            _dataGridViewProcedures.DataSource = _bsProcedures;
            _columnOrderNumber.DataPropertyName = nameof(Procedure.OrderNumber);
            _columnName.DataPropertyName = nameof(Procedure.Name);
            _columnDescr.DataPropertyName = nameof(Procedure.Description);
            _textBoxSearch.DataBindings.Add("Text",
                _viewModel, nameof(_viewModel.FindInput), true, DataSourceUpdateMode.OnPropertyChanged);

            _buttonAdd.Click += (s, e) => _viewModel.ShowAddProceduresView();
            _buttonUpdate.Click += (s, e)
                => _viewModel.ShowAddProceduresView(_bsProcedures.Current as Procedure);
            _buttonRemove.Click += (s, e)
                => _viewModel.RemoveProcedure(_bsProcedures.Current as Procedure);

            _viewModel.ProceduresChanged += ViewModel_ProceduresChanged;
            _comboBoxSort.SelectedValueChanged += ComboBoxSort_SelectedValueChanged;
            this.Activated += ProceduresView_Activated;
        }

        /// <summary>
        /// Сортировка процедур после выбора в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ComboBoxSort_SelectedValueChanged(object sender, EventArgs e)
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
        private void ViewModel_ProceduresChanged(object sender, EventArgs e)
        {
            _comboBoxSort.Text = String.Empty;
            ReloadBindingSource();
        }

        /// <summary>
        /// Активация формы приводит к перечитыванию данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ProceduresView_Activated(object sender, EventArgs e)
        {
            _comboBoxSort.Text = String.Empty;
            await _viewModel.LoadDataAsync();
            ReloadBindingSource();
        }

        /// <summary>
        /// Перезагрузка данных в источник данных для DGV
        /// </summary>
        private void ReloadBindingSource()
        {
            _bsProcedures.Clear();
            _viewModel.Procedures.ForEach(p => _bsProcedures.Add(p));
        }
    }
}
