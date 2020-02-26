using Medical_record.Abstractions;
using Medical_record.Data.SQLServerData;

namespace Medical_record.Data
{
    public class SqlServerDataContext : IDataContext
    {
        private readonly ConnectionService _connectionService;
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

        public SqlServerDataContext()
        {
            _connectionService = new ConnectionService();

            Diagnoses = new SqlServerDiagnoses(_connectionService);
        }
    }
}
