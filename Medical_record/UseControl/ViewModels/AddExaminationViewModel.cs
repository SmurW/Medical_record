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

        public DateTime ExaminationDate { get; set; } = DateTime.Now;

        public string Count { get; set; }
    }
}
