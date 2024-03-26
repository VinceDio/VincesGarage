using System.Text.Json;
using VincesGarage.Models;

var vehicle1 = new Vehicle
{
    Id = 1,
    Year = 2016,
    Make = "Ford",
    Model = "Taurus",
    Color = "Blue"
};

var vehicle2 = new Vehicle
{
    Id = 2,
    Year = 2017,
    Make = "Kia",
    Model = "Sportage",
    Color = "Silver"
};

var maint = new Maintenance
{
    Date = DateTime.Now,
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
