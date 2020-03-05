using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Data.Models;
using Medical_record.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlServerDataContext.Tests
{
    [TestClass]
    public class SqlServerSpecializationsTests
    {
        [TestMethod]
        [Description("Получение полного списка специализаций, удаленные исключены")]
        public async Task GetSpecializationsAsync_ReturnsListSpecializations()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Specialization>> result = await sut.Specializations.GetSpecializationsAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }
    }
}
