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
using Medical_record.Data.Models;

namespace Medical_record
{
    public partial class MedicationsView : Form
    {
        private readonly MedicationsViewModel _medicationsViewModel;
        private readonly BindingSource _bsMedications;

        public MedicationsView(MedicationsViewModel medicationsViewModel)
        {
            InitializeComponent();
            _medicationsViewModel = medicationsViewModel ??
                throw new ArgumentNullException(nameof(medicationsViewModel));

            _bsMedications = new BindingSource();
            _bsMedications.DataSource = typeof(List<Medications>);
            _dataGridViewMedicat.AutoGenerateColumns = false;
            _dataGridViewMedicat.DataSource = _bsMedications;
            _columnOrderNumber.DataPropertyName = nameof(Medications.OrderNumber);
            _columnName.DataPropertyName = nameof(Medications.Name);
            _columnArrivalDate.DataPropertyName = nameof(Medications.ArrivalDate);
            _columnArrivalPackage.DataPropertyName = nameof(Medications.ArrivalPackages);
            _columnShelfLife.DataPropertyName = nameof(Medications.ShelfLife);
            _columnDescription.DataPropertyName = nameof(Medications.Description);
            _columnQuantityPackage.DataPropertyName = nameof(Medications.QuantityPackage);
            _columnRestPackage.DataPropertyName = nameof(Medications.RestPackages);
            _columnRemainedUnits.DataPropertyName = nameof(Medications.RemainedUnits);
            _textBoxSearchByName.DataBindings.Add("Text",
               _medicationsViewModel, nameof(_medicationsViewModel.FindInput), true, DataSourceUpdateMode.OnPropertyChanged);

            _buttonAddMedication.Click += (s, e) => _medicationsViewModel.ShowAddMedicationsView();
            _buttonUpdateMedication.Click += (s, e) => _medicationsViewModel.ShowAddMedicationsView();
            _buttonDeleteMedication.Click += (s, e) => _medicationsViewModel.ShowAddMedicationsView();

            _medicationsViewModel.MedicationsChanged += MedicationsViewModel_MedicationsChanged;
            _comboBoxSelectSort.SelectedValueChanged += ComboBoxSelectSort_SelectedValueChanged;
            this.Activated += MedicationsView_Activated;
        }

        /// <summary>
        /// Активация формы приводит к перечитыванию данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MedicationsView_Activated(object sender, EventArgs e)
        {
            _comboBoxSelectSort.Text = String.Empty;
            await _medicationsViewModel.LoadDataAsync();
            ReloadBindingSource();
        }

        /// <summary>
        /// Сортировка лекарств после выбора в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ComboBoxSelectSort_SelectedValueChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (String.IsNullOrEmpty(cb.Text))
                return;

            await _medicationsViewModel.LoadDataSortedByAsync(cb.Text);
            ReloadBindingSource();
        }

        /// <summary>
        /// Обновление источника данных после поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MedicationsViewModel_MedicationsChanged(object sender, EventArgs e)
        {
            _comboBoxSelectSort.Text = String.Empty;
            ReloadBindingSource();
        }

        /// <summary>
        /// Перезагрузка данных в источник данных для DGV
        /// </summary>
        private void ReloadBindingSource()
        {
            _bsMedications.Clear();
            _medicationsViewModel.Medications.ForEach(m => _bsMedications.Add(m));
        }
    }
}
