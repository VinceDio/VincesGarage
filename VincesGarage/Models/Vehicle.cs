using Microsoft.VisualBasic;

namespace VincesGarage.Models
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(int id)
        {
            Id = id;
        }

        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
    }
}
