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

        public async Task<Result<Diagnosis>> GetDiagnosisByIdAsync(int diagnosisId)
        {
            if (diagnosisId == 0)
            {
                return new Result<Diagnosis>("Неверный Id диагноза.");
            }

            var diagnosis = new Diagnosis();
            var nameProc = @"[dbo].[spDiagnoses_GetById]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = diagnosisId;

                    cmd.Parameters.Add(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            diagnosis.Id = reader.GetInt32(0);
                            diagnosis.Name = reader.GetString(1);
                            diagnosis.Description = reader.GetString(2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<Diagnosis>(ex.Message);
            }

            if (diagnosis.Id == 0)
            {
                return new Result<Diagnosis>("Не найден с таким Id");
            }
            else
            {
                return new Result<Diagnosis>(diagnosis);
            }
        }

        public async Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis)
        {
            if (diagnosis == null)
            {
                return new Result<string>("Пустое значение параметра");
            }

            var nameProc = @"[dbo].[spDiagnoses_Add]";
            object res = null;
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramName = new SqlParameter();
                    paramName.ParameterName = "@name";
                    paramName.SqlDbType = SqlDbType.NVarChar;
                    paramName.Value = diagnosis.Name.Trim();

                    var paramDesc = new SqlParameter();
                    paramDesc.ParameterName = "@desc";
                    paramDesc.SqlDbType = SqlDbType.NVarChar;
                    paramDesc.Value = diagnosis.Description.Trim();

                    cmd.Parameters.Add(paramName);
                    cmd.Parameters.Add(paramDesc);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    res = await cmd.ExecuteScalarAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно сохранен новый диагноз {res}.", string.Empty);
        }

        public async Task<Result<string>> RemoveDiagnosisAsync(int id)
        {
            if (id == 0)
            {
                return new Result<string>("Невозможно удалить диагноз с Id == 0");
            }

            var nameProc = @"[dbo].[spDiagnoses_Remove]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramId = new SqlParameter();
                    paramId.ParameterName = "@id";
                    paramId.SqlDbType = SqlDbType.Int;
                    paramId.Value = id;

                    cmd.Parameters.Add(paramId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно удален диагноз.", string.Empty);
        }

        public async Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            if (diagnosis == null)
            {
                return new Result<string>("Пустое значение параметра");
            }

            if (diagnosis.Id == 0)
            {
                return new Result<string>("Невозможно обновить диагноз с Id == 0");
            }

            var nameProc = @"[dbo].[spDiagnoses_Update]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramId = new SqlParameter();
                    paramId.ParameterName = "@id";
                    paramId.SqlDbType = SqlDbType.Int;
                    paramId.Value = diagnosis.Id;

                    var paramName = new SqlParameter();
                    paramName.ParameterName = "@name";
                    paramName.SqlDbType = SqlDbType.NVarChar;
                    paramName.Value = diagnosis.Name.Trim();

                    var paramDesc = new SqlParameter();
                    paramDesc.ParameterName = "@desc";
                    paramDesc.SqlDbType = SqlDbType.NVarChar;
                    paramDesc.Value = diagnosis.Description.Trim();

                    cmd.Parameters.Add(paramId);
                    cmd.Parameters.Add(paramName);
                    cmd.Parameters.Add(paramDesc);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно обновлен диагноз.", string.Empty);
        }
    }
}
