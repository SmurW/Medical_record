using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Medical_record.Data.MsSqlData
{
    class SqlServerPatients : IPatientDataContext
    {
        private readonly ConnectionService _conService;

        public SqlServerPatients(ConnectionService connectionService)
        {
            _conService = connectionService ??
                throw new ArgumentNullException(nameof(connectionService));
        }
        
        private static Patient GetPatientsFromReader(SqlDataReader reader)
        {
            return new Patient
            {
                Id = reader.GetInt32(0),
                CardNumber = reader.GetString(1),
                FirstName = reader.GetString(2),
                LastName = reader.GetString(3),
                MiddleName = reader.GetString(4),
                Sex = reader.GetString(5),
                Residence = reader.GetString(6),
                PassportNumber = reader.GetString(7),
                PassportSeries = reader.GetString(8),
                PassportUFMS = reader.GetString(9),
                PassportDepCode = reader.GetString(10),
                PassportIssueDate = reader.GetDateTime(11),
                Birthdate = reader.GetDateTime(12),
                RegistrationDate = reader.GetDateTime(13)
            };
        }

        public async Task<Result<string>> AddPatientAsync(Patient patient)
        {
            //var patients = new List<Patient>();
            //var nameProc = "@[dbo].[spPatients_GetAll]";
            //try
            //{
            //    using (var con = _conService.GetConnection())
            //    using (var cmd = new SqlCommand(nameProc, con))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        await con.OpenAsync();
            //        using (var raider = await cmd.ExecuteReaderAsync())
            //        {
            //            if (raider.HasRows)
            //            {
            //                while (await raider.ReadAsync())
            //                {
            //                    var p = GetPatientsFromReader(raider);
            //                    patients.Add(p);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return new Result<List<Patient>>(ex.Message);
            //}
            //return new Result<List<Patient>>(patients);
            throw new NotImplementedException();
        }

            public Task<Result<int>> GetLastAddedPatientIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Patient>>> GetPatientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Patient>>> GetPatientsByCardNumberAsync(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Patient>>> GetPatientsByLastNameAsync(string lastName)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemovePatientAsync(int patientId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdatePatientAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        
    }
}
