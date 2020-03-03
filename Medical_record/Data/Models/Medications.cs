using System;

namespace Medical_record.Data.Models
{
    public class Medications
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ArrivalDate { get; set; } = DateTime.Now;
        public DateTime ShelfLife { get; set; } = DateTime.Now;
        public int QuantityPackage { get; set; }
        public int RestPackages { get; set; }
        public int ArrivalPackages { get; set; }
        public int RemainedUnits { get; set; }
    }
}
