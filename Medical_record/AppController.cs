using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Forms;
using Medical_record.UseControl;
using Medical_record.UseControl.ViewModels;
using Medical_record.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Medical_record
{
    public class AppController
    {
        private readonly MainForm_MedicalRecord _mainForm;
        private readonly Dictionary<string, UserControl> _uControls;
        public IDataContext DataContext { get; }

        public AppController(IDataContext dataContext)
        {
            DataContext = dataContext ??
                throw new ArgumentNullException(nameof(dataContext));

            var vm = new MainViewModel(this);
            _mainForm = new MainForm_MedicalRecord(vm);

            _uControls = new Dictionary<string, UserControl>();
            SetUserControls();
        }

        private void SetUserControls()
        {
            var vmO = new AddObservationViewModel(this);
            var ucO = new AddObservationView(vmO);
            _uControls.Add("Ob", ucO);

            var vmD = new AddDoctorsViewModel();
            var ucD = new AddDoctorsView(vmD);
            _uControls.Add("Dc", ucD);

            var vmH = new AddHospitalizationViewModel(this);
            var ucH = new AddHospitalizationView(vmH);
            _uControls.Add("Ho", ucH);
        }

        internal UserControl GetUcView(string key)
        {
            return _uControls[key];
        }

        internal Form GetMainForm()
        {
            return _mainForm;
        }

        internal void ShowCardView()
        {
            var vm = new CardViewModel(this);
            var form = new CardView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowDiagnosesView()
        {
            var vm = new DiagnosesViewModel(this);
            var form = new DiagnosesView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowMedicationsView()
        {
            var vm = new MedicationsViewModel(this);
            var form = new MedicationsView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowProceduresView()
        {
            var vm = new ProceduresViewModel(this);
            var form = new ProceduresView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowDoctorsView()
        {
            var vm = new DoctorsViewModel(this);
            var form = new DoctorsView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowRegistrationView()
        {
            var vm = new RegistrationViewModel(this);
            var form = new RegistrationView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowRegistrationView(Patient patient)
        {
            var vm = new RegistrationViewModel(this);
            vm.SetPatient(patient);
            var form = new RegistrationView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowDiagnosisView()
        {
            var vm = new DiagnosisViewModel(this);
            var form = new DiagnosisView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowDiagnosisView(Diagnosis diagnosis)
        {
            var vm = new DiagnosisViewModel(this);
            vm.SetDiagnosis(diagnosis);
            var form = new DiagnosisView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowAddMedicationsView()
        {
            var vm = new AddMedicationsViewModel(this);
            var form = new AddMedicationsView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowAddMedicationsView(Medications medications)
        {
            var vm = new AddMedicationsViewModel(this);
            vm.SetMedications(medications);
            var form = new AddMedicationsView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowAddProceduresView()
        {
            var vm = new AddProceduresViewModel(this);
            var form = new AddProceduresView(vm);
            form.Owner = _mainForm;
            form.Show();
        }

        internal void ShowAddProceduresView(Procedure procedure)
        {
            var vm = new AddProceduresViewModel(this);
            vm.SetPrcedure(procedure);
            var form = new AddProceduresView(vm);
            form.Owner = _mainForm;
            form.Show();
        }
    }
}
