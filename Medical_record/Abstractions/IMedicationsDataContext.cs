using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IMedicationsDataContext
    {
        Task<Result<List<Medications>>> GetMedicationsAsync();
        Task<Result<string>> AddMedicationsAsync(Medications medications);
        Task<Result<string>> UpdateMedicationsAsync(Medications medications);
        Task<Result<string>> RemoveMedicationsAsync(int id);
        Task<Result<List<Medications>>> GetMedicationsOrderByAsync(string key);
        Task<Result<List<Medications>>> GetMedicationsLikeAsync(string value);
    }
}
