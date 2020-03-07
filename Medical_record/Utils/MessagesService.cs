using System;
using System.Windows.Forms;

namespace Medical_record.Utils
{
    static class MessagesService
    {
        internal static void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static bool GetAgree(string message)
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
