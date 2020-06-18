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
            if (hospitalization.PatientId == 0)
            {
                return new Result<string>("Неверное значение Id пациента");
            }

            var nameProc = @"[dbo].[spHospitalizations_Add]";
            object result = null;
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var paramPid = new SqlParameter();
                    paramPid.ParameterName = "@patientId";
                    paramPid.SqlDbType = SqlDbType.Int;
                    paramPid.Value = hospitalization.PatientId;

                    var paramSDate = new SqlParameter();
                    paramSDate.ParameterName = "@startd";
                    paramSDate.SqlDbType = SqlDbType.DateTime;
                    paramSDate.Value = hospitalization.StartHospitalizationDate;

                    var paramEDate = new SqlParameter();
                    paramEDate.ParameterName = "@endd";
                    paramEDate.SqlDbType = SqlDbType.DateTime;
                    paramEDate.Value = hospitalization.EndHospitalizationDate;

                    var paramMedOrg = new SqlParameter();
                    paramMedOrg.ParameterName = "@medorg";
                    paramMedOrg.SqlDbType = SqlDbType.NVarChar;
                    paramMedOrg.Value = hospitalization.MedicalOrganization.Trim();

                    var paramDefDiag = new SqlParameter();
                    paramDefDiag.ParameterName = "@diag";
                    paramDefDiag.SqlDbType = SqlDbType.NVarChar;
                    paramDefDiag.Value = hospitalization.DefinitiveDiagnosis.Trim();

                    cmd.Parameters.Add(paramPid);
                    cmd.Parameters.Add(paramSDate);
                    cmd.Parameters.Add(paramEDate);
                    cmd.Parameters.Add(paramDefDiag);
                    cmd.Parameters.Add(paramMedOrg);
                    cmd.CommandType = CommandType.StoredProcedure;

                    await con.OpenAsync();
                    result = await cmd.ExecuteScalarAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно сохранена новая госпитализация {result}.", string.Empty);
        }

        public async Task<Result<int>> GetCountHospitalizationsByPatientIdAsync(int patientId)
        {
            if (patientId == 0)
            {
                return new Result<int>("Неверный Id пациента.");
            }

            int result = 0;
            var nameProc = @"[dbo].[spHospitalizations_GetCountByPatientId]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@patientId";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = patientId;

                    cmd.Parameters.Add(param);
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

        public async Task<Result<List<Hospitalization>>> GetHospitalizationsByPatientIdAsync(int patientId)
        {
            if (patientId == 0)
            {
                return new Result<List<Hospitalization>>("Неверный Id пациента.");
            }

            var hosps = new List<Hospitalization>();
            var nameProc = @"[dbo].[spHospitalizations_GetByPatientId]";
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = new SqlCommand(nameProc, con))
                {
                    var param = new SqlParameter();
                    param.ParameterName = "@patientId";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = patientId;

                    cmd.Parameters.Add(param);
                    cmd.CommandType = CommandType.StoredProcedure;
                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                Hospitalization h = GetHospitalizationfromReader(reader);
                                hosps.Add(h);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Hospitalization>>(ex.Message);
            }

            return new Result<List<Hospitalization>>(hosps);
        }

        private Hospitalization GetHospitalizationfromReader(SqlDataReader reader)
        {
            return new Hospitalization
            {
                Id = reader.GetInt32(0),
                PatientId = reader.GetInt32(1),
                StartHospitalizationDate = reader.GetDateTime(2),
                EndHospitalizationDate = reader.GetDateTime(3),
                MedicalOrganization = reader.GetString(4),
                DefinitiveDiagnosis = reader.GetString(5)
            };
        }
    }
}
