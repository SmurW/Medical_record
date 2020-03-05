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
    class SqlServerSpecializations : ISpecializationDataContext
    {
        private readonly ConnectionService _conService;

        public SqlServerSpecializations(ConnectionService connectionService)
        {
            _conService = connectionService ??
                throw new ArgumentNullException(nameof(connectionService));
        }

        public async Task<Result<List<Specialization>>> GetSpecializationsAsync()
        {
            var specializations = new List<Specialization>();
            var nameProc = @"[dbo].[spSpecializations_GetAll]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var d = new Specialization
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                };
                                specializations.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Specialization>>(ex.Message);
            }

            return new Result<List<Specialization>>(specializations);
        }
    }
}
