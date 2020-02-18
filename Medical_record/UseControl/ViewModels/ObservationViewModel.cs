using Medical_record.Abstractions;
using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medical_record.UseControl.ViewModels
{
    public class ObservationViewModel : IOutputUcViewModel
    {
        public event EventHandler NextClicked;
        public event EventHandler PreviousClicked;

        public BindingList<Observation> Observations { get; private set; }
            = new BindingList<Observation>();

        internal void SetObservations(List<Observation> observations)
        {
            Observations.Clear();
            observations.ForEach(o => Observations.Add(o));
        }

        public void ShowNext() => NextClicked?.Invoke(this, EventArgs.Empty);
        public void ShowPrevious() => PreviousClicked?.Invoke(this, EventArgs.Empty);
    }
}
