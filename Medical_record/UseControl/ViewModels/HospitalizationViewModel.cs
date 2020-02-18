using Medical_record.Abstractions;
using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medical_record.UseControl.ViewModels
{
    public class HospitalizationViewModel : IOutputUcViewModel
    {
        public event EventHandler NextClicked;
        public event EventHandler PreviousClicked;

        public BindingList<Hospitalization> Hospitalizations { get; private set; }
            = new BindingList<Hospitalization>();

        internal void SetHospitalizations(List<Hospitalization> hospitalizations)
        {
            Hospitalizations.Clear();
            hospitalizations.ForEach(o => Hospitalizations.Add(o));
        }

        public void ShowNext() => NextClicked?.Invoke(this, EventArgs.Empty);
        public void ShowPrevious() => PreviousClicked?.Invoke(this, EventArgs.Empty);
    }
}
