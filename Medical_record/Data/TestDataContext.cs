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
        private readonly List<Medications> _medications = new List<Medications>();

        public TestDataContext()
        {
            SetPatients();
            SetDiagnoses();
            SetMedications();
        }

        private void SetMedications()
        {
            var m = new Medications
            {
                Id = 1,
                Name = "",
                Description = "",
                ArrivalDate = DateTime.Parse("23.03.1984"),
                ArrivalPackages = "",
                ShelfLife = DateTime.Parse("23.03.1984"),
                QuantityPackage = "",
                RestPackages = "",
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
    }
}
