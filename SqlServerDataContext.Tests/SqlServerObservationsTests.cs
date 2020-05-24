﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Data.Models;
using Medical_record.Utils;

namespace SqlServerDataContext.Tests
{
    [TestClass]
    public class SqlServerObservationsTests
    {
        [TestMethod]
        [Description("Получение полного списка наблюдений по Id пациента")]
        public async Task GetObservationsByPatientIdAsync_ReturnsObservations()
        {
            IDataContext sut = new MsSqlDataContext();

            Result<List<Doctor>> result = await sut.Doctors.GetDoctorsAsync();

            Assert.IsTrue(result.HasValue);
            Assert.IsTrue(result.Value.Count > 0);
        }
    }
}
