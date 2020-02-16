using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Forms;
using Medical_record.UseControl;
using Medical_record.UseControl.ViewModels;
using Medical_record.ViewModels;
using System;
using System.Windows.Forms;

namespace Medical_record
{
    public class AppController
    {
        private readonly MainForm_MedicalRecord _mainForm;
        public IDataContext DataContext { get; }

        public AppController(IDataContext dataContext)
        {
            DataContext = dataContext ??
                throw new ArgumentNullException(nameof(dataContext));

            var vm = new MainViewModel(this);
            _mainForm = new MainForm_MedicalRecord(vm);
        }

        internal Form GetMainForm()
        {
            return _mainForm;
        }

        internal UserControl GetUcViewInput(string key)
        {
            switch (key)
            {
                case "Ob":
                    var vmO = new AddObservationViewModel();
                    var ucO = new AddObservationView(vmO);
                    return ucO;
                case "Ex":
                    var vmE = new AddExaminationViewModel();
                    var ucE = new AddExaminationView(vmE);
                    return ucE;
                case "Ho":
                    var vmH = new AddHospitalizationViewModel();
                    var ucH = new AddHospitalizationView(vmH);
                    return ucH;
                default:
                    throw new ArgumentException(nameof(key));
            }
        }

        internal UserControl GetUcViewOutput(string key)
        {
            switch (key)
            {
                case "Ob":
                    var vmO = new ObservationViewModel();
                    var ucO = new ObservationView(vmO);
                    return ucO;
                case "Ex":
                    var vmE = new ExaminationViewModel();
                    var ucE = new ExaminationView(vmE);
                    return ucE;
                case "Ho":
                    var vmH = new HospitalizationViewModel();
                    var ucH = new HospitalizationView(vmH);
                    return ucH;
                default:
                    throw new ArgumentException(nameof(key));
            }
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
