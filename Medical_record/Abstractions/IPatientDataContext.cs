using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IPatientDataContext
    {
        Task<Result<List<Patient>>> GetPatientsAsync();
        Task<Result<string>> UpdatePatientAsync(Patient patient);
        Task<Result<string>> AddPatientAsync(Patient patient);
        Task<Result<string>> RemovePatientAsync(int patientId);
        Task<Result<int>> GetLastAddedPatientIdAsync();
        Task<Result<List<Patient>>> GetPatientsByLastNameAsync(string lastName);
        Task<Result<List<Patient>>> GetPatientsByCardNumberAsync(string cardNumber);
    }
}
