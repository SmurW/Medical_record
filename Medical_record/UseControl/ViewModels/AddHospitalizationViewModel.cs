using Medical_record.Abstractions;
using Medical_record.Data.Models;
using System;

namespace Medical_record.UseControl.ViewModels
{
    public class AddHospitalizationViewModel : IInputUcViewModel
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime StartHospitalizationDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndHospitalizationDate { get; set; } = DateTime.Now;
        public string MedicalOrganization { get; set; }
        public string DefinitiveDiagnosis { get; set; }
        public string Count { get; set; }

        //реализация интерфейса
        public event EventHandler ButtonSaveClicked;
        public string Tag => "Ho";

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

        /// <summary>
        /// Сохранение сведений о госпитализации
        /// </summary>
        /// <returns></returns>
        internal void SaveHospitalization() => ButtonSaveClicked?.Invoke(this, EventArgs.Empty);

    }
}
