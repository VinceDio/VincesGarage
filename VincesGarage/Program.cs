using System.Text.Json;
using VincesGarage.Extensions;
using VincesGarage.Models;



var vehicle1 = new Vehicle(year: 2016, make: "Ford", model: "Taurus");

vehicle1.Id = 1;
vehicle1.Color = "Blue";

var vehicle2 = new Vehicle
{
    Id = 2,
    Year = 2017,
    Color = "Red",
    Make = "Chevy",
    Model = "Impala"
};

var maint = new Maintenance
{
    Date = DateTime.MaxValue,
    Vehicle = vehicle1,
    ServiceType = "Oil Change",
    Mileage = 101_200
};

Console.WriteLine(JsonSerializer.Serialize(maint));

var maint2 = new Maintenance
{
    Date = DateTime.Now,
    Vehicle = new Vehicle
    {
        Year = 2016,
        Make = "Honda",
        Model = "Accord",
        Color = "White"
    },
    ServiceType = "Air Filter Replacement",
    Mileage = 159_108
};

Console.WriteLine(JsonSerializer.Serialize(maint2));
