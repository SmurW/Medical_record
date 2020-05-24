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
    public class SqlServerObservations : IObservationDataContext
    {
        private ConnectionService _connectionService;

        public SqlServerObservations(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public Task<Result<string>> AddObservationAsync(Observation observation)
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> GetCountObservationsByPatientIdAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Observation>>> GetObservationsByPatientIdAsync(int patientId)
        {
            throw new NotImplementedException();
        }
    }
}
