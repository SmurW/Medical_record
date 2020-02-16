using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.UseControl.ViewModels
{
    public class AddHospitalizationViewModel
    {
        public AddHospitalizationViewModel()
        { }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime StartHospitalizationDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndHospitalizationDate { get; set; } = DateTime.Now;
        public string MedicalOrganization { get; set; }
        public string DefinitiveDiagnosis { get; set; }
        public string Count { get; set; }

        /// <summary>
        /// Получение экз.госпитализации
        /// </summary>
        /// <returns></returns>
        internal Hospitalization GetHospitalization()
        {
            return new Hospitalization
            {
                StartHospitalizationDate = StartHospitalizationDate,
                EndHospitalizationDate = EndHospitalizationDate,
                MedicalOrganization = MedicalOrganization,
                DefinitiveDiagnosis = DefinitiveDiagnosis,
            };
        }
    }
}
