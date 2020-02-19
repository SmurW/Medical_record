using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
    public class TestDiagnosesDataContext : IDiagnosisDataContext
    {
        private readonly DataSource _dataSource;

        public TestDiagnosesDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis)
        {
            diagnosis.Id = 1;
            if (_dataSource.Diagnoses.Count > 0)
            {
                diagnosis.Id = _dataSource.Diagnoses.Max(d => d.Id) + 1;
            }
            _dataSource.Diagnoses.Add(diagnosis);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {diagnosis.Name}", String.Empty));
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesAsync()
        {
            return Task.FromResult(new Result<List<Diagnosis>>(_dataSource.Diagnoses));
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesLikeAsync(string value)
        {
            return Task.FromResult(
                    new Result<List<Diagnosis>>(
                        _dataSource.Diagnoses.Where(d => d.Name.Contains(value)).ToList()));
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesOrderByAsync(string key)
        {
            if (key.Equals("Name"))
            {
                return Task.FromResult(
                    new Result<List<Diagnosis>>(
                        _dataSource.Diagnoses.OrderBy(d => d.Name).ToList()));
            }
            else
            {
                return Task.FromResult(
                    new Result<List<Diagnosis>>(
                        _dataSource.Diagnoses.OrderBy(d => d.Description).ToList()));
            }
        }

        public Task<Result<Diagnosis>> GetDiagnosisByIdAsync(int diagnosisId)
        {
            var diag = _dataSource.Diagnoses.FirstOrDefault(d => d.Id == diagnosisId);
            if (diag == null)
            {
                return Task.FromResult(new Result<Diagnosis>("Диагноз не найден."));
            }

            return Task.FromResult(new Result<Diagnosis>(diag));
        }

        public Task<Result<string>> RemoveDiagnosisAsync(int id)
        {
            var dg = _dataSource.Diagnoses.FirstOrDefault(d => d.Id == id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _dataSource.Diagnoses.Remove(dg);
            return Task.FromResult(new Result<string>("Успешно удален", String.Empty));
        }

        public Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            var dg = _dataSource.Diagnoses.FirstOrDefault(d => d.Id == diagnosis.Id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            dg.Name = diagnosis.Name;
            dg.Description = diagnosis.Description;
            return Task.FromResult(new Result<string>("Успешно обновлен", String.Empty));
        }
    }
}
