using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
    public class TestSpecializationDataContext : ISpecializationDataContext
    {
        private readonly DataSource _dataSource;

        public TestSpecializationDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<List<Specialization>>> GetSpecializationsAsync()
        {
            return Task.FromResult(new Result<List<Specialization>>(_dataSource.Specializations));
        }
    }
}
