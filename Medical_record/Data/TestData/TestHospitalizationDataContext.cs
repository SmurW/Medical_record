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
    public class TestHospitalizationDataContext : IHospitalizationDataContext
    {
        private readonly DataSource _dataSource;

        public TestHospitalizationDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddHospitalizationAsync(Hospitalization hospitalization)
        {
            hospitalization.Id = 1;
            if (_dataSource.Hospitalizations.Count > 0)
            {
                hospitalization.Id = _dataSource.Hospitalizations.Max(h => h.Id) + 1;
            }
            _dataSource.Hospitalizations.Add(hospitalization);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранена {hospitalization.Id}", String.Empty));
        }

        public Task<Result<int>> GetCountHospitalizationsByPatientIdAsync(int patientId)
        {
            var count = _dataSource.Hospitalizations.Where(o => o.PatientId == patientId).Count();
            return Task.FromResult(new Result<int>(count));
        }

        public Task<Result<List<Hospitalization>>> GetHospitalizationsByPatientIdAsync(int patientId)
        {
            var hosps = _dataSource.Hospitalizations.Where(h => h.PatientId == patientId).ToList();
            return Task.FromResult(new Result<List<Hospitalization>>(hosps));
        }
    }
}
