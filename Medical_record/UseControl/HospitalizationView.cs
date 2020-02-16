using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medical_record.UseControl.ViewModels;

namespace Medical_record.UseControl
{
    public partial class HospitalizationView : UserControl
    {
        public HospitalizationViewModel ViewModel { get; }

        public HospitalizationView(HospitalizationViewModel hospitalizationViewModel)
        {
            InitializeComponent();
            ViewModel = hospitalizationViewModel;
        }
    }
}
