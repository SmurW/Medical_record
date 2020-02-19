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
    public class TestMedicationsDataContext : IMedicationsDataContext
    {
        private readonly DataSource _dataSource;

        public TestMedicationsDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddMedicationsAsync(Medications medications)
        {
            medications.Id = 1;
            if (_dataSource.Medications.Count > 0)
            {
                medications.Id = _dataSource.Medications.Max(d => d.Id) + 1;
            }
            _dataSource.Medications.Add(medications);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {medications.Name}", String.Empty));
        }

        public Task<Result<List<Medications>>> GetMedicationsAsync()
        {
            return Task.FromResult(new Result<List<Medications>>(_dataSource.Medications));
        }

        public Task<Result<List<Medications>>> GetMedicationsLikeAsync(string value)
        {
            return Task.FromResult(
                    new Result<List<Medications>>(
                        _dataSource.Medications.Where(d => d.Name.Contains(value)).ToList()));
        }

        public Task<Result<List<Medications>>> GetMedicationsOrderByAsync(string key)
        {
            if (key.Equals("Name"))
            {
                return Task.FromResult(
                    new Result<List<Medications>>(
                        _dataSource.Medications.OrderBy(d => d.Name).ToList()));
            }
            else
            {
                return Task.FromResult(
                    new Result<List<Medications>>(
                        _dataSource.Medications.OrderBy(d => d.Description).ToList()));
            }
        }

        public Task<Result<string>> RemoveMedicationsAsync(int id)
        {
            var dg = _dataSource.Medications.FirstOrDefault(d => d.Id == id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _dataSource.Medications.Remove(dg);
            return Task.FromResult(new Result<string>("Успешно удален", String.Empty));
        }

        public Task<Result<string>> UpdateMedicationsAsync(Medications medications)
        {
            var dg = _dataSource.Medications.FirstOrDefault(d => d.Id == medications.Id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            dg.Name = medications.Name;
            dg.Description = medications.Description;
            return Task.FromResult(new Result<string>("Успешно обновлен", String.Empty));
        }
    }
}
