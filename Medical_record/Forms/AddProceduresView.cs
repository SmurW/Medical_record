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
    public partial class AddProceduresView : Form
    {
        private AddProceduresViewModel _addProceduresViewModel;

        public AddProceduresView(AddProceduresViewModel addProceduresViewModel)
        {
            InitializeComponent();
            _addProceduresViewModel = addProceduresViewModel ??
                throw new ArgumentNullException(nameof(addProceduresViewModel));
        }
    }
}
