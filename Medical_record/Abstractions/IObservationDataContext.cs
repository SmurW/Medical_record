using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IObservationDataContext
    {
        Task<Result<string>> AddObservationAsync(Observation ob);
        Task<Result<int>> GetCountObservationsByPatientIdAsync(int id);
        Task<Result<List<Observation>>> GetObservationsByPatientIdAsync(int patientId);
    }
}
