using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    /// <summary>
    /// Источник данных приложения
    /// </summary>
    public interface IDataContext
    {
        Task<Result<List<Patient>>> GetPatientsAsync();
        Task<Result<string>> UpdatePatientAsync(Patient patient);
        Task<Result<string>> AddPatientAsync(Patient patient);
        Task<Result<string>> RemovePatientAsync(int id);
        Task<Result<List<Diagnosis>>> GetDiagnosesAsync();
        Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis);
        Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis);
        Task<Result<string>> RemoveDiagnosisAsync(int id);
        Task<Result<List<Diagnosis>>> GetDiagnosesOrderByAsync(string key);
        Task<Result<List<Diagnosis>>> GetDiagnosesLikeAsync(string value);
        Task<Result<List<Procedure>>> GetProceduresAsync();
        Task<Result<string>> AddProcedureAsync(Procedure proc);
        Task<Result<string>> UpdateProcedureAsync(Procedure proc);
        Task<Result<string>> RemoveProcedureAsync(int id);
        Task<Result<List<Procedure>>> GetProceduresLikeAsync(string value);
        Task<Result<List<Procedure>>> GetProceduresOrderByAsync(string key);
        Task<Result<List<Medications>>> GetMedicationsAsync();
        Task<Result<string>> AddMedicationsAsync(Medications medications);
        Task<Result<string>> UpdateMedicationsAsync(Medications medications);
        Task<Result<string>> RemoveMedicationsAsync(int id);
        Task<Result<List<Medications>>> GetMedicationsOrderByAsync(string key);
        Task<Result<List<Medications>>> GetMedicationsLikeAsync(string value);
        Task<Result<List<Doctor>>> GetDoctorsAsync();
        Task<Result<string>> AddDoctorAsync(Doctor doctor);
        Task<Result<int>> GetLastAddedPatientIdAsync();
        Task<Result<string>> AddObservationAsync(Observation ob);
        Task<Result<int>> GetCountObservationsByPatientIdAsync(int id);
        Task<Result<int>> GetCountHospitalizationsByPatientIdAsync(int id);
        Task<Result<string>> AddHospitalizationAsync(Hospitalization hosp);
        Task<Result<List<Specialization>>> GetSpecializationsAsync();
        Task<Result<List<HealthGroup>>> GetHealthGroupsAsync();
        Task<Result<int>> GetCountExaminationsByPatientIdAsync(int id);
        Task<Result<List<Patient>>> GetPatientsByLastNameAsync(string v);
        Task<Result<string>> AddExaminationAsync(Examination exam);
        Task<Result<List<Observation>>> GetObservationsByPatientIdAsync(int currentPatientId);
        Task<Result<List<Patient>>> GetPatientsByCardNumberAsync(string v);
        Task<Result<Diagnosis>> GetDiagnosisByIdAsync(int diagnosisId);
        Task<Result<Doctor>> GetDoctorByIdAsync(int doctorId);
        Task<Result<List<Examination>>> GetExaminationsByPatientIdAsync(int currentPatientId);
        Task<Result<HealthGroup>> GetHealthGroupByIdAsync(int healthGroupId);
        Task<Result<List<Hospitalization>>> GetHospitalizationsByPatientIdAsync(int currentPatientId);
    }
   
}
