using Medical_record.Data.Models;
using Medical_record.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.ViewModels
{
    public class AddProceduresViewModel
    {
        private readonly AppController _appController;

        public AddProceduresViewModel(AppController appController)
        {
            _appController = appController ??
                throw new ArgumentNullException(nameof(appController));
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        internal void SetPrcedure(Procedure procedure)
        {
            Id = procedure.Id;
            Name = procedure.Name;
            Description = procedure.Description;
        }

        internal async void SaveProcedure()
        {
            var result = new Result<string>("Error");
            Procedure proc = GetProcedure();
            if (Id == 0)
            {
                //запоминаем
                result = await _appController.DataContext.AddProcedureAsync(proc);
            }
            else
            {
                //обновляем
                result = await _appController.DataContext.UpdateProcedureAsync(proc);
            }

            if (result.HasValue)
            {
                MessagesService.ShowInfoMessage(result.Value);
            }
            else
            {
                MessagesService.ShowErrorMessage(result.Error);
            }
        }

        private Procedure GetProcedure()
        {
            return new Procedure
            {
                Id = Id,
                Name = Name,
                Description = Description,
            };
        }
    }
}
