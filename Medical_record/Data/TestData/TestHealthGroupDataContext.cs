using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
    public class TestHealthGroupDataContext : IHealthGroupDataContext
    {
        private readonly DataSource _dataSource;

        public TestHealthGroupDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<HealthGroup>> GetHealthGroupByIdAsync(int healthGroupId)
        {
            var hg = _dataSource.HealthGroups.FirstOrDefault(g => g.Id == healthGroupId);
            if (hg == null)
            {
                return Task.FromResult(new Result<HealthGroup>("Не найдена группа."));
            }

            return Task.FromResult(new Result<HealthGroup>(hg));
        }

        public Task<Result<List<HealthGroup>>> GetHealthGroupsAsync()
        {
            return Task.FromResult(new Result<List<HealthGroup>>(_dataSource.HealthGroups));
        }
    }
}
