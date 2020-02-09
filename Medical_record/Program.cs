using Medical_record.Abstractions;
using Medical_record.Data;
using Medical_record.Forms;
using Medical_record.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            IDataContext dataContext = new TestDataContext();
            var appController = new AppController(dataContext);
            //var mainForm = appController.GetMainForm();

            var vm = new RegistrationViewModel(appController);
            var form = new RegistrationView(vm);

            Application.Run(form);
        }
    }
}
