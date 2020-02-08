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

            _bsMedications = new BindingSource();
            _bsMedications.DataSource = typeof(List<Medication>);
            _dataGridViewDiagnoses.AutoGenerateColumns = false;
            _dataGridViewDiagnoses.DataSource = _bsDiagnoses;
            _columnOrderNumber.DataPropertyName = nameof(Diagnosis.OrderNumber);
            _columnName.DataPropertyName = nameof(Diagnosis.Name);
            _columnDescr.DataPropertyName = nameof(Diagnosis.Description);

            _buttonAddMedication.Click += (s, e) => _medicationsViewModel.ShowAddMedicationsView();
            _buttonUpdateMedication.Click += (s, e) => _medicationsViewModel.ShowAddMedicationsView();


        }

    }
}
