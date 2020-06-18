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
        
        private static Patient GetPatientsfromReader(SqlDataReader reader)
        {
            return new Patient
            {
                Id = reader.GetInt32(0),
                CardNumber = reader.GetString(1),
                LastName = reader.GetString(2),
                FirstName = reader.GetString(3),
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
            if (patient == null)
            {
                return new Result<string>("Пустое значение параметра");
            }

            var parameters = GetParametersfromPatients(patient);
            var nameProc = @"[dbo].[spPatients_Add]";
            object res = null;
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    parameters.ForEach(p => cmd.Parameters.Add(p));
                    cmd.CommandType = CommandType.StoredProcedure;

                    await con.OpenAsync();
                    res = await cmd.ExecuteScalarAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно сохранен новый пациент {res}.", string.Empty);
        }

        public async Task<Result<int>> GetLastAddedPatientIdAsync()
        {
            var nameProc = @"[dbo].[spPatients_GetLastAddedPatientId]";
            int result = 0;
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await con.OpenAsync();
                    result = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                }
            }
            catch (Exception ex)
            {
                return new Result<int>(ex.Message);
            }

            return new Result<int>(result);
        }

        public async Task<Result<List<Patient>>> GetPatientsAsync()
        {
            var patients = new List<Patient>();
            var nameProc = @"[dbo].[spPatients_GetAll]";
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
                                var m = GetPatientsfromReader(reader);
                                patients.Add(m);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Patient>>(ex.Message);
            }

            return new Result<List<Patient>>(patients);
        }

        public async Task<Result<List<Patient>>> GetPatientsByCardNumberAsync(string cardNumber)
        {
             if (String.IsNullOrWhiteSpace(cardNumber))
            {
                return await GetPatientsAsync();
            }

            var patients = new List<Patient>();
            var nameProc = @"[dbo].[spPatients_GetByCardNumber]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@cardn";
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = cardNumber;

                    cmd.Parameters.Add(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var d = new Patient
                                {
                                    Id = reader.GetInt32(0),
                                    CardNumber = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    FirstName = reader.GetString(3),
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
                                patients.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Patient>>(ex.Message);
            }

            return new Result<List<Patient>>(patients);
        }

        public async Task<Result<List<Patient>>> GetPatientsByLastNameAsync(string lastName)
        {
            if (String.IsNullOrWhiteSpace(lastName))
            {
                return await GetPatientsAsync();
            }

            var patients = new List<Patient>();
            var nameProc = @"[dbo].[spPatients_GetByLastName]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@lname";
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = lastName;

                    cmd.Parameters.Add(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var d = new Patient
                                {
                                    Id = reader.GetInt32(0),
                                    CardNumber = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    FirstName = reader.GetString(3),
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
                                patients.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Patient>>(ex.Message);
            }

            return new Result<List<Patient>>(patients);
        }

        public async Task<Result<string>> RemovePatientAsync(int patientId)
        {
            if (patientId == 0)
            {
                return new Result<string>("Невозможно удалить пациента с Id == 0");
            }

            var nameProc = @"[dbo].[spPatients_Remove]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramId = new SqlParameter();
                    paramId.ParameterName = "@id";
                    paramId.SqlDbType = SqlDbType.Int;
                    paramId.Value = patientId;

                    cmd.Parameters.Add(paramId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    await con.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно удален пациент.", string.Empty);
        }

        public async Task<Result<string>> UpdatePatientAsync(Patient patient)
        {
            if (patient == null)
            {
                return new Result<string>("Пустое значение параметра");
            }

            if (patient.Id == 0)
            {
                return new Result<string>("Невозможно обновить пациента с Id == 0");
            }

            var parameters = GetParametersfromPatients(patient);
            var nameProc = @"[dbo].[spPatients_Update]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramId = new SqlParameter();
                    paramId.ParameterName = "@id";
                    paramId.SqlDbType = SqlDbType.Int;
                    paramId.Value = patient.Id;

                    cmd.Parameters.Add(paramId);
                    parameters.ForEach(p => cmd.Parameters.Add(p));
                    cmd.CommandType = CommandType.StoredProcedure;

                    await con.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно обновлено пациента.", string.Empty);
        }

        private List<SqlParameter> GetParametersfromPatients(Patient patient)
        {
            var paramCN = new SqlParameter
            {
                ParameterName = "@cardn",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.CardNumber.Trim()
            };

            var paramFN = new SqlParameter
            {
                ParameterName = "@fname",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.FirstName.Trim()
            };

            var paramLN = new SqlParameter
            {
                ParameterName = "@lname",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.LastName.Trim()
            };

            var paramMN = new SqlParameter
            {
                ParameterName = "@mname",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.MiddleName.Trim()
            };

            var paramSX = new SqlParameter
            {
                ParameterName = "@sex",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.Sex.Trim()
            };

            var paramBE = new SqlParameter
            {
                ParameterName = "@bdate",
                SqlDbType = SqlDbType.DateTime,
                Value = patient.Birthdate
            };

            var paramRE = new SqlParameter
            {
                ParameterName = "@regdate",
                SqlDbType = SqlDbType.DateTime,
                Value = patient.RegistrationDate
            };

            var paramRC = new SqlParameter
            {
                ParameterName = "@residn",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.Residence
            };

            var paramPN = new SqlParameter
            {
                ParameterName = "@pasnum",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.PassportNumber
            };

            var paramPS = new SqlParameter
            {
                ParameterName = "@passer",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.PassportSeries
            };

            var paramPUFMS = new SqlParameter
            {
                ParameterName = "@pasufms",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.PassportUFMS
            };

            var paramPID = new SqlParameter
            {
                ParameterName = "@pasissue",
                SqlDbType = SqlDbType.DateTime,
                Value = patient.PassportIssueDate
            };

            var paramDC = new SqlParameter
            {
                ParameterName = "@pasdepcod",
                SqlDbType = SqlDbType.NVarChar,
                Value = patient.PassportDepCode
            };

            var result = new List<SqlParameter>
            { paramFN, paramLN, paramMN, paramCN, paramSX, paramBE, paramRE, paramRC,
                paramPN, paramPS, paramPUFMS, paramPID, paramDC};

            return result;
        }


    }
}
