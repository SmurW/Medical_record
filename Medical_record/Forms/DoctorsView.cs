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
    public partial class DoctorsView : Form
    {
        private DoctorsViewModel _doctorsViewModel;

        public DoctorsView(DoctorsViewModel doctorsViewModel)
        {
            InitializeComponent();
            _doctorsViewModel = doctorsViewModel;
        }
    }
}
