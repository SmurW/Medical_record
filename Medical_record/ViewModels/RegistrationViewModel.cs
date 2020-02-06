using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class RegistrationViewModel
    {
        private readonly AppController _appController;

        public RegistrationViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Residence { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportUFMS { get; set; }
        public DateTime PassportIssueDate { get; set; }
        public string PassportDepCode { get; set; }

        internal async void SavePatient()
        {
            
        }
    }
}
