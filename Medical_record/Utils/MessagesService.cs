using Medical_record.Abstractions;
using System.Windows.Forms;

namespace Medical_record.Utils
{
    public class MessagesService : IMessageService
    {
        public void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool GetAgree(string message)
        {
            var result = MessageBox.Show(message, "Вопрос",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
