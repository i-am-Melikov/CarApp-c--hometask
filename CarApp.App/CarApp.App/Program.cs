using CarApp.App.Services.Implementations;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Schema;
using CarApp.Core.Models.BaseModels;
CarServices carServices = new CarServices();

Console.WriteLine("0.Close App");
Console.WriteLine("1.Create Car");
Console.WriteLine("2.Show All Cars");

string Request = Console.ReadLine();

while (Request != "0")
{
    switch (Request)
    {
        case "1":
            carServices.CreateCar();
            break;
        case "2":
            carServices.ShowAllInfo();
            break;
        default:
            Console.WriteLine("Please select valid option ");
            break;
    }
    Console.WriteLine("0.Close App");
    Console.WriteLine("1.Create Car");
    Console.WriteLine("2.Show All Cars");

    Request = Console.ReadLine();
}
