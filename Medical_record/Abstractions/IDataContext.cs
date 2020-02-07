using Medical_record.Data.Models;
using Medical_record.Utils;
using Medical_record.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Abstractions
{
    public interface IDataContext
    {
        Task<Result<List<Patient>>> GetAllPatientsAsync();
        Task<Result<string>> UpdatePatientAsync(Patient patient);
        Task<Result<string>> AddPatientAsync(Patient patient);
        Task<Result<string>> RemovePatientAsync(int id);
    }
}
