namespace VincesGarage.Models
{
    internal class Maintenance
    {
        public DateTime? Date { get; set; }
        public Vehicle Vehicle { get; set; }
        public string ServiceType { get; set; }
        public int Mileage { get; set; }
        public string Notes { get; set; }

    }
}
