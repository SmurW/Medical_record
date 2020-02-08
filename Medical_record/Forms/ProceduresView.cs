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
        private readonly ProceduresViewModel _proceduresViewModel;

        public ProceduresView(ProceduresViewModel proceduresViewModel)
        {
            InitializeComponent();
            _proceduresViewModel = proceduresViewModel ??
                throw new ArgumentNullException(nameof(proceduresViewModel));

            _buttonAdd.Click += (s, e) => _proceduresViewModel.ShowAddProceduresView();
            _buttonUpdate.Click += (s, e) => _proceduresViewModel.ShowAddProceduresView();
        }
    }
}
