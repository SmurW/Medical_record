using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.UseControl.ViewModels
{
    public class AddObservationViewModel
    {
        private readonly AppController _appController;

        public AddObservationViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public BindingList<Diagnosis> Diagnoses { get; set; } = new BindingList<Diagnosis>();
        public object SelectedDiagnosis { get; set; }


        public int Id { get; set; }
        public DateTime StartObservationDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndObservationDate { get; set; } = DateTime.Now;
        public int DiagnosisId { get; set; }
        public int DoctorId { get; set; }
        public string Count { get; set; }

        /// <summary>
        /// Получение экз. Наблюдения
        /// </summary>
        /// <returns></returns>
        internal Observation GetObservation()
        {
            return new Observation
            {
                StartObservationDate = StartObservationDate,
                EndObservationDate = EndObservationDate,
                DiagnosisId = (SelectedDiagnosis as Diagnosis).Id
            };
        }

        /// <summary>
        /// Сохранение наблюдения
        /// </summary>
        /// <returns></returns>
        internal async void SaveObservation()
        {

        }
    }
}
