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
    public partial class RegistrationView : Form
    {
        private readonly RegistrationViewModel _viewModel;

        public RegistrationView(RegistrationViewModel registrationViewModel)
        {
            InitializeComponent();
            _viewModel = registrationViewModel ??
                throw new ArgumentNullException(nameof(registrationViewModel));

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

            _buttonSavePatient.Click += (s, e) => _viewModel.SavePatient();
        }
    }
}
