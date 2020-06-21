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
    class SqlServerUsers : IUserDataContext
    {
        private readonly ConnectionService _conService;

        public SqlServerUsers(ConnectionService connectionService)
        {
            _conService = connectionService
                ?? throw new ArgumentNullException(nameof(connectionService));
        }

        public async Task<Result<string>> AddUserAsync(Users users)
        {
            if (users == null)
            {
                return new Result<string>("Пустое значение параметра");
            }

            var nameProc = @"[dbo].[spUsers_Add]";
            object res = null;
            try
            {
                var parameters = GetSqlParametersfromUsers(users);

                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    cmd.Parameters.AddRange(parameters);
                    cmd.CommandType = CommandType.StoredProcedure;

                    await con.OpenAsync();
                    res = await cmd.ExecuteScalarAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно сохранен новый пользователь {res}.", string.Empty);
        }

        public async Task<Result<List<Users>>> GetUserAsync()
        {
            var user = new List<Users>();
            var nameProc = @"[dbo].[spUsers_GetAll]";
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
                                Users u = GetUsersfromReader(reader);
                                user.Add(u);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Users>>(ex.Message);
            }

            return new Result<List<Users>>(user);
        }

        public async Task<Result<string>> RemoveUserAsync(int Id)
        {
            if (Id == 0)
            {
                return new Result<string>("Невозможно удалить пользователя с Id == 0");
            }

            var nameProc = @"[dbo].[spUsers_Remove]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramId = new SqlParameter();
                    paramId.ParameterName = "@id";
                    paramId.SqlDbType = SqlDbType.Int;
                    paramId.Value = Id;

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

            return new Result<string>($"Успешно удален пользователь.", string.Empty);
        }

        public async Task<Result<string>> UpdateUserAsync(Users users)
        {
            if (users == null)
            {
                return new Result<string>("Пустое значение параметра");
            }

            if (users.Id == 0)
            {
                return new Result<string>("Невозможно обновить пациента с Id == 0");
            }

            var parameters = GetParametersfromUsers(users);
            var nameProc = @"[dbo].[spUsers_Update]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramId = new SqlParameter();
                    paramId.ParameterName = "@id";
                    paramId.SqlDbType = SqlDbType.Int;
                    paramId.Value = users.Id;

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

        private Users GetUsersfromReader(SqlDataReader reader)
        {
            var result = new Users
            {
                Id = reader.GetInt32(0),
                Login = reader.GetString(1),
                Password = reader.GetString(2)
            };

            return result;
        }

        private SqlParameter[] GetSqlParametersfromUsers(Users users)
        {
            var result = new List<SqlParameter>();

            var paraml = new SqlParameter();
            paraml.ParameterName = "@log";
            paraml.SqlDbType = SqlDbType.NVarChar;
            paraml.Value = users.Login.Trim();

            var paramp = new SqlParameter();
            paramp.ParameterName = "@pass";
            paramp.SqlDbType = SqlDbType.NVarChar;
            paramp.Value = users.Password.Trim();
            
            result.Add(paraml);
            result.Add(paramp);
            return result.ToArray();
        }

        private List<SqlParameter> GetParametersfromUsers(Users users)
        {
            var paramL = new SqlParameter
            {
                ParameterName = "@log",
                SqlDbType = SqlDbType.NVarChar,
                Value = users.Login.Trim()
            };

            var paramP = new SqlParameter
            {
                ParameterName = "@pass",
                SqlDbType = SqlDbType.NVarChar,
                Value = users.Password.Trim()
            };

            

            var result = new List<SqlParameter>
            { paramL, paramP };

            return result;
        }

        public async Task<Result<List<Users>>> GetUsersLikeAsync(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return await GetUserAsync();
            }

            var users = new List<Users>();
            var nameProc = @"[dbo].[spUsers_GetLike]";
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
                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var m = GetUsersfromReader(reader);
                                users.Add(m);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Users>>(ex.Message);
            }

            return new Result<List<Users>>(users);
        }
    }
}
