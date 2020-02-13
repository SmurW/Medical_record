using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using Medical_record.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data
{
    class DbDataContext : IDataContext
    {
        public Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> AddDoctorsAsync(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> AddMedicationsAsync(Medications diagnosis)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> AddPatientAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> AddProcedureAsync(Procedure proc)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesLikeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesOrderByAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Doctor>>> GetDoctorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Doctor>>> GetDoctorsLikeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Doctor>>> GetDoctorsOrderByAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Medications>>> GetMedicationsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Medications>>> GetMedicationsLikeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Medications>>> GetMedicationsOrderByAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Patient>>> GetPatientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Procedure>>> GetProceduresAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Procedure>>> GetProceduresLikeAsync(string v)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<Procedure>>> GetProceduresOrderByAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemoveDiagnosisAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemoveDoctorsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemoveMedicationsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemovePatientAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemoveProcedureAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateDoctorsAsync(Medications medications)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateDoctorsAsync(Doctor medications)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateMedicationsAsync(Medications diagnosis)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdatePatientAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateProcedureAsync(Procedure proc)
        {
            throw new NotImplementedException();
        }
    }
}
