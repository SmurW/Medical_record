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
        }
    }
}
