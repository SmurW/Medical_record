using System;

namespace Medical_record.Abstractions
{

    /// <summary>
    /// Интерфейс вьюмоделей отображающих записи
    /// о Наблюдениях, Осмотрах, Госпитализации в Карточке пациента
    /// </summary>
    public interface IUcViewModel
    {
        event EventHandler NextClicked;
        event EventHandler PreviousClicked;

        void ShowNext();
        void ShowPrevious();
    }
}