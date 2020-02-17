using System;

namespace Medical_record.Abstractions
{
    public interface IUcViewModel
    {
        event EventHandler NextClicked;
        event EventHandler PreviousClicked;

        void ShowNext();
        void ShowPrevious();
    }
}