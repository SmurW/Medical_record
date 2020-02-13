using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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

        public int Id { get; set; }
        public int SpecializationId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        /// <summary>
        /// Коллекция докторов
        /// </summary>
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();

        /// <summary>
        /// Коллекция специализации
        /// </summary>
        public BindingList<Specialization> Specializations { get; set; } = new BindingList<Specialization>();
        public object SelectedSpecializations { get; set; }

        private Doctor SetDoctors(Doctor doctor)
        {
            return new Doctor
            {
                Id = Id,
                LastName = LastName,
                FirstName = FirstName,
                MiddleName = MiddleName,
                SpecializationId = doctor.SpecializationId,
            };
        }

        internal async void SaveDoctors()
        {
            var result = new Result<string>("Error");
            var doctors = GetDoctors();
            if (Id == 0)
            {
                //запоминаем
                result = await _appController.DataContext.AddDoctorsAsync(doctors);
            }
            else
            {
                //обновляем
                result = await _appController.DataContext.UpdateDoctorsAsync(doctors);
            }

            if (result.HasValue)
            {
                MessagesService.ShowInfoMessage(result.Value);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

            private Doctor GetDoctors()
            {
                return new Doctor
                {
                    Id = Id,
                    LastName = LastName,
                    FirstName = FirstName,
                    MiddleName = MiddleName,
                    SpecializationId = SpecializationId,
                };
            }
        
    }
}
