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
    class SqlServerHospitalization : IHospitalizationDataContext
    {
        private readonly ConnectionService _conService;

        public SqlServerHospitalization(ConnectionService connectionService)
        {
            _conService = connectionService ??
                throw new ArgumentNullException(nameof(connectionService));
        }

        public async Task<Result<string>> AddHospitalizationAsync(Hospitalization hospitalization)
        {
            if (hospitalization == null)
            {
                return new Result<string>("Пустое значение параметра");
            }

            var nameProc = @"[dbo].[spHospitalizations_Add]";
            object res = null;
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramSDate = new SqlParameter();
                    paramSDate.ParameterName = "@sd";
                    paramSDate.SqlDbType = SqlDbType.DateTime;
                    paramSDate.Value = hospitalization.StartHospitalizationDate;

                    var paramEDate = new SqlParameter();
                    paramEDate.ParameterName = "@ed";
                    paramEDate.SqlDbType = SqlDbType.DateTime;
                    paramEDate.Value = hospitalization.EndHospitalizationDate;

                    var paramDefDiag = new SqlParameter();
                    paramDefDiag.ParameterName = "@dd";
                    paramDefDiag.SqlDbType = SqlDbType.NVarChar;
                    paramDefDiag.Value = hospitalization.DefinitiveDiagnosis.Trim();

                    var paramMedOrg = new SqlParameter();
                    paramMedOrg.ParameterName = "@mo";
                    paramMedOrg.SqlDbType = SqlDbType.NVarChar;
                    paramMedOrg.Value = hospitalization.MedicalOrganization.Trim();

                    cmd.Parameters.Add(paramSDate);
                    cmd.Parameters.Add(paramEDate);
                    cmd.Parameters.Add(paramDefDiag);
                    cmd.Parameters.Add(paramMedOrg);
                    cmd.CommandType = CommandType.StoredProcedure;

                    await con.OpenAsync();
                    res = await cmd.ExecuteScalarAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно сохранена новая госпитализация {res}.", string.Empty);
        }

        public async Task<Result<int>> GetCountHospitalizationsByPatientIdAsync(int id)
        {
            /*if (id == 0)
            {
              //  return new Result<Hospitalization>("Неверный Id.");
            }

            var hospitalization = new Hospitalization();
            var nameProc = @"[dbo].[spHospitalizations_GetCountById]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = hospitalization;

                    cmd.Parameters.Add(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            hospitalization.Id = reader.GetInt32(0);
                            hospitalization.PatientId = reader.GetInt32(1);
                            hospitalization.StartHospitalizationDate = reader.GetDateTime(2);
                            hospitalization.EndHospitalizationDate = reader.GetDateTime(3);
                            hospitalization.DefinitiveDiagnosis = reader.GetString(4);
                            hospitalization.MedicalOrganization = reader.GetString(5);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<Hospitalization>(ex.Message);
            }

            if (hospitalization.Id == 0)
            {
                return new Result<Hospitalization>("Не найден с таким Id");
            }
            else
            {
                return new Result<Hospitalization>(hospitalization);
            }*/
            throw new NotImplementedException();
        }

        public Task<Result<List<Hospitalization>>> GetHospitalizationsByPatientIdAsync(int patientId)
        {
            throw new NotImplementedException();
        }
    }
}
