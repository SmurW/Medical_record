using System;

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
