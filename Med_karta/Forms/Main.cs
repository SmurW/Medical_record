using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_karta.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //приявязка событий
            this.FormClosed += Form_Close;
            _buttonAddCart.Click += Bitton_AddCart;
        }

        private void Bitton_AddCart(object sender, EventArgs e)
        {
            this.Hide();
            Medical_record medical = new Medical_record();
            medical.Show();
        }

        private void Form_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
