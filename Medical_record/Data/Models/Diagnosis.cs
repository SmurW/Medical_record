using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_record.Data.Models
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
