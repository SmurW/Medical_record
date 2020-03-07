namespace Medical_record.Abstractions
{
    public interface IMessageService
    {
        void ShowInfoMessage(string message);
        void ShowErrorMessage(string message);
        bool GetAgree(string message);
    }
}
