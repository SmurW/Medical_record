using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data.MsSqlData
{
    public class SqlServerExaminations : IExaminationDataContext
    {
        private ConnectionService _conService;

        public SqlServerExaminations(ConnectionService connectionService)
        {
            _conService = connectionService ??
                throw new ArgumentNullException(nameof(connectionService));
        }

        public Task<Result<string>> AddExaminationAsync(Examination examination)
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> GetCountExaminationsByPatientIdAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Examination>>> GetExaminationsByPatientIdAsync(int patientId)
        {
            throw new NotImplementedException();
        }
    }
}
