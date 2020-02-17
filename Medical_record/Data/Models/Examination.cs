using System;

namespace Medical_record.Data.Models
{
    public class Examination
    {
        public int Id { get; set; }
        public DateTime ExaminationDate { get; set; } = DateTime.Now;
        public int PatientId { get; set; }
        public int DiagnosisId { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public string DiagnosisName => Diagnosis?.Name;
        public int HealthGroupId { get; set; }
        public HealthGroup HealthGroup { get; set; }
        public string HelthGroupTitle => HealthGroup?.Title;
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string DoctorFio => Doctor?.SpecAndFio;
    }
}
