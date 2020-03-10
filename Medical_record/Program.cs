using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Utils;
using System;
using System.Windows.Forms;

namespace Medical_record
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //тестовые данные
            IDataContext dataContext = new TestDataContext();
            //БД
            //IDataContext dataContext = new MsSqlDataContext();

            //сервис сообщений
            IMessageService messageService = new MessagesService();
            //контроллер приложения
            IAppController appController = new AppController(dataContext, messageService);
            //получаем гл.форму
            var mainForm = appController.GetMainForm();

            Application.Run(mainForm);
        }
    }
}
