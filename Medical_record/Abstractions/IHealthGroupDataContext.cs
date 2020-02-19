using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IHealthGroupDataContext
    {
        Task<Result<List<HealthGroup>>> GetHealthGroupsAsync();
        Task<Result<HealthGroup>> GetHealthGroupByIdAsync(int healthGroupId);
    }
}
