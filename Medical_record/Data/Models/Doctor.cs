namespace Medical_record.Data.Models
{
   public class Doctor
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SpecAndFio => $"{SpecializationName}: {LastName} {FirstName.Substring(0, 1)}.{MiddleName.Substring(0, 1)}.";
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public string SpecializationName => Specialization?.Name;
    }
}
