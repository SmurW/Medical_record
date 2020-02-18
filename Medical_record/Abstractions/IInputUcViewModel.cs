using System;

namespace Medical_record.Abstractions
{
    /// <summary>
    /// Интерфейс вьюмоделей принимающих записи
    /// о Наблюдениях, Осмотрах, Госпитализации в Карточке пациента
    /// </summary>
    public interface IInputUcViewModel
    {
        event EventHandler ButtonSaveClicked;
        string Tag { get; }
    }
}
