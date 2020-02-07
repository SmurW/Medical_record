using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using Medical_record.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data
{
    class DbDataContext : IDataContext
    {
        public Task<Result<string>> AddPatientAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Diagnosis>>> GetAllDiagnosesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Patient>>> GetAllPatientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemovePatientAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdatePatientAsync(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
