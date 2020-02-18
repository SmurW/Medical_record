using Medical_record.Abstractions;
using Medical_record.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medical_record.UseControl.ViewModels
{
    public class ExaminationViewModel : IOutputUcViewModel
    {
        public event EventHandler NextClicked;
        public event EventHandler PreviousClicked;

        public BindingList<Examination> Examinations { get; private set; }
            = new BindingList<Examination>();

        internal void SetDiagnoses(List<Examination> exams)
        {
            Examinations.Clear();
            exams.ForEach(d => Examinations.Add(d));
        }

        public void ShowNext() => NextClicked?.Invoke(this, EventArgs.Empty);
        public void ShowPrevious() => PreviousClicked?.Invoke(this, EventArgs.Empty);
    }
}
