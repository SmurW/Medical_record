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
    public class AppController : IAppController
    {
        private readonly Mainfrom_MedicalRecord _mainfrom;
        private readonly AutorizationView _autorizationView;
        public IDataContext DataContext { get; }
        public IMessageService MessageService { get; }

        public AppController(IDataContext dataContext, IMessageService messageService)
        {
            DataContext = dataContext ??
                throw new ArgumentNullException(nameof(dataContext));
            MessageService = messageService ??
                throw new ArgumentNullException(nameof(messageService));

            var vm = new MainViewModel(this);
            _mainfrom = new Mainfrom_MedicalRecord(vm);
        }

        public Form GetMainFrom()
        {
            return _mainfrom;
        }

        public Form GetAutorizationForm()
        {
            return _autorizationView;
        }

        public UserControl GetUcViewInput(string key)
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

        public UserControl GetUcViewOutput(string key)
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

        public void ShowAboutProgramView()
        {
            var vm = new AboutPrigrammViewModels(this);
            var from = new AboutProgramView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowCardView()
        {
            var vm = new CardViewModel(this);
            var from = new CardView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowDiagnosesView()
        {
            var vm = new DiagnosesViewModel(this);
            var from = new DiagnosesView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowMedicationsView()
        {
            var vm = new MedicationsViewModel(this);
            var from = new MedicationsView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowProceduresView()
        {
            var vm = new ProceduresViewModel(this);
            var from = new ProceduresView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowDoctorsView()
        {
            var vm = new DoctorsViewModel(this);
            var from = new DoctorsView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowRegistrationView()
        {
            var vm = new RegistrationViewModel(this);
            var from = new RegistrationView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowRegistrationView(Patient patient)
        {
            var vm = new RegistrationViewModel(this);
            vm.SetPatient(patient);
            var from = new RegistrationView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowDiagnosisView()
        {
            var vm = new DiagnosisViewModel(this);
            var from = new DiagnosisView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowDiagnosisView(Diagnosis diagnosis)
        {
            var vm = new DiagnosisViewModel(this);
            vm.SetDiagnosis(diagnosis);
            var from = new DiagnosisView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowAddMedicationsView()
        {
            var vm = new AddMedicationsViewModel(this);
            var from = new AddMedicationsView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowAddMedicationsView(Medications medications)
        {
            var vm = new AddMedicationsViewModel(this);
            vm.SetMedications(medications);
            var from = new AddMedicationsView(vm);
            from.Owner = _mainfrom;
            from.ShowDialog();
        }

        public void ShowAddProceduresView()
        {
            var vm = new AddProceduresViewModel(this);
            var from = new AddProceduresView(vm);
            from.Owner = _mainfrom;
            //if (from == null || from.IsDisposed)
                from.ShowDialog();
        }

        public void ShowAddProceduresView(Procedure procedure)
        {
            var vm = new AddProceduresViewModel(this);
            vm.SetPrcedure(procedure);
            var from = new AddProceduresView(vm);
            from.Owner = _mainfrom;
           // if (from == null || from.IsDisposed)
                from.ShowDialog();
        }

        public void ShowAutorizationView(Users users)
        {
            var vm = new AutorizationsViewModels(this);
            vm.SetUsers(users);
            var from = new AutorizationView(vm);
            from.Owner = _mainfrom;
           // if (from == null || from.IsDisposed)
                from.ShowDialog();
        }

        public void ShowAutorizationView()
        {
            var vm = new AutorizationsViewModels(this);
            var from = new AutorizationView(vm);
            from.Owner = _mainfrom;
            from.Show();

        }

            public void CloseAutorizationView()
        {
            _autorizationView.Hide();
        }

        public void ShowMainfrom()
        {
            var vm = new MainViewModel(this);
            var from = new Mainfrom_MedicalRecord(vm);
            //from.Owner = _mainfrom;
            //from.ShowDialog();
            if (from == null || from.IsDisposed)
            from.Show();
        }
    }
}
