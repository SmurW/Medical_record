using Medical_record.Data.Models;
using Medical_record.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using Medical_record.Utils;
using System.Drawing;

namespace Medical_record.Forms
{
    public partial class AutorizationView : Form
    {
        private readonly AutorizationsViewModels _viewModel;
        //private readonly AppController _appController;

        public AutorizationView(AutorizationsViewModels autorizationsViewModels)
        {
            InitializeComponent();
            _viewModel = autorizationsViewModels ??
                throw new ArgumentNullException(nameof(autorizationsViewModels));

            //_bsUsers = new BindingSource();
            //_bsUsers.DataSource = _viewModel.Users;

            SetBindings();

            //привязка 
            Load += Autorizationfrom_Load;
            _checkBoxVisiblePassword.Click += CheckBoxVisPass_Click;

            //привязка кнопки
            _buttonRegistration.Click += ButtonRegistration_Click;
            _buttonEnter.Click += ButtonEnter_Click;

            //привязка лейблов
            _labelRegAndEnt.Click += LabelRegistrAndEnter_Click;

            //привзяка текстбоксов
            //_textBoxRegLogin.Enter += TextBoxRegLogin_Enter;
            //_textBoxRegLogin.Leave += TextBoxRegLogin_Leave;
            //_textBoxRegPassword.Enter += TextBoxRegPassword_Enter;
            //_textBoxRegPassword.Leave += TextBoxRegPassword_Leave;
            
        }

        //private void TextBoxRegPassword_Leave(object sender, EventArgs e)
        //{
        //    String pass = _textBoxRegPassword.Text;
        //    if (pass.ToLower().Trim() == "введите пароль" || pass.Trim() == "")
        //    {
        //        _textBoxRegPassword.Text = "введите пароль";
        //        _textBoxRegPassword.ForeColor = Color.Gray;
        //    }
        //}

        //private void TextBoxRegPassword_Enter(object sender, EventArgs e)
        //{
        //    String pass = _textBoxRegPassword.Text;
        //    if (pass.ToLower().Trim() == "введите пароль")
        //    {
        //        _textBoxRegPassword.Clear();
        //        _textBoxRegPassword.ForeColor = Color.Black;
        //    }
            
        //}

        //private void TextBoxRegLogin_Leave(object sender, EventArgs e)
        //{
        //    String log = _textBoxRegLogin.Text;
        //    if (log.ToLower().Trim() == "введите логин" || log.Trim() == "")
        //    {
        //        _textBoxRegLogin.Text = "введите логин";
        //        _textBoxRegLogin.ForeColor = Color.Gray;
        //    }
        //}

        //private void TextBoxRegLogin_Enter(object sender, EventArgs e)
        //{
        //    String log = _textBoxRegLogin.Text;
        //    if (log.ToLower().Trim() == "введите логин")
        //    {
        //        _textBoxRegLogin.Clear();
        //        _textBoxRegLogin.ForeColor = Color.Black;
        //    }
        //}

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            
            if(_textBoxRegLogin.Text != "введите логин" && _textBoxRegPassword.Text != "введите пароль")
            {
                _viewModel.SaveUser();

                _textBoxRegLogin.Hide();
                _textBoxRegPassword.Hide();
                _labelRegAndEnt.Hide();
                _buttonRegistration.Hide();
                //if(InAndOutVsisble())
            }
            else MessageBox.Show("Логин или пароль не введены!", "Внимание, поля не должны быть пустыми!");
            
        }

        /// <summary>
        /// Метод для отображения пороля.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckBoxVisPass_Click(object sender, EventArgs e)
        {
            if (_checkBoxVisiblePassword.Checked)
            {
                _textBoxPassword.UseSystemPasswordChar = true;
                _textBoxRegPassword.UseSystemPasswordChar = true;
            }
            else
            {
                _textBoxPassword.UseSystemPasswordChar = false;
                _textBoxRegPassword.UseSystemPasswordChar = false;
            }
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            _textBoxRegLogin.Clear();
            _textBoxRegPassword.Clear();

            if (_textBoxLogin.Text != string.Empty && _textBoxPassword.Text != string.Empty)
            {
                _viewModel.ReadUser();
                //MessageBox.Show($"Привет {_viewModel.SetCurrentUserLogin()}");
            }
            else MessageBox.Show("Введите для входа Логин и Пароль", "Внимание, поля не должны быть пустыми!");
        }

        /// <summary>
        /// Установка привязок у текстбоксов
        /// </summary>
        private void SetBindings()
        {
            //_textBoxRegPassword.DataBindings.Add("Text", _bsUsers, nameof(Users.Password));
            //_textBoxRegLogin.DataBindings.Add("Text", _bsUsers, nameof(Users.Login));
            _textBoxRegLogin.DataBindings.Add("Text", _viewModel,
              nameof(_viewModel.Login), true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxRegPassword.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.Password), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Переход между Входом и Регистрацией
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LabelRegistrAndEnter_Click(object sender, EventArgs e)
        {
            //_textBoxLogin.Visible = false;
            //_textBoxPassword.Visible = false;
            //_buttonEnter.Visible = false;
            _textBoxRegLogin.Location = _textBoxLogin.Location;
            _textBoxRegPassword.Location = _textBoxPassword.Location;
            _buttonRegistration.Location = _buttonEnter.Location;

            _labelRegAndEnt.Hide();
        }

        /// <summary>
        /// Загрузка начальных параметров
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Autorizationfrom_Load(object sender, EventArgs e)
        {
            _checkBoxVisiblePassword.Checked = true;
            _textBoxPassword.UseSystemPasswordChar = true;
            _textBoxRegPassword.UseSystemPasswordChar = true;

            //_textBoxRegLogin.ForeColor = Color.Gray;
            //_textBoxRegPassword.ForeColor = Color.Gray;
            //_textBoxRegPassword.Text = "введите пароль";
            //_textBoxRegLogin.Text = "введите логин";

            this.BackgroundImageLayout = ImageLayout.Stretch;
            //_labelRegAndEnt.Show();
        }

       

        


    }
}
