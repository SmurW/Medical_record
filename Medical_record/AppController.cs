using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Forms;
using Medical_record.ViewModels;
using System;
using System.Windows.Forms;

namespace Medical_record
{
    public class AppController
    {
        private MainForm_MedicalRecord _mainForm;
        public IDataContext DataContext { get; }

        public AppController(IDataContext dataContext)
        {
            DataContext = dataContext ??
                throw new ArgumentNullException(nameof(dataContext));
        }

        internal Form GetMainForm()
        {
            var vm = new MainViewModel(this);
            _mainForm = new MainForm_MedicalRecord(vm);
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
