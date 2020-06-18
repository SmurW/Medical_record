using Medical_record.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Medical_record.Forms
{
    public partial class RegistrationView : Form
    {
        private readonly RegistrationViewModel _viewModel;
        private UserControl _userControl;

        public RegistrationView(RegistrationViewModel registrationViewModel)
        {
            InitializeComponent();
            _viewModel = registrationViewModel ??
                throw new ArgumentNullException(nameof(registrationViewModel));

            SetBindings();

            _buttonSavePatient.Click += (s, e) => _viewModel.SavePatient();
            _buttonAddObserv.Click += ButtonAddObserv_Click;
            _buttonAddDoctor.Click += ButtonAddExam_Click;
            _buttonAddHospital.Click += ButtonAddHospital_Click;
        }

        /// <summary>
        /// Привязки
        /// </summary>
        private void SetBindings()
        {
            _textBoxCardNumber.DataBindings.Add("Text", _viewModel, nameof(_viewModel.CardNumber),
                            true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxFirstName.DataBindings.Add("Text", _viewModel, nameof(_viewModel.FirstName),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxLastName.DataBindings.Add("Text", _viewModel, nameof(_viewModel.LastName),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxMiddleName.DataBindings.Add("Text", _viewModel, nameof(_viewModel.MiddleName),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxPassportDepCode.DataBindings.Add("Text", _viewModel, nameof(_viewModel.PassportDepCode),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxPassportNumber.DataBindings.Add("Text", _viewModel, nameof(_viewModel.PassportNumber),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxPassportSeries.DataBindings.Add("Text", _viewModel, nameof(_viewModel.PassportSeries),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxPassportUFMS.DataBindings.Add("Text", _viewModel, nameof(_viewModel.PassportUFMS),
                true, DataSourceUpdateMode.OnPropertyChanged);
            _textBoxResidence.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Residence),
                true, DataSourceUpdateMode.OnPropertyChanged);

            _dateTimePickerBirthdate.DataBindings.Add("Value", _viewModel, nameof(_viewModel.Birthdate));
            _dateTimePickerPassportIssueDate.DataBindings.Add("Value", _viewModel, nameof(_viewModel.PassportIssueDate));
            _dateTimePickerRegistrationDate.DataBindings.Add("Value", _viewModel, nameof(_viewModel.RegistrationDate));

            _comboBoxSex.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Sex));
        }

        /// <summary>
        /// Отображение uc ввода данных по госпитализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAddHospital_Click(object sender, EventArgs e)
        {
            _userControl = await _viewModel.GetUcViewAsync("Ho");
            ShowUcView();
        }

        /// <summary>
        /// Отображение uc ввода осмотра врачем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAddExam_Click(object sender, EventArgs e)
        {
            _userControl = await _viewModel.GetUcViewAsync("Ex");
            ShowUcView();
        }

        /// <summary>
        /// Отображение формы ввода Обследований
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAddObserv_Click(object sender, EventArgs e)
        {
            //получаем нужную uc
            _userControl = await _viewModel.GetUcViewAsync("Ob");
            //отображаем
            ShowUcView();
        }

        /// <summary>
        /// Отображение (с замещением) нужной UserControl
        /// </summary>
        private void ShowUcView()
        {
            if (_panel.Controls.Count == 0)
            {
                this.Height += _userControl.Height;
            }
            else
            {
                var oldUc = _panel.Controls.OfType<UserControl>().First();
                this.Height -= oldUc.Height;
                this.Height += _userControl.Height;
                _panel.Controls.Remove(oldUc);
            }

            _panel.Controls.Add(_userControl);
        }

    }
}