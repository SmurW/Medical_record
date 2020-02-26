using Medical_record.Abstractions;

namespace Medical_record.Data
{
    public class SqlServerDataContext : IDataContext
    {
        public IDiagnosisDataContext Diagnoses { get; }
        public IDoctorDataContext Doctors { get; }
        public IExaminationDataContext Examinations { get; }
        public IHealthGroupDataContext HealthGroups { get; }
        public IHospitalizationDataContext Hospitalizations { get; }
        public IMedicationsDataContext Medications { get; }
        public IObservationDataContext Observations { get; }
        public IPatientDataContext Patients { get; }
        public IProcedureDataContext Procedures { get; }
        public ISpecializationDataContext Specializations { get; }
    }
}
