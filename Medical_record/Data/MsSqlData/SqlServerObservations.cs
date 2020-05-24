using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

        public Task<Result<string>> AddObservationAsync(Observation observation)
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> GetCountObservationsByPatientIdAsync(int patientId)
        {
            throw new NotImplementedException();
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
                                var observation = GetObservationFromReader(reader);
                                result.Add(observation);
                            }
                        }
                        else
                        {
                            return new Result<List<Observation>>(result);
                        }
                    }
                    //<<<

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
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Observation>>(ex.Message);
            }

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

        private Observation GetObservationFromReader(SqlDataReader reader)
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
