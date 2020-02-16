using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data.Models
{
   public class DoctorsNotes
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime DateInspection { get; set; } = DateTime.Now;
        public string DiagnisisDisease { get; set; }
        public string HealtGroup { get; set; }
        public int DoctorId { get; set; }
    }
}
