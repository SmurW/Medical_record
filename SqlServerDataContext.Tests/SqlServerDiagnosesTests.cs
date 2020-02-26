using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medical_record.Data;
using Medical_record.Abstractions;
using Medical_record.Utils;
using System.Collections.Generic;
using Medical_record.Data.Models;

namespace SqlServerDataContext.Tests
{
    [TestClass]
    public class SqlServerDiagnosesTests
    {
        [TestMethod]
        public async Task GetDiagnosesAsync_When_Then()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Diagnosis>> result = await sut.Diagnoses.GetDiagnosesAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }
    }
}
