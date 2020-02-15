using Medical_record.Data.Models;
using Medical_record.UseControl.ViewModels;
using Medical_record.Utils;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_record.ViewModels
{
    public class RegistrationViewModel
    {
        private readonly AppController _appController;
        private AddExaminationViewModel _examinationVM;
        private AddHospitalizationViewModel _hospitalizationVM;
        private AddObservationViewModel _observationVM;

        public RegistrationViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public string Residence { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportUFMS { get; set; }
        public DateTime PassportIssueDate { get; set; } = DateTime.Now;
        public string PassportDepCode { get; set; }


        /// <summary>
        /// Сохранение в БД пацента
        /// </summary>
        internal async void SavePatient()
        {
            var result = new Result<string>("Error");
            Patient patient = GetPatient();
            if (Id == 0)
            {
                //запоминаем нового
                result = await _appController.DataContext.AddPatientAsync(patient);
            }
            else
            {
                //обновляем уже существующего
                result = await _appController.DataContext.UpdatePatientAsync(patient);
            }

            if (!result.HasValue)
            {
                MessagesService.ShowErrorMessage(result.Error);
                return;
            }

            if (Id == 0)
            {
                //получаем Id пациента
                var resultId = await _appController.DataContext.GetLastAddedPatientIdAsync();
                if (resultId.HasValue)
                {
                    Id = resultId.Value;
                }
                else
                {
                    MessagesService.ShowErrorMessage(resultId.Error);
                    return;
                }
            }
            MessagesService.ShowInfoMessage(result.Value);

            // проверка открытых VM, сохранение данных
            if (_observationVM != null)
            {
                await SaveObservationAsync();
            }

            if (_hospitalizationVM != null)
            {
                await SaveHospitalizationAsync();
            }

            if (_examinationVM != null)
            {
                await SaveExaminationAsync();
            }
        }


        /// <summary>
        /// Сохранение наблюдения
        /// </summary>
        /// <returns></returns>
        private async Task SaveObservationAsync()
        {
            //получаем экз. наблюдения
            var ob = _observationVM.GetObservation();
            //присваиваем Id текущего пациента
            ob.PatientId = Id;
            //сохраняем в БД
            var result = await _appController.DataContext.AddObservationAsync(ob);
            if (!result.HasValue)
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Сохранение госпитализации
        /// </summary>
        /// <returns></returns>
        private async Task SaveHospitalizationAsync()
        {
            var hosp = _hospitalizationVM.GetHospitalization();
            hosp.PatientId = Id;
            Result<string> result = await _appController.DataContext.AddHospitalizationAsync(hosp);
            if (!result.HasValue)
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
            
        }

        /// <summary>
        /// Сохранение записи врачей
        /// </summary>
        /// <returns></returns>
        private Task SaveExaminationAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получение экземпляра Patient из
        /// свойств этой вьюмодели и отображенной uc
        /// </summary>
        /// <returns></returns>
        private Patient GetPatient()
        {
            var result = new Patient
            {
                Id = Id,
                CardNumber = CardNumber,
                FirstName = FirstName,
                LastName = LastName,
                MiddleName = MiddleName,
                Birthdate = Birthdate,
                PassportDepCode = PassportDepCode,
                PassportIssueDate = PassportIssueDate,
                PassportNumber = PassportNumber,
                PassportSeries = PassportSeries,
                PassportUFMS = PassportUFMS,
                RegistrationDate = RegistrationDate,
                Residence = Residence,
                Sex = Sex
            };
            return result;
        }

        /// <summary>
        /// Извлечение из Patient значений свойств для этой вьюмодели
        /// </summary>
        /// <param name="patient"></param>
        internal void SetPatient(Patient patient)
        {
            Id = patient.Id;
            CardNumber = patient.CardNumber;
            FirstName = patient.FirstName;
            LastName = patient.LastName;
            MiddleName = patient.MiddleName;
            Sex = patient.Sex;
            Birthdate = patient.Birthdate;
            RegistrationDate = patient.RegistrationDate;
            Residence = patient.Residence;
            PassportNumber = patient.PassportNumber;
            PassportSeries = patient.PassportSeries;
            PassportUFMS = patient.PassportUFMS;
            PassportDepCode = patient.PassportDepCode;
            PassportIssueDate = patient.PassportIssueDate;
        }

        /// <summary>
        /// Получение запрашиваемой uc для отображения
        /// </summary>
        /// <param name="key">ключ (см. AppController) связанный с uc</param>
        /// <returns></returns>
        internal async Task<UserControl> GetUcView(string key)
        {
            //получаем экземпляр
            dynamic uc = _appController.GetUcView(key);
            switch (key)
            {
                case "Ob":
                    if (_observationVM == null)
                    {
                        _observationVM = uc.ViewModel;
                        await SetupObservationUc(); 
                    }
                    break;
                case "Ex":
                    if (_examinationVM == null)
                    {
                        _examinationVM = uc.ViewModel;
                        await SetupExaminationUc(); 
                    }
                    break;
                case "Ho":
                    if (_hospitalizationVM == null)
                    {
                        _hospitalizationVM = uc.ViewModel;
                        await SetupHospitalizationUc(); 
                    }
                    break;
                default:
                    throw new ArgumentException(nameof(key));
            }
            
            return uc as UserControl;
        }

        /// <summary>
        /// Подгрузка данных в AddObservationViewModel
        /// </summary>
        /// <returns></returns>
        private async Task SetupObservationUc()
        {
            //Получаем количество наблюдений для текущего пациента
            if (Id == 0)
            {
                //пациент еще не сохранен в БД
                _observationVM.Count = "1";
            }
            else
            {
                var count = await _appController.DataContext.GetCountObservationsByPatientIdAsync(Id);
                if (count.HasValue)
                {
                    _observationVM.Count = $"{count.Value + 1}";
                }
            }

            //Получаем диагнозы
            var diags = await _appController.DataContext.GetDiagnosesAsync();
            if (diags.HasValue)
            {
                _observationVM.Diagnoses.Clear();
                diags.Value.ForEach(d => _observationVM.Diagnoses.Add(d));
            }

            //Получаем докторов
            var docs = await _appController.DataContext.GetDoctorsAsync();
            if (docs.HasValue)
            {
                _observationVM.Doctors.Clear();
                docs.Value.ForEach(d => _observationVM.Doctors.Add(d));
            }
        }

        /// <summary>
        /// Подгрузка данных в AddExaminationViewModel
        /// </summary>
        /// <returns></returns>
        private Task SetupExaminationUc()
        {
            if (Id == 0)
            {
                _examinationVM.Count = "1";
            }
            else
            {

            }

            return Task.FromResult(0);
        }

        /// <summary>
        /// Подгрузка данных в AddHospitalizationViewModel
        /// </summary>
        /// <returns></returns>
        private async Task SetupHospitalizationUc()
        {
            //Получаем количество наблюдений для текущего пациента
            if (Id == 0)
            {
                //пациент еще не сохранен в БД
                _hospitalizationVM.Count = "1";
            }
            else
            {
                var count = await _appController.DataContext
                    .GetCountHospitalizationsByPatientIdAsync(Id);
                if (count.HasValue)
                {
                    _hospitalizationVM.Count = $"{count.Value + 1}";
                }
            }
        }
    }
}
