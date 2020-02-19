namespace Medical_record.Abstractions
{
    /// <summary>
    /// Источник данных приложения
    /// </summary>
    public interface IDataContext
    {
        IDiagnosisDataContext Diagnoses { get; }
        IDoctorDataContext Doctors { get; }
        IExaminationDataContext Examinations { get; }
        IHealthGroupDataContext HealthGroups { get; }
        IHospitalizationDataContext Hospitalizations { get; }
        IMedicationsDataContext Medications { get; }
        IObservationDataContext Observations { get; }
        IPatientDataContext Patients { get; }
        IProcedureDataContext Procedures { get; }
        ISpecializationDataContext Specializations { get; }
    }
   
}
