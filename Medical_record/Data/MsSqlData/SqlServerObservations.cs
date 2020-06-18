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
    public class SqlServerObservations : IObservationDataContext
    {
        private readonly ConnectionService _conService;
        private readonly IDataContext _dataContext;

        public SqlServerObservations(ConnectionService connectionService, IDataContext dataContext)
        {
            _conService = connectionService ??
                throw new ArgumentNullException(nameof(connectionService));
            _dataContext = dataContext ??
                throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<Result<string>> AddObservationAsync(Observation observation)
        {
            if (observation == null)
            {
                return new Result<string>("Пустое значение параметра");
            }
            if (observation.PatientId <= 0)
            {
                return new Result<string>("Id пациента не может быть меньше или равен 0");
            }
            if (observation.DiagnosisId <= 0)
            {
                return new Result<string>("Id диагноза не может быть меньше или равен 0");
            }
            if (observation.DoctorId <= 0)
            {
                return new Result<string>("Id доктора не может быть меньше или равен 0");
            }

            object res = null;
            try
            {
                SqlParameter[] parameters = GetSqlParametersfromObservation(observation);

                using (var con = _conService.GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[spObservations_Add]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);

                    await con.OpenAsync();
                    res = await cmd.ExecuteScalarAsync();
                }
            }
            catch (Exception ex)
            {
                return new Result<string>(ex.Message);
            }

            return new Result<string>($"Успешно сохранено новое наблюдение {res}.", string.Empty);
        }

        private SqlParameter[] GetSqlParametersfromObservation(Observation observation)
        {
            var result = new List<SqlParameter>();

            var paramPatient = new SqlParameter();
            paramPatient.ParameterName = "@patientId";
            paramPatient.SqlDbType = SqlDbType.Int;
            paramPatient.Value = observation.PatientId;

            var paramDiagnosis = new SqlParameter();
            paramDiagnosis.ParameterName = "@diagnosisId";
            paramDiagnosis.SqlDbType = SqlDbType.Int;
            paramDiagnosis.Value = observation.DiagnosisId;

            var paramDoctor = new SqlParameter();
            paramDoctor.ParameterName = "@doctorId";
            paramDoctor.SqlDbType = SqlDbType.Int;
            paramDoctor.Value = observation.DoctorId;

            var paramStart = new SqlParameter();
            paramStart.ParameterName = "@startDate";
            paramStart.SqlDbType = SqlDbType.Date;
            paramStart.Value = observation.StartObservationDate;

            var paramEnd = new SqlParameter();
            paramEnd.ParameterName = "@endDate";
            paramEnd.SqlDbType = SqlDbType.Date;
            paramEnd.Value = observation.EndObservationDate;

            result.Add(paramPatient);
            result.Add(paramDiagnosis);
            result.Add(paramDoctor);
            result.Add(paramStart);
            result.Add(paramEnd);
            return result.ToArray();
        }

        public async Task<Result<int>> GetCountObservationsByPatientIdAsync(int patientId)
        {
            if (patientId <= 0)
            {
                return new Result<int>("Id пациента не может быть меньшим или равным 0");
            }

            int result = 0;
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[spObservations_GetCountByPatientId]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    var param = new SqlParameter();
                    param.ParameterName = "@patientId";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = patientId;
                    cmd.Parameters.Add(param);

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

        public async Task<Result<List<Observation>>> GetObservationsByPatientIdAsync(int patientId)
        {
            if (patientId <= 0)
            {
                return new Result<List<Observation>>("Id пациента не может быть меньшим или равным 0");
            }

            var result = new List<Observation>();
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[spObservations_GetByPatientId]";
                    var param = new SqlParameter();
                    param.ParameterName = "@patientId";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = patientId;
                    cmd.Parameters.Add(param);

                    await con.OpenAsync();
                    //>>>Наблюдения
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var observation = GetObservationfromReader(reader);
                                result.Add(observation);
                            }
                        }
                        else
                        {
                            return new Result<List<Observation>>(result);
                        }
                    }
                    //<<<
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Observation>>(ex.Message);
            }

            //>>>Диагнозы
            foreach (Observation obs in result)
            {
                await GetDiagnosisForObservationAsync(obs);
            }
            //<<<

            //>>>Доктора
            foreach (Observation obs in result)
            {
                await GetDoctorForObservationAsync(obs);
            }
            //<<<

            return new Result<List<Observation>>(result);
        }

        private async Task GetDoctorForObservationAsync(Observation obs)
        {
            var doctor = await _dataContext.Doctors.GetDoctorByIdAsync(obs.DoctorId);
            if (doctor.HasValue)
            {
                obs.Doctor = doctor.Value;
            }
        }

        private async Task GetDiagnosisForObservationAsync(Observation obs)
        {
            var diagnosis = await _dataContext.Diagnoses.GetDiagnosisByIdAsync(obs.DiagnosisId);
            if (diagnosis.HasValue)
            {
                obs.Diagnosis = diagnosis.Value;
            }
        }

        private Observation GetObservationfromReader(SqlDataReader reader)
        {
            var result = new Observation
            {
                Id = reader.GetInt32(0),
                PatientId = reader.GetInt32(1),
                DiagnosisId = reader.GetInt32(2),
                DoctorId = reader.GetInt32(3),
                StartObservationDate = reader.GetDateTime(4),
                EndObservationDate = reader.GetDateTime(5)
            };

            return result;
        }
    }
}
