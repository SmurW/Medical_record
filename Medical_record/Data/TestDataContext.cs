using Medical_record.Abstractions;
using Medical_record.Data.TestData;

namespace Medical_record.Data
{
    class TestDataContext : IDataContext
    {
        private readonly DataSource _dataSource = new DataSource();
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

        public TestDataContext()
        {
            Specializations = new TestSpecializationDataContext(_dataSource);
            Procedures = new TestProcedureDataContext(_dataSource);
            Patients = new TestPatientDataContext(_dataSource);
            Observations = new TestObservationDataContext(_dataSource);
            Medications = new TestMedicationsDataContext(_dataSource);
            Hospitalizations = new TestHospitalizationDataContext(_dataSource);
            HealthGroups = new TestHealthGroupDataContext(_dataSource);
            Examinations = new TestExaminationDataContext(_dataSource);
            Doctors = new TestDoctorDataContext(_dataSource);
            Diagnoses = new TestDiagnosesDataContext(_dataSource);
        }

    }
}
