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
    public class SqlServerExaminations : IExaminationDataContext
    {
        private readonly ConnectionService _conService;
        private readonly IDataContext _dataContext;

        public SqlServerExaminations(ConnectionService connectionService, IDataContext dataContext)
        {
            _conService = connectionService ??
                throw new ArgumentNullException(nameof(connectionService));
            _dataContext = dataContext ??
                throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<Result<string>> AddExaminationAsync(Examination examination)
        {
            if (examination == null)
            {
                return new Result<string>("Пустое значение параметра");
            }
            if (examination.PatientId <= 0)
            {
                return new Result<string>("Id пациента не может быть меньше или равен 0");
            }
            if (examination.DiagnosisId <= 0)
            {
                return new Result<string>("Id диагноза не может быть меньше или равен 0");
            }
            if (examination.DoctorId <= 0)
            {
                return new Result<string>("Id доктора не может быть меньше или равен 0");
            }
            if (examination.HealthGroupId <= 0)
            {
                return new Result<string>("Id группы здоровья не может быть меньше или равен 0");
            }

            object res = null;
            try
            {
                SqlParameter[] parameters = GetSqlParametersfromExamination(examination);

                using (var con = _conService.GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[spExaminations_Add]";
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

            return new Result<string>($"Успешно сохранен новый осмотр {res}.", string.Empty);
        }

        private SqlParameter[] GetSqlParametersfromExamination(Examination examination)
        {
            var result = new List<SqlParameter>();

            var paramDate = new SqlParameter();
            paramDate.ParameterName = "@date";
            paramDate.SqlDbType = SqlDbType.Date;
            paramDate.Value = examination.ExaminationDate;

            var paramPatient = new SqlParameter();
            paramPatient.ParameterName = "@patientId";
            paramPatient.SqlDbType = SqlDbType.Int;
            paramPatient.Value = examination.PatientId;

            var paramDiagnosis = new SqlParameter();
            paramDiagnosis.ParameterName = "@diagnosisId";
            paramDiagnosis.SqlDbType = SqlDbType.Int;
            paramDiagnosis.Value = examination.DiagnosisId;

            var paramGroup = new SqlParameter();
            paramGroup.ParameterName = "@hgroupId";
            paramGroup.SqlDbType = SqlDbType.Int;
            paramGroup.Value = examination.HealthGroupId;

            var paramDoctor = new SqlParameter();
            paramDoctor.ParameterName = "@doctorId";
            paramDoctor.SqlDbType = SqlDbType.Int;
            paramDoctor.Value = examination.DoctorId;

            result.Add(paramDate);
            result.Add(paramPatient);
            result.Add(paramDiagnosis);
            result.Add(paramGroup);
            result.Add(paramDoctor);
            return result.ToArray();
        }

        public async Task<Result<int>> GetCountExaminationsByPatientIdAsync(int patientId)
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
                    cmd.CommandText = "[dbo].[spExaminations_GetCountByPatientId]";
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

        public async Task<Result<List<Examination>>> GetExaminationsByPatientIdAsync(int patientId)
        {
            if (patientId <= 0)
            {
                return new Result<List<Examination>>("Id пациента не может быть меньшим или равным 0");
            }

            var result = new List<Examination>();
            try
            {
                using (var con = _conService.GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[spExaminations_GetByPatientId]";
                    var param = new SqlParameter();
                    param.ParameterName = "@patientId";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = patientId;
                    cmd.Parameters.Add(param);

                    await con.OpenAsync();
                    //>>>Осмотры
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                Examination exam = GetExaminationfromReader(reader);
                                result.Add(exam);
                            }
                        }
                        else
                        {
                            return new Result<List<Examination>>(result);
                        }
                    }
                    //<<<
                }
            }
            catch (Exception ex)
            {
                return new Result<List<Examination>>(ex.Message);
            }

            //>>>Диагнозы
            foreach (Examination exam in result)
            {
                await GetDiagnosisForExaminationAsync(exam);
            }
            //<<<

            //>>>Доктора
            foreach (Examination exam in result)
            {
                await GetDoctorForExaminationAsync(exam);
            }
            //<<<

            //>>>Группа здоровья
            foreach (Examination exam in result)
            {
                await GetHealthGroupForExaminationAsync(exam);
            }
            //<<<

            return new Result<List<Examination>>(result);
        }

        private Examination GetExaminationfromReader(SqlDataReader reader)
        {
            return new Examination
            {
                Id = reader.GetInt32(0),
                ExaminationDate = reader.GetDateTime(1),
                PatientId = reader.GetInt32(2),
                DiagnosisId = reader.GetInt32(3),
                HealthGroupId = reader.GetInt32(4),
                DoctorId = reader.GetInt32(5)
            };
        }

        private async Task GetDiagnosisForExaminationAsync(Examination exam)
        {
            var diagnosis = await _dataContext.Diagnoses.GetDiagnosisByIdAsync(exam.DiagnosisId);
            if (diagnosis.HasValue)
            {
                exam.Diagnosis = diagnosis.Value;
            }
        }

        private async Task GetDoctorForExaminationAsync(Examination exam)
        {
            var doctor = await _dataContext.Doctors.GetDoctorByIdAsync(exam.DoctorId);
            if (doctor.HasValue)
            {
                exam.Doctor = doctor.Value;
            }
        }

        private async Task GetHealthGroupForExaminationAsync(Examination exam)
        {
            var hgroup = await _dataContext.HealthGroups.GetHealthGroupByIdAsync(exam.HealthGroupId);
            if (hgroup.HasValue)
            {
                exam.HealthGroup = hgroup.Value;
            }
        }
    }
}
