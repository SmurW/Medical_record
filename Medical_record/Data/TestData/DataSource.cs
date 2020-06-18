using Medical_record.Data.Models;
using System;
using System.Collections.Generic;

namespace Medical_record.Data.TestData
{
    public class DataSource
    {
        public List<Patient> Patients { get; } = new List<Patient>();
        public List<Diagnosis> Diagnoses { get; } = new List<Diagnosis>();
        public List<Procedure> Procedures { get; } = new List<Procedure>();
        public List<Medications> Medications { get; } = new List<Medications>();
        public List<Doctor> Doctors { get; } = new List<Doctor>();
        public List<Observation> Observations { get; } = new List<Observation>();
        public List<Hospitalization> Hospitalizations { get; } = new List<Hospitalization>();
        public List<Specialization> Specializations { get; } = new List<Specialization>();
        public List<HealthGroup> HealthGroups { get; } = new List<HealthGroup>();
        public List<Examination> Examinations { get; } = new List<Examination>();
        public List<Users> Users { get; } = new List<Users>();

        public DataSource()
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
            SetUsers();
            
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
            Examinations.Add(ex);

            ex = new Examination
            {
                Id = 2,
                ExaminationDate = DateTime.Parse("02.02.2016"),
                DiagnosisId = 1,
                HealthGroupId = 2,
                PatientId = 3,
                DoctorId = 1
            };
            Examinations.Add(ex);

            ex = new Examination
            {
                Id = 3,
                ExaminationDate = DateTime.Parse("11.10.2017"),
                DiagnosisId = 3,
                HealthGroupId = 3,
                PatientId = 1,
                DoctorId = 3
            };
            Examinations.Add(ex);

            ex = new Examination
            {
                Id = 4,
                ExaminationDate = DateTime.Parse("01.01.2018"),
                DiagnosisId = 1,
                HealthGroupId = 3,
                PatientId = 1,
                DoctorId = 2
            };
            Examinations.Add(ex);

            ex = new Examination
            {
                Id = 5,
                ExaminationDate = DateTime.Parse("14.11.2019"),
                DiagnosisId = 3,
                HealthGroupId = 3,
                PatientId = 1,
                DoctorId = 1
            };
            Examinations.Add(ex);
        }

        private void SetHealthGroupus()
        {
            var hg = new HealthGroup
            {
                Id = 1,
                Title = "Первая группа",
            };
            HealthGroups.Add(hg);

            hg = new HealthGroup
            {
                Id = 2,
                Title = "Вторая группа",

            };
            HealthGroups.Add(hg);

            hg = new HealthGroup
            {
                Id = 3,
                Title = "Третья группа",

            };
            HealthGroups.Add(hg);
        }

        private void SetSpecializations()
        {
            var s = new Specialization
            {
                Id = 1,
                Name = "ЛОР",
            };
            Specializations.Add(s);

            s = new Specialization
            {
                Id = 2,
                Name = "Терапевт",
            };
            Specializations.Add(s);

            s = new Specialization
            {
                Id = 3,
                Name = "Хирург",
            };
            Specializations.Add(s);
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
            Doctors.Add(d);

            d = new Doctor
            {
                Id = 2,
                LastName = "Лукашенко",
                FirstName = "Дмитрий",
                MiddleName = "Сергеевич",
                SpecializationId = 2
            };
            Doctors.Add(d);

            d = new Doctor
            {
                Id = 3,
                LastName = "Пиражков",
                FirstName = "Леонид",
                MiddleName = "Эдуардович",
                SpecializationId = 3
            };
            Doctors.Add(d);

        }

        private void SetUsers()
        {
            var u = new Users
            {
                Id = 1,
                Login = "Admin",
                Password = "123456"
            };
            Users.Add(u);

            u = new Users
            {
                Id = 1,
                Login = "User",
                Password = "12345"
            };
            Users.Add(u);

            u = new Users
            {
                Id = 1,
                Login = "User",
                Password = "1234"
            };
            Users.Add(u);
        }

        private void SetProcedures()
        {
            var p = new Procedure
            {
                Id = 1,
                Name = "Процедура 1",
                Description = "Описание процедуры 1"
            };
            Procedures.Add(p);

            p = new Procedure
            {
                Id = 2,
                Name = "Процедура 2",
                Description = "Описание процедуры 2"
            };
            Procedures.Add(p);

            p = new Procedure
            {
                Id = 3,
                Name = "Процедура 3",
                Description = "Описание процедуры 3"
            };
            Procedures.Add(p);
        }

        private void SetMedications()
        {
            var m = new Medications
            {
                Id = 1,
                Name = "Арбидол",
                Description = "Капсулы твердые желатиновые, размер №0, белого цвета",
                ArrivalDate = DateTime.Parse("23.03.1984"),
                ShelfLife = DateTime.Parse("23.03.1986"),
                ArrivalPackages = 200,
                RestPackages = 100,
                QuantityPackage = 50,
                RemainedUnits = 5,
            };
            Medications.Add(m);

            m = new Medications
            {
                Id = 2,
                Name = "Глюкофаж",
                Description = "Таблетки белые, круглые, двояковыпуклые, покрытые пленочной оболочкой",
                ArrivalDate = DateTime.Parse("20.06.1987"),
                ShelfLife = DateTime.Parse("13.01.1989"),
                ArrivalPackages = 200,
                RestPackages = 100,
                QuantityPackage = 50,
                RemainedUnits = 5,
            };
            Medications.Add(m);

            m = new Medications
            {
                Id = 3,
                Name = "Пирацетам",
                Description = "Ноотропное средство. Оказывает положительное влияние на обменные процессы и кровообращение мозга.",
                ArrivalDate = DateTime.Parse("13.05.1987"),
                ShelfLife = DateTime.Parse("13.09.1989"),
                ArrivalPackages = 200,
                RestPackages = 100,
                QuantityPackage = 50,
                RemainedUnits = 5,
            };
            Medications.Add(m);
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
            Diagnoses.Add(d);

            d = new Diagnosis
            {
                Id = 2,
                Name = "Просту́да",
                Description = "Острая респираторная инфекция общей (невыясненной) этиологии" +
                " с воспалением верхних дыхательных путей, затрагивающая преимущественно нос." +
                " В воспаление могут быть также вовлечены горло, гортань и пазухи." +
                " Термин используется наряду с фарингитом, ларингитом, трахеитом и другими."
            };
            Diagnoses.Add(d);

            d = new Diagnosis
            {
                Id = 3,
                Name = "Диаре́я",
                Description = "Патологическое состояние, при котором у больного наблюдается учащённая" +
                " (более 3 раз в сутки) дефекация, при этом стул становится водянистым," +
                " имеет объём более 200 мл и часто сопровождается болевыми ощущениями в области живота," +
                " экстренными позывами и анальным недержанием"
            };
            Diagnoses.Add(d);
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
            Patients.Add(p);

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
            Patients.Add(p);

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
            Patients.Add(p);
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
            Hospitalizations.Add(h);

            h = new Hospitalization
            {
                Id = 2,
                StartHospitalizationDate = DateTime.Parse("03.05.2017"),
                EndHospitalizationDate = DateTime.Parse("17.05.2017"),
                PatientId = 1,
                MedicalOrganization = "Мед.уч. № 2",
                DefinitiveDiagnosis = "Оконч.диагноз 2",
            };
            Hospitalizations.Add(h);

            h = new Hospitalization
            {
                Id = 4,
                StartHospitalizationDate = DateTime.Parse("13.03.2018"),
                EndHospitalizationDate = DateTime.Parse("27.03.2018"),
                PatientId = 1,
                MedicalOrganization = "Мед.уч. № 100",
                DefinitiveDiagnosis = "Оконч.диагноз 1001",
            };
            Hospitalizations.Add(h);

            h = new Hospitalization
            {
                Id = 3,
                StartHospitalizationDate = DateTime.Parse("13.07.2017"),
                EndHospitalizationDate = DateTime.Parse("21.07.2017"),
                PatientId = 2,
                MedicalOrganization = "Мед.уч. № 1",
                DefinitiveDiagnosis = "Оконч.диагноз 1",
            };
            Hospitalizations.Add(h);
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
            Observations.Add(o);

            o = new Observation
            {
                Id = 2,
                StartObservationDate = DateTime.Parse("22.09.2016"),
                EndObservationDate = DateTime.Parse("12.10.2016"),
                PatientId = 1,
                DiagnosisId = 1,
                DoctorId = 3
            };
            Observations.Add(o);

            o = new Observation
            {
                Id = 4,
                StartObservationDate = DateTime.Parse("01.01.2017"),
                EndObservationDate = DateTime.Parse("13.01.2017"),
                PatientId = 1,
                DiagnosisId = 1,
                DoctorId = 1
            };
            Observations.Add(o);

            o = new Observation
            {
                Id = 5,
                StartObservationDate = DateTime.Parse("25.09.2018"),
                EndObservationDate = DateTime.Parse("07.10.2018"),
                PatientId = 1,
                DiagnosisId = 3,
                DoctorId = 2
            };
            Observations.Add(o);

            o = new Observation
            {
                Id = 3,
                StartObservationDate = DateTime.Parse("10.10.2007"),
                EndObservationDate = DateTime.Parse("12.10.2017"),
                PatientId = 3,
                DiagnosisId = 3,
                DoctorId = 1
            };
            Observations.Add(o);
        }
    }
}
