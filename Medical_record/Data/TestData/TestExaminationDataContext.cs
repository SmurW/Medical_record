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
    public class TestExaminationDataContext : IExaminationDataContext
    {
        private readonly DataSource _dataSource;

        public TestExaminationDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddExaminationAsync(Examination examination)
        {
            examination.Id = 1;
            if (_dataSource.Examinations.Count > 0)
            {
                examination.Id = _dataSource.Examinations.Max(h => h.Id) + 1;
            }
            _dataSource.Examinations.Add(examination);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {examination.Id}", String.Empty));
        }

        public Task<Result<int>> GetCountExaminationsByPatientIdAsync(int id)
        {
            var count = _dataSource.Examinations.Where(e => e.PatientId == id).Count();
            return Task.FromResult(new Result<int>(count));
        }

        public Task<Result<List<Examination>>> GetExaminationsByPatientIdAsync(int patientId)
        {
            var exams = _dataSource.Examinations.Where(e => e.PatientId == patientId).ToList();
            return Task.FromResult(new Result<List<Examination>>(exams));
        }
    }
}
