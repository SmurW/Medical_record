using Medical_record.Data.Models;
using Medical_record.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Medical_record.Forms
{
    public partial class CardView : Form
    {
        private readonly CardViewModel _viewModel;
        private readonly BindingSource _bsPatients;
        private UserControl _userControl;

        public CardView(CardViewModel cardViewModel)
        {
            InitializeComponent();
            _viewModel = cardViewModel ??
                throw new ArgumentNullException(nameof(cardViewModel));

            _bsPatients = new BindingSource();
            _bsPatients.DataSource = _viewModel.Patients;
            SetTextBindings();

            _viewModel.DataLoading += (s, e) => ClearDatesBindings();
            _viewModel.DataLoaded += (s, e) => SetDatesBindings();

            _buttonAddPatient.Click += (s, e) => _viewModel.ShowRegistrationView();
            _buttonUpdatePatient.Click +=
                (s, e) => _viewModel.ShowRegistrationView(_bsPatients.Current as Patient);
            _buttonRemovePatient.Click += 
                (s, e) => _viewModel.RemovePatient(_bsPatients.Current as Patient);
            _buttonNextPatient.Click += ButtonNextPatient_Click;
            _buttonPrevPatient.Click += ButtonPrevPatient_Click;

            _radioButtonLastName.DataBindings.Add("Checked",
                _viewModel, nameof(_viewModel.LastNameChecked), true, DataSourceUpdateMode.OnPropertyChanged);

            _radioButtonNo.Click += RadioButtonAdditions_Click;
            _radioButtonHospitalizations.Click += RadioButtonAdditions_Click;
            _radioButtonExaminations.Click += RadioButtonAdditions_Click;
            _radioButtonObservations.Click += RadioButtonAdditions_Click;

            _buttonNextAddition.Click += (s, e) => _viewModel.NextAddition();
            _buttonPrevAddition.Click += (s, e) => _viewModel.PrevAddition();

            this.Activated += async (s, e) => await _viewModel.LoadDataAsync();
        }

        /// <summary>
        /// Переход к след. пациенту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrevPatient_Click(object sender, EventArgs e)
        {
            _radioButtonNo.Checked = true;
            RadioButtonAdditions_Click(_radioButtonNo, EventArgs.Empty);
            _bsPatients.MovePrevious();
            _viewModel.SetCurrentPatientId((_bsPatients.Current as Patient).Id);
        }

        /// <summary>
        /// Переход к предыдущ. пациенту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNextPatient_Click(object sender, EventArgs e)
        {
            _radioButtonNo.Checked = true;
            RadioButtonAdditions_Click(_radioButtonNo, EventArgs.Empty);
            _bsPatients.MoveNext();
            _viewModel.SetCurrentPatientId((_bsPatients.Current as Patient).Id);
        }

        /// <summary>
        /// Радиокнопки отображения доп. записей о пациенте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RadioButtonAdditions_Click(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            var name = rb.Name.Substring(12, 1);
            switch (name)
            {
                case "N":
                    if (_userControl != null)
                    {
                        this.Height -= _userControl.Height;
                        _panelAdditions.Controls.Remove(_userControl);
                        _userControl = null;
                    }
                    break;
                case "H":
                    _userControl = await _viewModel.GetUcViewAsync("Ho");
                    ShowUcView();
                    break;
                case "E":
                    _userControl = await _viewModel.GetUcViewAsync("Ex");
                    ShowUcView();
                    break;
                case "O":
                    _userControl = await _viewModel.GetUcViewAsync("Ob");
                    ShowUcView();
                    break;
                default:
                    throw new Exception("Ошибка в определении радиокнопки");
            }
        }

        /// <summary>
        /// Установка привязок у текстбоксов и комбобокса и лейбла
        /// </summary>
        private void SetTextBindings()
        {
            _textBoxFirstName.DataBindings.Add("Text", _bsPatients, nameof(Patient.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _bsPatients, nameof(Patient.LastName));
            _textBoxMiddleName.DataBindings.Add("Text", _bsPatients, nameof(Patient.MiddleName));
            _textBoxPassportDepCode.DataBindings.Add("Text", _bsPatients, nameof(Patient.PassportDepCode));
            _textBoxPassportNumber.DataBindings.Add("Text", _bsPatients, nameof(Patient.PassportNumber));
            _textBoxPassportSeries.DataBindings.Add("Text", _bsPatients, nameof(Patient.PassportSeries));
            _textBoxPassportUFMS.DataBindings.Add("Text", _bsPatients, nameof(Patient.PassportUFMS));
            _textBoxResidence.DataBindings.Add("Text", _bsPatients, nameof(Patient.Residence));
            _comboBoxSex.DataBindings.Add("Text", _bsPatients, nameof(Patient.Sex));
            _labelCardNumber.DataBindings.Add("Text", _bsPatients, nameof(Patient.CardNumber));
            _textBoxInputSearch.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.InputSearch), true , DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Установка привязок у датапикеров
        /// </summary>
        private void SetDatesBindings()
        {
            _dateTimePickerBirthdate.DataBindings.Add("Value", _bsPatients, nameof(Patient.Birthdate));
            _dateTimePickerPassportIssueDate.DataBindings.Add("Value", _bsPatients, nameof(Patient.PassportIssueDate));
            _dateTimePickerRegistrationDate.DataBindings.Add("Value", _bsPatients, nameof(Patient.RegistrationDate));
        }

        /// <summary>
        /// Очистка привязки у датапикеров
        /// </summary>
        private void ClearDatesBindings()
        {
            _dateTimePickerBirthdate.DataBindings.Clear();
            _dateTimePickerPassportIssueDate.DataBindings.Clear();
            _dateTimePickerRegistrationDate.DataBindings.Clear();
        }

        /// <summary>
        /// Отображение (с замещением) нужной UserControl
        /// </summary>
        private void ShowUcView()
        {
            var oldUc = _panelAdditions.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldUc == null)
            {
                this.Height += _userControl.Height;
            }
            else
            {
                this.Height -= oldUc.Height;
                this.Height += _userControl.Height;
                _panelAdditions.Controls.Remove(oldUc);
            }

            _panelAdditions.Controls.Add(_userControl);
        }
    }
}
