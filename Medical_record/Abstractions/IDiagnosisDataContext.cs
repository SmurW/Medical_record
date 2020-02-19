using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IDiagnosisDataContext
    {
        Task<Result<List<Diagnosis>>> GetDiagnosesAsync();
        Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis);
        Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis);
        Task<Result<string>> RemoveDiagnosisAsync(int id);
        Task<Result<List<Diagnosis>>> GetDiagnosesOrderByAsync(string key);
        Task<Result<List<Diagnosis>>> GetDiagnosesLikeAsync(string value);
        Task<Result<Diagnosis>> GetDiagnosisByIdAsync(int diagnosisId);
    }
}
