using Med_karta.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_karta.Forms
{
    public partial class Form_Researches : Form
    {
        public Form_Researches()
        {
            InitializeComponent();

            //привязка событий
            _buttonResearches.Click += ButtonAddreserches;
            this.Load += Form_Researches_Load;
        }

        private void Form_Researches_Load(object sender, EventArgs e)
        {
            DataContext data = new DataContext();
            data.Connection();
            OleDbCommand command = new OleDbCommand("SELECT * FROM `Личные_данные` WHERE (`Фамилия`,`Имя`,`Отчество`)", data.getConnection());

            DataTable table = new DataTable();

            OleDbDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                _comBoxIssled.Items.Add(reader["Фамилия"].ToString() + reader["Имя"].ToString() + reader["Отчество"].ToString());
            }
        }

        private void ButtonAddreserches(object sender, EventArgs e)
        {
            
        }
    }
}
