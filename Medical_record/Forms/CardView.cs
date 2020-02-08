using Medical_record.Data.Models;
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
    public partial class CardView : Form
    {
        private readonly CardViewModel _cardViewModel;
        private readonly BindingSource _bsPatients;

        public CardView(CardViewModel cardViewModel)
        {
            InitializeComponent();
            _cardViewModel = cardViewModel ??
                throw new ArgumentNullException(nameof(cardViewModel));

            _bsPatients = new BindingSource();
            _bsPatients.DataSource = typeof(List<Patient>);
            SetTextBindings();
            SetDatesBindings();

            _buttonAddPatient.Click += (s, e) => _cardViewModel.ShowRegistrationView();
            _buttonUpdatePatient.Click +=
                (s, e) => _cardViewModel.ShowRegistrationView(_bsPatients.Current as Patient);
            _buttonRemovePatient.Click += 
                (s, e) => _cardViewModel.RemovePatient(_bsPatients.Current as Patient);
            _buttonNextPatient.Click += (s, e) => _bsPatients.MoveNext();
            _buttonPrevPatient.Click += (s, e) => _bsPatients.MovePrevious();

            this.Activated += CardView_Activated;
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
        /// Активация формы приводит к перечитыванию данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CardView_Activated(object sender, EventArgs e)
        {
            await _cardViewModel.LoadDataAsync();
            if (_bsPatients.Count != 0)
            {
                ClearDatesBindings();
                _bsPatients.Clear();
                SetDatesBindings();
            }
            
            _cardViewModel.Patients.ForEach(p => _bsPatients.Add(p));
        }

        
    }
}
