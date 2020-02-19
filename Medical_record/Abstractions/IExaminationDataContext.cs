using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IExaminationDataContext
    {
        Task<Result<int>> GetCountExaminationsByPatientIdAsync(int id);
        Task<Result<string>> AddExaminationAsync(Examination examination);
        Task<Result<List<Examination>>> GetExaminationsByPatientIdAsync(int patientId);
    }
}
