using System.Text.Json;
using VincesGarage.Extensions;
using VincesGarage.Models;


#region Vehicles

var vehicle1 = new Vehicle
{
    Id = 1,
    Year = 2017,
    Color = "Red",
    Make = "Chevy",
    Model = "Impala"
};


var vehicle2 = vehicle1;

var vehicle3 = new Vehicle
{
    Id = 3,
    Year = 2019,
    Color = "Blue",
    Make = "Kia",
    Model = "Sportage"
};


PrintVehicles(vehicle1, vehicle2);

vehicle1.Make = "Mercedez";

PrintVehicles(vehicle1, vehicle2);


PrintReference(vehicle1);
PrintReference(vehicle2);
PrintReference(vehicle3);

Console.ReadLine();

#endregion


#region Strings

string str1 = "string1";
string str2 = str1;
str2 = "string2";

Console.WriteLine($"{str1}, {str2}");

Console.ReadLine();

#endregion

#region Integers

int int1 = 1;
int int2 = int1;
int2 = 2;

Console.WriteLine($"{int1}, {int2}");

Console.ReadLine();

#endregion


#region Maintenance

//var maint = new Maintenance
//{
//    Date = DateTime.MaxValue,
//    Vehicle = vehicle1,
//    ServiceType = "Oil Change",
//    Mileage = 101_200
//};

//Console.WriteLine(JsonSerializer.Serialize(maint));

//var maint2 = new Maintenance
//{
//    Date = DateTime.Now,
//    Vehicle = new Vehicle
//    {
//        Year = 2016,
//        Make = "Honda",
//        Model = "Accord",
//        Color = "White"
//    },
//    ServiceType = "Air Filter Replacement",
//    Mileage = 159_108
//};

//Console.WriteLine(JsonSerializer.Serialize(maint2));


#endregion



static void PrintVehicles(Vehicle vehicle1, Vehicle copyVehicle)
{
    Console.WriteLine("vehicle1: " + JsonSerializer.Serialize(vehicle1));
    Console.WriteLine("copy vehicle: " + JsonSerializer.Serialize(copyVehicle));
    Console.ReadLine();
}

unsafe static void PrintReference(object obj)
{
    int* ptr = (int*)&obj;
    Console.WriteLine($"{obj.ToString()} reference = {(int)*ptr}");
}