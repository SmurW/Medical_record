using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IDoctorDataContext
    {
        Task<Result<List<Doctor>>> GetDoctorsAsync();
        Task<Result<string>> AddDoctorAsync(Doctor doctor);
        Task<Result<Doctor>> GetDoctorByIdAsync(int doctorId);
    }
}
