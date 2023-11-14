namespace TravelPackages4.Models
{
    public class PackageModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; }
        public int NoOfDays { get; set; }
        public int NoOfPersons { get; set;}
        public string ArrivalCity { get; set; } = string.Empty;
        public string DestinationCity { get; set;} = string.Empty;
    }
}
