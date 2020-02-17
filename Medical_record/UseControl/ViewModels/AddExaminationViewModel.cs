using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.UseControl.ViewModels
{
    public class AddExaminationViewModel
    {
        public AddExaminationViewModel()
        { }

        /// <summary>
        /// Диагнозы
        /// </summary>
        public BindingList<Diagnosis> Diagnoses { get; set; } = new BindingList<Diagnosis>();

        /// <summary>
        /// Доктора
        /// </summary>
        public BindingList<Doctor> Doctors { get; set; } = new BindingList<Doctor>();

        /// <summary>
        /// Группы здоровья
        /// </summary>
        public BindingList<HealthGroup> HealthGroups { get; set; } = new BindingList<HealthGroup>();

        public DateTime ExaminationDate { get; set; } = DateTime.Now;
        public int DiagnosisId { get; set; }
        public int HealthGroupId { get; set; }
        public int DoctorId { get; set; }
        public string Count { get; set; }

        internal Examination GetExamination()
        {
            return new Examination
            {
                ExaminationDate = ExaminationDate,
                DiagnosisId = DiagnosisId,
                HealthGroupId = HealthGroupId,
                DoctorId = DoctorId,
            };
        }
    }
}
