using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Medical_record.Data.MsSqlData
{
    public class SqlServerDiagnoses : IDiagnosisDataContext
    {
        private readonly ConnectionService _conService;

        public SqlServerDiagnoses(ConnectionService connectionService)
        {
            _conService = connectionService;
        }

        public async Task<Result<List<Diagnosis>>> GetDiagnosesAsync()
        {
            var diagnoses = new List<Diagnosis>();
            var nameProc = @"[dbo].[spDiagnoses_GetAll]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var d = new Diagnosis
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2),
                                };
                                diagnoses.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Diagnosis>>(ex.Message);
            }

            return new Result<List<Diagnosis>>(diagnoses);
        }

        public async Task<Result<List<Diagnosis>>> GetDiagnosesLikeAsync(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return await GetDiagnosesAsync();
            }

            var diagnoses = new List<Diagnosis>();
            var nameProc = @"[dbo].[spDiagnoses_GetLike]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@value";
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = value;

                    cmd.Parameters.Add(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var d = new Diagnosis
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2),
                                };
                                diagnoses.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Diagnosis>>(ex.Message);
            }

            return new Result<List<Diagnosis>>(diagnoses);
        }

        public async Task<Result<List<Diagnosis>>> GetDiagnosesOrderByAsync(string key)
        {
            if (String.IsNullOrWhiteSpace(key))
            {
                return await GetDiagnosesAsync();
            }

            var diagnoses = new List<Diagnosis>();
            var nameProc = @"[dbo].[spDiagnoses_GetAllWithOrder]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@key";
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Value = key;

                    cmd.Parameters.Add(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var d = new Diagnosis
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2),
                                };
                                diagnoses.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Diagnosis>>(ex.Message);
            }

            return new Result<List<Diagnosis>>(diagnoses);
        }

        public Task<Result<Diagnosis>> GetDiagnosisByIdAsync(int diagnosisId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemoveDiagnosisAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }
    }
}
