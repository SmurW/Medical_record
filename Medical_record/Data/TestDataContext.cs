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

        public TestDataContext()
        {
            SetProcedures();
            SetPatients();
            SetDiagnoses();
            SetMedications();
            SetDoctors();
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

        public Task<Result<List<Doctor>>> GetDoctorsAsync()
        {
            return Task.FromResult(new Result<List<Doctor>>(_doctors));
        }

        public Task<Result<string>> AddDoctorsAsync(Doctor doctors)
        {
            doctors.Id = 1;
            if (_doctors.Count > 0)
            {
                doctors.Id = _doctors.Max(d => d.Id) + 1;
            }
            _doctors.Add(doctors);
            return Task.FromResult(new Result<string>(
                $"Успешно сохранен {doctors.LastName + doctors.FirstName + doctors.MiddleName}", String.Empty));
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

        public Task<Result<string>> UpdateDoctorsAsync(Medications medications)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> RemoveDoctorsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateDoctorsAsync(Doctor medications)
        {
            throw new NotImplementedException();
        }
    }
}
