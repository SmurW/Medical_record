using Medical_record.Abstractions;
using Medical_record.Data.MsSqlData;

namespace Medical_record.Data
{
    public class MsSqlDataContext : IDataContext
    {
        private readonly ConnectionService _connectionService;
        public IDiagnosisDataContext Diagnoses { get; } //+
        public IDoctorDataContext Doctors { get; } //+
        public IExaminationDataContext Examinations { get; } //-
        public IHealthGroupDataContext HealthGroups { get; } //+
        public IHospitalizationDataContext Hospitalizations { get; } //+
        public IMedicationsDataContext Medications { get; } //+
        public IObservationDataContext Observations { get; } //-
        public IPatientDataContext Patients { get; } //+
        public IProcedureDataContext Procedures { get; } //+
        public ISpecializationDataContext Specializations { get; } //+

        public MsSqlDataContext()
        {
            _connectionService = new ConnectionService();

            Diagnoses = new SqlServerDiagnoses(_connectionService);
            Procedures = new SqlServerProcedures(_connectionService);
            Medications = new SqlServerMedications(_connectionService);
            Specializations = new SqlServerSpecializations(_connectionService);
            HealthGroups = new SqlServerHealthGroups(_connectionService);
            Doctors = new SqlServerDoctors(_connectionService);
            Hospitalizations = new SqlServerHospitalization(_connectionService);
            Patients = new SqlServerPatients(_connectionService);
        }
    }
}
