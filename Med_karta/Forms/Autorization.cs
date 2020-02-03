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
    public partial class Autorization : Form
    {

        public Autorization()
        {
            InitializeComponent();

            _txtboxPassword.UseSystemPasswordChar = true;

            //привязка 
            _visiblePassword.Click += VisiblePassword;
            _buttonAutorization.Click += ButtonAutorization_Click;
            _labelRegistr.Click += LabelRegistr_Click;
            
        }

        private void VisiblePassword(object sender, EventArgs e)
        {
            
            if (_txtboxPassword.UseSystemPasswordChar)
            {
                _visiblePassword.Image = Properties.Resources.PassTrue as Bitmap;
                _txtboxPassword.UseSystemPasswordChar = false;
            }
            else if(!_txtboxPassword.UseSystemPasswordChar)
            {
                _visiblePassword.Image = Properties.Resources.PassFalse as Bitmap;
                _txtboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void ButtonAutorization_Click(object sender, EventArgs e)
        {
            if(_buttonAutorization.Text == "Регистрация")
            {
                Registrations();
            }
            if(_buttonAutorization.Text == "Войти")
            {
                Autorizations();
            }
        }

        private void Autorizations()
        {
            DataContext data = new DataContext();
            
            String username = _txtboxLogin.Text;
            String password = _txtboxPassword.Text;

            DataTable table = new DataTable();

            OleDbDataAdapter adapter = new OleDbDataAdapter();

            OleDbCommand command = new OleDbCommand("SELECT * FROM `Пользователи` WHERE `Логин`= @log and `Пароль` = @pass", data.getConnection());

            command.Parameters.Add("@log", OleDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", OleDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Введите имя пользователя для входа", "Пустое имя пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Введите пароль для входа", "Пустой пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "неправильные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Registrations()
        {
            DataContext data = new DataContext();
            
            String username = _txtboxLogin.Text;
            String password = _txtboxPassword.Text;
            
            OleDbCommand command = new OleDbCommand("INSERT INTO `Пользователи` (`Логин`,`Пароль`) VALUES (@log,@pass)", data.getConnection());

            command.Parameters.Add("@log",OleDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", OleDbType.VarChar).Value = password;

            data.Connection();
            
            if (checkUsername())
            {
                MessageBox.Show("Это имя пользователя уже существует, выберите другое", "дублировать имя пользователя", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация прошла успешно");
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
            }
            data.Disconnection();
            
            _txtboxLogin.Clear();
            _txtboxPassword.Clear();

        }

        public Boolean checkUsername()
        {
            DataContext dc = new DataContext();
            DataTable table = new DataTable();

            String login = _txtboxLogin.Text;

            OleDbDataAdapter adapter = new OleDbDataAdapter();

            OleDbCommand command = new OleDbCommand("SELECT * FROM `Пользователи` WHERE `Логин`= @log", dc.getConnection());

            command.Parameters.Add("@log", OleDbType.VarChar).Value = login;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LabelRegistr_Click(object sender, EventArgs e)
        {
            if (_labelRegistr.Text == "Зарегистрированы? Войдите!")
            {
                _labelRegistr.Text = "Не зарегистрированы? Зергистрируйтесь!";
                _buttonAutorization.Text = "Войти";
                this.Text = _buttonAutorization.Text;
                _txtboxLogin.Clear();
            }
            else if (_labelRegistr.Text != "Зарегистрированы? Войдите!")
            {
                _labelRegistr.Text = "Зарегистрированы? Войдите!";
                _buttonAutorization.Text = "Регистрация";
                this.Text = _buttonAutorization.Text;
                _txtboxPassword.Clear();
            }
        }

        private void CheckTextBox()
        {
            if (String.IsNullOrWhiteSpace(_txtboxLogin.Text))
            {
                _txtboxLogin.Focus();
            }
            if (String.IsNullOrWhiteSpace(_txtboxPassword.Text))
            {
                _txtboxPassword.Focus();
            }
        }
        
    }
}
