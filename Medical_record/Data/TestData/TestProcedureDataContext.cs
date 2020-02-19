using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
    public class TestProcedureDataContext : IProcedureDataContext
    {
        private readonly DataSource _dataSource;

        public TestProcedureDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddProcedureAsync(Procedure procedure)
        {
            procedure.Id = 1;
            if (_dataSource.Procedures.Count > 0)
            {
                procedure.Id = _dataSource.Procedures.Max(p => p.Id) + 1;
            }
            _dataSource.Procedures.Add(procedure);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранена {procedure.Name}", String.Empty));
        }

        public Task<Result<List<Procedure>>> GetProceduresAsync()
        {
            return Task.FromResult(new Result<List<Procedure>>(_dataSource.Procedures));
        }

        public Task<Result<List<Procedure>>> GetProceduresLikeAsync(string value)
        {
            return Task.FromResult(
                    new Result<List<Procedure>>(
                        _dataSource.Procedures.Where(d => d.Name.Contains(value)).ToList()));
        }

        public Task<Result<List<Procedure>>> GetProceduresOrderByAsync(string key)
        {
            if (key.Equals("Name"))
            {
                return Task.FromResult(
                    new Result<List<Procedure>>(
                        _dataSource.Procedures.OrderBy(d => d.Name).ToList()));
            }
            else
            {
                return Task.FromResult(
                    new Result<List<Procedure>>(
                        _dataSource.Procedures.OrderBy(d => d.Description).ToList()));
            }
        }

        public Task<Result<string>> RemoveProcedureAsync(int id)
        {
            var pr = _dataSource.Procedures.FirstOrDefault(d => d.Id == id);
            if (pr == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _dataSource.Procedures.Remove(pr);
            return Task.FromResult(new Result<string>("Успешно удалена", String.Empty));
        }

        public Task<Result<string>> UpdateProcedureAsync(Procedure procedure)
        {
            var pr = _dataSource.Procedures.FirstOrDefault(p => p.Id == procedure.Id);
            if (pr == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            pr.Name = procedure.Name;
            pr.Description = procedure.Description;
            return Task.FromResult(new Result<string>("Успешно обновлена", String.Empty));
        }
    }
}
