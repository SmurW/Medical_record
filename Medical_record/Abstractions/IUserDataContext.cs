using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IUserDataContext
    {
        Task<Result<List<Users>>> GetUserAsync();
        Task<Result<string>> UpdateUserAsync(Users users);
        Task<Result<string>> AddUserAsync(Users users);
        Task<Result<string>> RemoveUserAsync(int Id);
    }
}
