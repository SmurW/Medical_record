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

        public Task<Result<string>> AddExaminationAsync(Examination examination)
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> GetCountExaminationsByPatientIdAsync(int patientId)
        {
            throw new NotImplementedException();
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
                                Examination exam = GetExaminationFromReader(reader);
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

        

        private Examination GetExaminationFromReader(SqlDataReader reader)
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
