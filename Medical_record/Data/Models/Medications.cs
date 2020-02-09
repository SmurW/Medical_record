using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data.Models
{
   public class Medications
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public DateTime ArrivalDate { get; set; } = DateTime.Now;
        public string ArrivalPackages { get; set; }
        public DateTime ShelfLife { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public int QuantityPackage { get; set; }
        public int RestPackages { get; set; }
        public string RemainedUnits { get; set; }
    }
}
