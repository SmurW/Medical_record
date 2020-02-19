using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
    public class TestObservationDataContext : IObservationDataContext
    {
        private readonly DataSource _dataSource;

        public TestObservationDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddObservationAsync(Observation observation)
        {
            observation.Id = 1;
            if (_dataSource.Observations.Count > 0)
            {
                observation.Id = _dataSource.Observations.Max(o => o.Id) + 1;
            }
            _dataSource.Observations.Add(observation);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранено {observation.Id}", String.Empty));
        }

        public Task<Result<int>> GetCountObservationsByPatientIdAsync(int id)
        {
            var count = _dataSource.Observations.Where(o => o.PatientId == id).Count();
            return Task.FromResult(new Result<int>(count));
        }

        public Task<Result<List<Observation>>> GetObservationsByPatientIdAsync(int patientId)
        {
            var obs = _dataSource.Observations.Where(o => o.PatientId == patientId).ToList();
            return Task.FromResult(new Result<List<Observation>>(obs));
        }
    }
}
