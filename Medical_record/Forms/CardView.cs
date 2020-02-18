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
        private int _currentPatientNumber;

        public CardView(CardViewModel cardViewModel)
        {
            InitializeComponent();
            _viewModel = cardViewModel ??
                throw new ArgumentNullException(nameof(cardViewModel));

            //источник данных Пациенты
            _bsPatients = new BindingSource();
            _bsPatients.DataSource = _viewModel.Patients;
            //установка привязок
            SetBindings();

            //когда данные загружаются отключаем привязки у дэйтпикеров
            _viewModel.DataLoading += (s, e) => ClearDatesBindings();
            //когда данные загружены включаем привязки у дэйтпикеров
            _viewModel.DataLoaded += (s, e) => SetDatesBindings();

            //кнопки справа вверху
            _buttonAddPatient.Click += (s, e) => _viewModel.ShowRegistrationView();
            _buttonUpdatePatient.Click +=
                (s, e) => _viewModel.ShowRegistrationView(_bsPatients.Current as Patient);
            _buttonRemovePatient.Click += 
                (s, e) => _viewModel.RemovePatient(_bsPatients.Current as Patient);
            _buttonNextPatient.Click += ButtonNextPatient_Click;
            _buttonPrevPatient.Click += ButtonPrevPatient_Click;

            //радиокнопки выбора просмотра доп. записей
            _radioButtonNo.Click += RadioButtonAdditions_Click;
            _radioButtonHospitalizations.Click += RadioButtonAdditions_Click;
            _radioButtonExaminations.Click += RadioButtonAdditions_Click;
            _radioButtonObservations.Click += RadioButtonAdditions_Click;

            //кнопки перехода по доп.записям
            _buttonNextAddition.Click += (s, e) => _viewModel.NextAddition();
            _buttonPrevAddition.Click += (s, e) => _viewModel.PrevAddition();

            //форма активирована -> подгружаем данные о пациентах
            this.Activated += async (s, e) => await _viewModel.LoadDataAsync();
        }

        /// <summary>
        /// Переход к след. пациенту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrevPatient_Click(object sender, EventArgs e)
        {
            //настройка отображения доп.записей
            _radioButtonNo.Checked = true;
            RadioButtonAdditions_Click(_radioButtonNo, EventArgs.Empty);
            //переходим к предыд. пациенту
            _bsPatients.MovePrevious();
            //передаем Id пациента в вьюмодель
            var patient = _bsPatients.Current as Patient;
            if (patient != null)
            {
                _viewModel.SetCurrentPatientId(patient.Id);
            }
            //счетчик отображаемого пациента
            if (--_currentPatientNumber >= 1)
            {
                _labelPatientCurrentNumber.Text = _currentPatientNumber.ToString();
            }
            else
            {
                _currentPatientNumber = 1;
            }
        }

        /// <summary>
        /// Переход к предыдущ. пациенту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNextPatient_Click(object sender, EventArgs e)
        {
            //настройка отображения доп.записей
            _radioButtonNo.Checked = true;
            RadioButtonAdditions_Click(_radioButtonNo, EventArgs.Empty);
            //переходим к след. пациенту
            _bsPatients.MoveNext();
            //передаем Id пациента в вьюмодель
            var patient = _bsPatients.Current as Patient;
            if (patient != null)
            {
                _viewModel.SetCurrentPatientId(patient.Id);
            }
            //счетчик отображаемого пациента
            if (++_currentPatientNumber <= _bsPatients.Count)
            {
                _labelPatientCurrentNumber.Text = _currentPatientNumber.ToString();
            }
            else
            {
                _currentPatientNumber = _bsPatients.Count;
            }
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
        /// Установка привязок у текстбоксов и комбобокса и лейблов, радиокнопки
        /// </summary>
        private void SetBindings()
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

            _radioButtonLastName.DataBindings.Add("Checked",
                _viewModel, nameof(_viewModel.LastNameChecked), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Установка привязок у дэйтпикеров,
        /// и количества пациентов
        /// </summary>
        private void SetDatesBindings()
        {
            _dateTimePickerBirthdate.DataBindings.Add("Value",
                _bsPatients, nameof(Patient.Birthdate));
            _dateTimePickerPassportIssueDate.DataBindings.Add("Value",
                _bsPatients, nameof(Patient.PassportIssueDate));
            _dateTimePickerRegistrationDate.DataBindings.Add("Value",
                _bsPatients, nameof(Patient.RegistrationDate));

            //кол-во пациентов
            _textBoxPatientsCount.Text = _bsPatients.Count.ToString();
            _labelPatientsCount.Text = _textBoxPatientsCount.Text;
            _currentPatientNumber = 1;
            _labelPatientCurrentNumber.Text = _currentPatientNumber.ToString();
        }

        /// <summary>
        /// Очистка привязки у дэйтпикеров
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
