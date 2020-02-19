using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IProcedureDataContext
    {
        Task<Result<List<Procedure>>> GetProceduresAsync();
        Task<Result<string>> AddProcedureAsync(Procedure procedure);
        Task<Result<string>> UpdateProcedureAsync(Procedure procedure);
        Task<Result<string>> RemoveProcedureAsync(int id);
        Task<Result<List<Procedure>>> GetProceduresLikeAsync(string value);
        Task<Result<List<Procedure>>> GetProceduresOrderByAsync(string key);
    }
}
