using Medical_record.Abstractions;
using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical_record.Data
{
    class TestDataContext : IDataContext
    {
        private readonly List<Patient> _patients = new List<Patient>();
        private readonly List<Diagnosis> _diagnoses = new List<Diagnosis>();
        private readonly List<Procedure> _procedures = new List<Procedure>();
        private readonly List<Medications> _medications = new List<Medications>();
        private readonly List<Doctor> _doctors = new List<Doctor>();
        private readonly List<Observation> _observations = new List<Observation>();
        private readonly List<Hospitalization> _hospitalizations = new List<Hospitalization>();
        private readonly List<Specialization> _specializations = new List<Specialization>();
        private readonly List<HealthGroup> _healthGroups = new List<HealthGroup>();
        private readonly List<Examination> _examinations = new List<Examination>();

        public TestDataContext()
        {
            SetProcedures();
            SetPatients();
            SetDiagnoses();
            SetMedications();
            SetDoctors();
            SetObservations();
            SetHospitalizations();
            SetSpecializations();
            SetHealthGroupus();
            SetExaminations();
        }

        private void SetExaminations()
        {
            var ex = new Examination
            {
                Id = 1,
                ExaminationDate = DateTime.Parse("12.04.2014"),
                DiagnosisId = 2,
                HealthGroupId = 1,
                PatientId = 2,
                DoctorId = 2
            };
            _examinations.Add(ex);

            ex = new Examination
            {
                Id = 2,
                ExaminationDate = DateTime.Parse("02.02.2016"),
                DiagnosisId = 1,
                HealthGroupId = 2,
                PatientId = 3,
                DoctorId = 1
            };
            _examinations.Add(ex);

            ex = new Examination
            {
                Id = 3,
                ExaminationDate = DateTime.Parse("11.10.2017"),
                DiagnosisId = 3,
                HealthGroupId = 3,
                PatientId = 1,
                DoctorId = 3
            };
            _examinations.Add(ex);

            ex = new Examination
            {
                Id = 4,
                ExaminationDate = DateTime.Parse("01.01.2018"),
                DiagnosisId = 1,
                HealthGroupId = 3,
                PatientId = 1,
                DoctorId = 2
            };
            _examinations.Add(ex);

            ex = new Examination
            {
                Id = 5,
                ExaminationDate = DateTime.Parse("14.11.2019"),
                DiagnosisId = 3,
                HealthGroupId = 3,
                PatientId = 1,
                DoctorId = 1
            };
            _examinations.Add(ex);
        }

        private void SetHealthGroupus()
        {
            var hg = new HealthGroup
            {
                Id = 1,
                Title = "Первая группа",
                Description = "К этой группе относят практически здоровых людей," +
                " не имеющих каких-либо отклонений в состоянии организма," +
                " не страдающих хроническими заболеваниями.",
            };
            _healthGroups.Add(hg);

            hg = new HealthGroup
            {
                Id = 2,
                Title = "Вторая группа",
                Description = "Пациенты с хроническими заболеваниями, которые не оказывают влияния" +
                " на общее самочувствие, не снижающими работоспособность человека."

            };
            _healthGroups.Add(hg);

            hg = new HealthGroup
            {
                Id = 3,
                Title = "Третья группа",
                Description = "Пациенты , имеющие хронические заболевания," +
                " сопровождающиеся частыми обострениями. Вследствие этого пациенты данной " +
                "группы часто теряют трудоспособность на определенное время" +
                " (короткое или продолжительное)."

            };
            _healthGroups.Add(hg);
        }

        private void SetSpecializations()
        {
            var s = new Specialization
            {
                Id = 1,
                Name = "ЛОР",
            };
            _specializations.Add(s);

            s = new Specialization
            {
                Id = 2,
                Name = "Терапевт",
            };
            _specializations.Add(s);

            s = new Specialization
            {
                Id = 3,
                Name = "Хирург",
            };
            _specializations.Add(s);
        }

        private void SetDoctors()
        {
            var d = new Doctor
            {
                Id = 1,
                LastName = "Петров",
                FirstName = "Андрей",
                MiddleName = "Семенович",
                SpecializationId = 1
            };
            _doctors.Add(d);

             d = new Doctor
            {
                Id = 2,
                LastName = "Лукашенко",
                FirstName = "Дмитрий",
                MiddleName = "Сергеевич",
                SpecializationId = 2
            };
            _doctors.Add(d);

             d = new Doctor
            {
                Id = 3,
                LastName = "Пиражков",
                FirstName = "Леонид",
                MiddleName = "Эдуардович",
                SpecializationId = 3
            };
            _doctors.Add(d);
            
        }

        private void SetProcedures()
        {
            var p = new Procedure
            {
                Id = 1,
                Name = "Процедура 1",
                Description = "Описание процедуры 1"
            };
            _procedures.Add(p);

            p = new Procedure
            {
                Id = 2,
                Name = "Процедура 2",
                Description = "Описание процедуры 2"
            };
            _procedures.Add(p);

            p = new Procedure
            {
                Id = 3,
                Name = "Процедура 3",
                Description = "Описание процедуры 3"
            };
            _procedures.Add(p);
        }

        private void SetMedications()
        {
            var m = new Medications
            {
                Id = 1,
                Name = "Арбидол",
                Description = "Капсулы твердые желатиновые, размер №0, белого цвета",
                ArrivalDate = DateTime.Parse("23.03.1984"),
                ArrivalPackages = "капсулы 200 мг: 20 шт.",
                ShelfLife = DateTime.Parse("23.03.1986"),
                QuantityPackage = 105,
                RestPackages = 30,
                RemainedUnits = "",
            };
            _medications.Add(m);

            m = new Medications
            {
                Id = 2,
                Name = "Глюкофаж",
                Description = "Таблетки белые, круглые, двояковыпуклые, покрытые пленочной оболочкой",
                ArrivalDate = DateTime.Parse("20.06.1987"),
                ArrivalPackages = "Таблетки 500 и 850 мг",
                ShelfLife = DateTime.Parse("13.01.1989"),
                QuantityPackage = 67,
                RestPackages = 28,
                RemainedUnits = "",
            };
            _medications.Add(m);

            m = new Medications
            {
                Id = 3,
                Name = "Пирацетам",
                Description = "Ноотропное средство. Оказывает положительное влияние на обменные процессы и кровообращение мозга.",
                ArrivalDate = DateTime.Parse("13.05.1987"),
                ArrivalPackages = "Таблетки, покрытые пленочной оболочкой",
                ShelfLife = DateTime.Parse("13.09.1989"),
                QuantityPackage = 34,
                RestPackages = 23,
                RemainedUnits = "",
            };
            _medications.Add(m);
        }

        private void SetDiagnoses()
        {
            var d = new Diagnosis
            {
                Id = 1,
                Name = "Грипп",
                Description = "Острое инфекционное заболевание дыхательных путей, " +
                "вызываемое вирусом гриппа. Входит в группу острых респираторных" +
                " вирусных инфекций (ОРВИ). Периодически распространяется в виде эпидемий."
            };
            _diagnoses.Add(d);

            d = new Diagnosis
            {
                Id = 2,
                Name = "Просту́да",
                Description = "Острая респираторная инфекция общей (невыясненной) этиологии" +
                " с воспалением верхних дыхательных путей, затрагивающая преимущественно нос." +
                " В воспаление могут быть также вовлечены горло, гортань и пазухи." +
                " Термин используется наряду с фарингитом, ларингитом, трахеитом и другими."
            };
            _diagnoses.Add(d);

            d = new Diagnosis
            {
                Id = 3,
                Name = "Диаре́я",
                Description = "Патологическое состояние, при котором у больного наблюдается учащённая" +
                " (более 3 раз в сутки) дефекация, при этом стул становится водянистым," +
                " имеет объём более 200 мл и часто сопровождается болевыми ощущениями в области живота," +
                " экстренными позывами и анальным недержанием"
            };
            _diagnoses.Add(d);
        }

        private void SetPatients()
        {
            var p = new Patient
            {
                Id = 1,
                Birthdate = DateTime.Parse("23.03.1984"),
                CardNumber = "2345",
                FirstName = "Ирина",
                LastName = "Мухина",
                MiddleName = "Анатольевна",
                PassportDepCode = "880-013",
                PassportIssueDate = DateTime.Parse("11.12.1995"),
                PassportNumber = "832986",
                PassportSeries = "44-17",
                PassportUFMS = "ТП №13 отдела УФМС России",
                RegistrationDate = DateTime.Parse("13.05.2005"),
                Residence = "ул. Соборная, дом 29б, кв.23",
                Sex = "Женский"
            };
            _patients.Add(p);

            p = new Patient
            {
                Id = 2,
                Birthdate = DateTime.Parse("01.08.1982"),
                CardNumber = "2376",
                FirstName = "Кирилл",
                LastName = "Петров",
                MiddleName = "Геннадьевич",
                PassportDepCode = "280-002",
                PassportIssueDate = DateTime.Parse("10.01.1993"),
                PassportNumber = "324655",
                PassportSeries = "39-13",
                PassportUFMS = "ТП №24 отдела УФМС России",
                RegistrationDate = DateTime.Parse("10.07.2001"),
                Residence = "ул. Морская, дом 15, корп. 2, кв.23",
                Sex = "Мужской"
            };
            _patients.Add(p);

            p = new Patient
            {
                Id = 3,
                Birthdate = DateTime.Parse("13.11.1989"),
                CardNumber = "3456",
                FirstName = "Станислав",
                LastName = "Кузнецов",
                MiddleName = "Иванович",
                PassportDepCode = "110-001",
                PassportIssueDate = DateTime.Parse("11.12.1997"),
                PassportNumber = "567231",
                PassportSeries = "24-15",
                PassportUFMS = "ТП №10 отдела УФМС России",
                RegistrationDate = DateTime.Parse("03.05.2002"),
                Residence = "ул. Лукьянова, дом 45, кв.123",
                Sex = "Мужской"
            };
            _patients.Add(p);
        }

        private void SetHospitalizations()
        {
            var h = new Hospitalization
            {
                Id = 1,
                StartHospitalizationDate = DateTime.Parse("12.03.2014"),
                EndHospitalizationDate = DateTime.Parse("20.03.2014"),
                PatientId = 2,
                MedicalOrganization = "Мед.уч. № 1",
                DefinitiveDiagnosis = "Оконч.диагноз 1",
            };
            _hospitalizations.Add(h);

            h = new Hospitalization
            {
                Id = 2,
                StartHospitalizationDate = DateTime.Parse("03.05.2017"),
                EndHospitalizationDate = DateTime.Parse("17.05.2017"),
                PatientId = 1,
                MedicalOrganization = "Мед.уч. № 2",
                DefinitiveDiagnosis = "Оконч.диагноз 2",
            };
            _hospitalizations.Add(h);

            h = new Hospitalization
            {
                Id = 3,
                StartHospitalizationDate = DateTime.Parse("13.07.2017"),
                EndHospitalizationDate = DateTime.Parse("21.07.2017"),
                PatientId = 2,
                MedicalOrganization = "Мед.уч. № 1",
                DefinitiveDiagnosis = "Оконч.диагноз 1",
            };
            _hospitalizations.Add(h);
        }

        private void SetObservations()
        {
            var o = new Observation
            {
                Id = 1,
                StartObservationDate = DateTime.Parse("12.03.2014"),
                EndObservationDate = DateTime.Parse("12.03.2015"),
                PatientId = 2,
                DiagnosisId = 3,
                DoctorId = 2
            };
            _observations.Add(o);

            o = new Observation
            {
                Id = 2,
                StartObservationDate = DateTime.Parse("22.09.2016"),
                EndObservationDate = DateTime.Parse("12.10.2016"),
                PatientId = 1,
                DiagnosisId = 1,
                DoctorId = 3
            };
            _observations.Add(o);

            o = new Observation
            {
                Id = 4,
                StartObservationDate = DateTime.Parse("01.01.2017"),
                EndObservationDate = DateTime.Parse("13.01.2017"),
                PatientId = 1,
                DiagnosisId = 1,
                DoctorId = 1
            };
            _observations.Add(o);

            o = new Observation
            {
                Id = 5,
                StartObservationDate = DateTime.Parse("25.09.2018"),
                EndObservationDate = DateTime.Parse("07.10.2018"),
                PatientId = 1,
                DiagnosisId = 3,
                DoctorId = 2
            };
            _observations.Add(o);

            o = new Observation
            {
                Id = 3,
                StartObservationDate = DateTime.Parse("10.10.2007"),
                EndObservationDate = DateTime.Parse("12.10.2017"),
                PatientId = 3,
                DiagnosisId = 3,
                DoctorId = 1
            };
            _observations.Add(o);
        }

        public Task<Result<List<Doctor>>> GetDoctorsAsync()
        {
            _doctors.ForEach(d => d.Specialization = GetDoctorSpecialization(d.SpecializationId));

            return Task.FromResult(new Result<List<Doctor>>(_doctors));
        }

        private Specialization GetDoctorSpecialization(int specializationId)
        {
            return _specializations.FirstOrDefault(s => s.Id == specializationId);
        }

        public Task<Result<string>> AddDoctorAsync(Doctor doctor)
        {
            doctor.Id = 1;
            if (_doctors.Count > 0)
            {
                doctor.Id = _doctors.Max(d => d.Id) + 1;
            }
            _doctors.Add(doctor);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {doctor.LastName} {doctor.FirstName} {doctor.MiddleName}", String.Empty));
        }

        public Task<Result<List<Doctor>>> GetDoctorsOrderByAsync(string key)
        {
            if (key.Equals("LastName"))
            {
                return Task.FromResult(
                    new Result<List<Doctor>>(
                        _doctors.OrderBy(d => d.LastName).ToList()));
            }
            if (key.Equals("FirstName"))
            {
                return Task.FromResult(
                    new Result<List<Doctor>>(
                        _doctors.OrderBy(d => d.FirstName).ToList()));
            }
            else
            {
                return Task.FromResult(
                    new Result<List<Doctor>>(
                        _doctors.OrderBy(d => d.MiddleName).ToList()));
            }
        }

        public Task<Result<List<Doctor>>> GetDoctorsLikeAsync(string value)
        {
            return Task.FromResult(
                    new Result<List<Doctor>>(
                        _doctors.Where(d => d.FirstName.Contains(value)).ToList()));
        }

        public Task<Result<List<Patient>>> GetPatientsAsync()
        {
            return Task.FromResult(new Result<List<Patient>>(_patients));
        }

        public Task<Result<string>> UpdatePatientAsync(Patient patient)
        {
            var pt = _patients.FirstOrDefault(p => p.Id == patient.Id);
            if (pt == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            pt.Birthdate = patient.Birthdate;
            pt.CardNumber = patient.CardNumber;
            pt.FirstName = patient.FirstName;
            pt.LastName = patient.LastName;
            pt.MiddleName = patient.MiddleName;
            pt.PassportDepCode = patient.PassportDepCode;
            pt.PassportIssueDate = patient.PassportIssueDate;
            pt.PassportNumber = patient.PassportNumber;
            pt.PassportSeries = patient.PassportSeries;
            pt.PassportUFMS = patient.PassportUFMS;
            pt.RegistrationDate = patient.RegistrationDate;
            pt.Residence = patient.Residence;
            pt.Sex = patient.Sex;

            return Task.FromResult(new Result<string>("Успешно обновлен", String.Empty));
        }

        public Task<Result<string>> AddPatientAsync(Patient patient)
        {
            patient.Id = 1;
            if (_patients.Count > 0)
            {
                patient.Id = _patients.Max(p => p.Id) + 1;
            }
            _patients.Add(patient);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {patient.LastName} {patient.FirstName} {patient.MiddleName}",
                String.Empty));
        }

        public Task<Result<string>> RemovePatientAsync(int id)
        {
            var pt = _patients.FirstOrDefault(p => p.Id == id);
            if (pt == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _patients.Remove(pt);
            return Task.FromResult(new Result<string>("Успешно удален", String.Empty));
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesAsync()
        {
            return Task.FromResult(new Result<List<Diagnosis>>(_diagnoses));
        }

        public Task<Result<string>> AddDiagnosisAsync(Diagnosis diagnosis)
        {
            diagnosis.Id = 1;
            if (_diagnoses.Count > 0)
            {
                diagnosis.Id = _diagnoses.Max(d => d.Id) + 1;
            }
            _diagnoses.Add(diagnosis);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {diagnosis.Name}", String.Empty));
        }

        public Task<Result<string>> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            var dg = _diagnoses.FirstOrDefault(d => d.Id == diagnosis.Id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            dg.Name = diagnosis.Name;
            dg.Description = diagnosis.Description;
            return Task.FromResult(new Result<string>("Успешно обновлен", String.Empty));
        }

        public Task<Result<string>> RemoveDiagnosisAsync(int id)
        {
            var dg = _diagnoses.FirstOrDefault(d => d.Id == id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _diagnoses.Remove(dg);
            return Task.FromResult(new Result<string>("Успешно удален", String.Empty));
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesOrderByAsync(string key)
        {
            if (key.Equals("Name"))
            {
                return Task.FromResult(
                    new Result<List<Diagnosis>>(
                        _diagnoses.OrderBy(d => d.Name).ToList()));
            }
            else
            {
                return Task.FromResult(
                    new Result<List<Diagnosis>>(
                        _diagnoses.OrderBy(d => d.Description).ToList()));
            }
        }

        public Task<Result<List<Diagnosis>>> GetDiagnosesLikeAsync(string value)
        {
            return Task.FromResult(
                    new Result<List<Diagnosis>>(
                        _diagnoses.Where(d => d.Name.Contains(value)).ToList()));
        }

        public Task<Result<List<Procedure>>> GetProceduresAsync()
        {
            return Task.FromResult(new Result<List<Procedure>>(_procedures));
        }

        public Task<Result<string>> AddProcedureAsync(Procedure proc)
        {
            proc.Id = 1;
            if (_procedures.Count > 0)
            {
                proc.Id = _procedures.Max(p => p.Id) + 1;
            }
            _procedures.Add(proc);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранена {proc.Name}", String.Empty));
        }

        public Task<Result<string>> UpdateProcedureAsync(Procedure proc)
        {
            var pr = _procedures.FirstOrDefault(p => p.Id == proc.Id);
            if (pr == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            pr.Name = proc.Name;
            pr.Description = proc.Description;
            return Task.FromResult(new Result<string>("Успешно обновлена", String.Empty));
        }

        public Task<Result<List<Procedure>>> GetProceduresLikeAsync(string value)
        {
            return Task.FromResult(
                    new Result<List<Procedure>>(
                        _procedures.Where(d => d.Name.Contains(value)).ToList()));
        }

        public Task<Result<List<Procedure>>> GetProceduresOrderByAsync(string key)
        {
            if (key.Equals("Name"))
            {
                return Task.FromResult(
                    new Result<List<Procedure>>(
                        _procedures.OrderBy(d => d.Name).ToList()));
            }
            else
            {
                return Task.FromResult(
                    new Result<List<Procedure>>(
                        _procedures.OrderBy(d => d.Description).ToList()));
            }
        }

        public Task<Result<string>> RemoveProcedureAsync(int id)
        {
            var pr = _procedures.FirstOrDefault(d => d.Id == id);
            if (pr == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _procedures.Remove(pr);
            return Task.FromResult(new Result<string>("Успешно удалена", String.Empty));
        }

        public Task<Result<List<Medications>>> GetMedicationsAsync()
        {
            return Task.FromResult(new Result<List<Medications>>(_medications));
        }

        public Task<Result<string>> AddMedicationsAsync(Medications medications)
        {
            medications.Id = 1;
            if (_medications.Count > 0)
            {
                medications.Id = _medications.Max(d => d.Id) + 1;
            }
            _medications.Add(medications);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {medications.Name}", String.Empty));
        }

        public Task<Result<string>> UpdateMedicationsAsync(Medications medications)
        {
            var dg = _medications.FirstOrDefault(d => d.Id == medications.Id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось обновить"));

            dg.Name = medications.Name;
            dg.Description = medications.Description;
            return Task.FromResult(new Result<string>("Успешно обновлен", String.Empty));
        }

        public Task<Result<string>> RemoveMedicationsAsync(int id)
        {
            var dg = _medications.FirstOrDefault(d => d.Id == id);
            if (dg == null)
                return Task.FromResult(new Result<string>("Не удалось удалить"));

            _medications.Remove(dg);
            return Task.FromResult(new Result<string>("Успешно удален", String.Empty));
        }

        public Task<Result<List<Medications>>> GetMedicationsOrderByAsync(string key)
        {
            if (key.Equals("Name"))
            {
                return Task.FromResult(
                    new Result<List<Medications>>(
                        _medications.OrderBy(d => d.Name).ToList()));
            }
            else
            {
                return Task.FromResult(
                    new Result<List<Medications>>(
                        _medications.OrderBy(d => d.Description).ToList()));
            }
        }

        public Task<Result<List<Medications>>> GetMedicationsLikeAsync(string value)
        {
            return Task.FromResult(
                    new Result<List<Medications>>(
                        _medications.Where(d => d.Name.Contains(value)).ToList()));
        }

        public Task<Result<int>> GetLastAddedPatientIdAsync()
        {
            return Task.FromResult(new Result<int>(_patients.Last().Id));
        }

        public Task<Result<string>> AddObservationAsync(Observation observation)
        {
            observation.Id = 1;
            if (_observations.Count > 0)
            {
                observation.Id = _observations.Max(o => o.Id) + 1;
            }
            _observations.Add(observation);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранено {observation.Id}", String.Empty));
        }

        public Task<Result<int>> GetCountObservationsByPatientIdAsync(int id)
        {
            var count = _observations.Where(o => o.PatientId == id).Count();
            return Task.FromResult(new Result<int>(count));
        }

        public Task<Result<int>> GetCountHospitalizationsByPatientIdAsync(int id)
        {
            var count = _hospitalizations.Where(o => o.PatientId == id).Count();
            return Task.FromResult(new Result<int>(count));
        }

        public Task<Result<string>> AddHospitalizationAsync(Hospitalization hosp)
        {
            hosp.Id = 1;
            if (_hospitalizations.Count > 0)
            {
                hosp.Id = _hospitalizations.Max(h => h.Id) + 1;
            }
            _hospitalizations.Add(hosp);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранена {hosp.Id}", String.Empty));
        }

        public Task<Result<List<Specialization>>> GetSpecializationsAsync()
        {
            return Task.FromResult(new Result<List<Specialization>>(_specializations));
        }

        public Task<Result<List<HealthGroup>>> GetHealthGroupsAsync()
        {
            return Task.FromResult(new Result<List<HealthGroup>>(_healthGroups));
        }

        public Task<Result<int>> GetCountExaminationsByPatientIdAsync(int id)
        {
            var count = _examinations.Where(e => e.PatientId == id).Count();
            return Task.FromResult(new Result<int>(count));
        }

        public Task<Result<string>> AddExaminationAsync(Examination exam)
        {
            exam.Id = 1;
            if (_examinations.Count > 0)
            {
                exam.Id = _examinations.Max(h => h.Id) + 1;
            }
            _examinations.Add(exam);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {exam.Id}", String.Empty));
        }

        public Task<Result<List<Observation>>> GetObservationsByPatientIdAsync(int currentPatientId)
        {
            var obs = _observations.Where(o => o.PatientId == currentPatientId).ToList();
            return Task.FromResult(new Result<List<Observation>>(obs));
        }

        public Task<Result<Diagnosis>> GetDiagnosisByIdAsync(int diagnosisId)
        {
            var diag = _diagnoses.FirstOrDefault(d => d.Id == diagnosisId);
            if (diag == null)
            {
                return Task.FromResult(new Result<Diagnosis>("Диагноз не найден."));
            }

            return Task.FromResult(new Result<Diagnosis>(diag));
        }

        public Task<Result<Doctor>> GetDoctorByIdAsync(int doctorId)
        {
            var doc = _doctors.FirstOrDefault(d => d.Id == doctorId);
            if (doc == null)
            {
                return Task.FromResult(new Result<Doctor>("Доктор не найден."));
            }

            doc.Specialization = GetDoctorSpecialization(doc.SpecializationId);

            return Task.FromResult(new Result<Doctor>(doc));
        }

        public Task<Result<List<Examination>>> GetExaminationsByPatientIdAsync(int currentPatientId)
        {
            var exams = _examinations.Where(e => e.PatientId == currentPatientId).ToList();
            return Task.FromResult(new Result<List<Examination>>(exams));
        }

        public Task<Result<HealthGroup>> GetHealthGroupByIdAsync(int healthGroupId)
        {
            var hg = _healthGroups.FirstOrDefault(g => g.Id == healthGroupId);
            if (hg == null)
            {
                return Task.FromResult(new Result<HealthGroup>("Группа не найдена."));
            }

            return Task.FromResult(new Result<HealthGroup>(hg));
        }

    }
}
