using Medical_record.Data.Models;
using Medical_record.Utils;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class DoctorsViewModel
    {
        private readonly AppController _appController;

        public DoctorsViewModel(AppController appController)
        {
            _appController = appController;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        /// <summary>
        /// Коллекция докторов
        /// </summary>
        public BindingList<Doctor> Doctors { get; set; } = new BindingList<Doctor>();

        /// <summary>
        /// Коллекция специализации
        /// </summary>
        public BindingList<Specialization> Specializations { get; set; } = new BindingList<Specialization>();

        /// <summary>
        /// Сохранение Доктора
        /// </summary>
        /// <param name="specObj"></param>
        internal async void SaveDoctor(object specObj)
        {
            var result = new Result<string>("Error");
            var doctor = GetDoctor((specObj as Specialization).Id);
            //запоминаем
            result = await _appController.DataContext.Doctors.AddDoctorAsync(doctor);

            if (result.HasValue)
            {
                _appController.MessageService.ShowInfoMessage(result.Value);
                await LoadDataAsync();
            }
            else
            {
                _appController.MessageService.ShowErrorMessage(result.Error);
            }
        }

        /// <summary>
        /// Загрузка Докторов и Специализаций
        /// </summary>
        /// <returns></returns>
        internal async Task LoadDataAsync()
        {
            //доктора
            Doctors.Clear();
            var doctors = await _appController.DataContext.Doctors.GetDoctorsAsync();
            if (doctors.HasValue)
            {
                int num = 0;
                doctors.Value.ForEach(d =>
                {
                    d.OrderNumber = ++num;
                    Doctors.Add(d);
                });
            }

            //специализации
            var specs = await _appController.DataContext.Specializations.GetSpecializationsAsync();
            if (specs.HasValue)
            {
                Specializations.Clear();
                specs.Value.ForEach(s => Specializations.Add(s));
            }
        }

        /// <summary>
        /// Получение Доктора из текущ.значений
        /// </summary>
        /// <param name="specId">Id специализации доктора</param>
        /// <returns></returns>
        private Doctor GetDoctor(int specId)
        {
            return new Doctor
            {
                LastName = LastName,
                FirstName = FirstName,
                MiddleName = MiddleName,
                SpecializationId = specId,
            };
        }

    }
}
