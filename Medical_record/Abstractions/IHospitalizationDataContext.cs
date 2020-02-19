using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IHospitalizationDataContext
    {
        Task<Result<int>> GetCountHospitalizationsByPatientIdAsync(int id);
        Task<Result<string>> AddHospitalizationAsync(Hospitalization hospitalization);
        Task<Result<List<Hospitalization>>> GetHospitalizationsByPatientIdAsync(int patientId);
    }
}
