using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Medical_record.Data.MsSqlData
{
    public class SqlServerDiagnoses : IDiagnosisDataContext
    {
        private readonly ConnectionService _conService;

        public SqlServerDiagnoses(ConnectionService connectionService)
        {
            _conService = connectionService;
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesLikeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesOrderByAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Diagnosis>> GetDiagnosisByIdAsync(int diagnosisId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemoveDiagnosisAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }
    }
}
