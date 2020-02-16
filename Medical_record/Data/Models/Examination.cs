using System;

namespace Medical_record.Data.Models
{
    public class Examination
    {
        public int Id { get; set; }
        public DateTime ExaminationDate { get; set; } = DateTime.Now;
        public int PatientId { get; set; }
        public int DiagnosisId { get; set; }
        public int HealthGroupId { get; set; }
        public int DoctorId { get; set; }
    }
}
