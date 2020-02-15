using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data.Models
{
    public class Hospitalization
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime StartHospitalizationDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndHospitalizationDate { get; set; } = DateTime.Now;
        public string MedicalOrganization { get; set; }
        public string DefinitiveDiagnosis { get; set; }
    }
}
