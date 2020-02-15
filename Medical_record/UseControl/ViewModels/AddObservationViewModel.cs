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
        public AddObservationViewModel()
        { }

        /// <summary>
        /// Диагнозы
        /// </summary>
        public BindingList<Diagnosis> Diagnoses { get; set; } = new BindingList<Diagnosis>();

        /// <summary>
        /// Доктора
        /// </summary>
        public BindingList<Doctor> Doctors { get; set; } = new BindingList<Doctor>();

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
                DiagnosisId = DiagnosisId,
                DoctorId = DoctorId
            };
        }
    }
}
