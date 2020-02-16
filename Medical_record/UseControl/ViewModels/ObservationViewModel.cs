using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.UseControl.ViewModels
{
    public class ObservationViewModel
    {
        public BindingList<Observation> Observations { get; private set; } = new BindingList<Observation>();

        internal void SetObservations(List<Observation> observations)
        {
            Observations.Clear();
            observations.ForEach(o => Observations.Add(o));
        }
    }
}
