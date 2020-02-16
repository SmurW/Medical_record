using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.UseControl.ViewModels
{
    public class ExaminationViewModel
    {
        public ExaminationViewModel()
        { }

        public BindingList<Diagnosis> Diagnoses { get; set; } = new BindingList<Diagnosis>();
        public object SelectedDiagnosis { get; set; }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime DateInspection { get; set; } = DateTime.Now;
        public string DiagnisisDisease { get; set; }
        public string HealtGroup { get; set; }
        public int DiagnosisId { get; set; }
        public int DoctorId { get; set; }
        public string Count { get; set; }

    }
}
