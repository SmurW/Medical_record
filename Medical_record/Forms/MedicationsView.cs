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
    public partial class MedicationsView : Form
    {
        private readonly MedicationsViewModel _medicationsViewModel;
        private readonly BindingSource _bsMedications;

        public MedicationsView(MedicationsViewModel medicationsViewModel)
        {
            InitializeComponent();
            _medicationsViewModel = medicationsViewModel ??
                throw new ArgumentNullException(nameof(medicationsViewModel));

            AddColumnsInDGV();

            _buttonAddMedication.Click += (s, e) => _medicationsViewModel.ShowAddMedicationsView();
            _buttonUpdateMedication.Click += (s, e) => _medicationsViewModel.ShowAddMedicationsView();
        }

        /// <summary>
        /// Дабовление столбцов в датагридвью
        /// </summary>
        private void AddColumnsInDGV()
        {
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name", HeaderText = "Наименование" });
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ArrivalDate", HeaderText = "Дата прихода" });
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ArrivalPackages", HeaderText = "Приход упаковок" });
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ShelfLife", HeaderText = "Срок годности" });
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Description", HeaderText = "Описание" });
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "QuantityPackage", HeaderText = "Количество в упаковке" });
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "RestPackages", HeaderText = "Остаток упаковок" });
            _dataGridViewMedicat.Columns.Add(new DataGridViewTextBoxColumn() { Name = "RemainedUnits", HeaderText = "Остаток едениц" });
        }

        /// <summary>
        /// Установка привязок у датагридвью
        /// </summary>
        private void SetDataGridViewBindings()
        {

        }
    }
}
