using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_record.Data.TestData
{
    public class TestDoctorDataContext : IDoctorDataContext
    {
        private readonly DataSource _dataSource;

        public TestDoctorDataContext(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Task<Result<string>> AddDoctorAsync(Doctor doctor)
        {
            doctor.Id = 1;
            if (_dataSource.Doctors.Count > 0)
            {
                doctor.Id = _dataSource.Doctors.Max(d => d.Id) + 1;
            }
            _dataSource.Doctors.Add(doctor);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {doctor.LastName} {doctor.FirstName}" +
                $" {doctor.MiddleName}", String.Empty));
        }

        public Task<Result<Doctor>> GetDoctorByIdAsync(int doctorId)
        {
            var doc = _dataSource.Doctors.FirstOrDefault(d => d.Id == doctorId);
            if (doc == null)
            {
                return Task.FromResult(new Result<Doctor>("Доктор не найден."));
            }

            doc.Specialization = GetDoctorSpecialization(doc.SpecializationId);

            return Task.FromResult(new Result<Doctor>(doc));
        }

        private Specialization GetDoctorSpecialization(int specializationId)
        {
            return _dataSource.Specializations.FirstOrDefault(s => s.Id == specializationId);
        }

        public Task<Result<List<Doctor>>> GetDoctorsAsync()
        {
            _dataSource.Doctors.ForEach(d => d.Specialization = GetDoctorSpecialization(d.SpecializationId));
            return Task.FromResult(new Result<List<Doctor>>(_dataSource.Doctors));
        }
    }
}
