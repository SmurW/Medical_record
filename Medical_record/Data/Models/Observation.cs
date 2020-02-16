using System;

namespace Medical_record.Data.Models
{
    public class Observation
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime StartObservationDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndObservationDate { get; set; } = DateTime.Now;
        public int DiagnosisId { get; set; }
        public int DoctorId { get; set; }
    }
}
