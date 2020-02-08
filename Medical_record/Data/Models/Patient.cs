using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public string Residence { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportUFMS { get; set; }
        public DateTime PassportIssueDate { get; set; } = DateTime.Now;
        public string PassportDepCode { get; set; }
    }
}
