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
    public partial class AddMedicationsView : Form
    {
        private readonly AddMedicationsViewModel _addMedicationsViewModel;

        public AddMedicationsView(AddMedicationsViewModel addMedicationsViewModel)
        {
            InitializeComponent();
            _addMedicationsViewModel = addMedicationsViewModel;
            
            _textBoxArrivalPackage.DataBindings.Add("Text", _addMedicationsViewModel, nameof(_addMedicationsViewModel.ArrivalPackages),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxDescription.DataBindings.Add("Text", _addMedicationsViewModel, nameof(_addMedicationsViewModel.Description),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxQuantityPackage.DataBindings.Add("Text", _addMedicationsViewModel, nameof(_addMedicationsViewModel.QuantityPackage),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxRestPackage.DataBindings.Add("Text", _addMedicationsViewModel, nameof(_addMedicationsViewModel.RestPackages),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxRemainedUnits.DataBindings.Add("Text", _addMedicationsViewModel, nameof(_addMedicationsViewModel.RemainedUnits),
                true, DataSourceUpdateMode.OnPropertyChanged);

            _dateTimeArivalDate.DataBindings.Add("Value", _addMedicationsViewModel, nameof(_addMedicationsViewModel.ArrivalDate));
            _datePikerShelfLife.DataBindings.Add("Value", _addMedicationsViewModel, nameof(_addMedicationsViewModel.ShelfLife));

            _comboBoxName.DataBindings.Add("Text", _addMedicationsViewModel, nameof(_addMedicationsViewModel.Name));

            _buttonAddMedecine.Click += (s, e) => _addMedicationsViewModel.SaveMedications();

            Load += AddMedicationsView_Load;
        }

        private void AddMedicationsView_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
