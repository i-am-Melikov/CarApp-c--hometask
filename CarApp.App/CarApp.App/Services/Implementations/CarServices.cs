using CarApp.App.Services.Interfaces;
using CarApp.Core.Models.BaseModels;
using CarApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Security.Cryptography;

namespace CarApp.App.Services.Implementations
{
    internal class CarServices : ICarServices
    {
        private Car[] cars = { };
        public void CreateCar()
        {
            
            Car car = new Car();
            Console.WriteLine("Add Model");
            car.Model=Console.ReadLine();
            Console.WriteLine("Add Km");
            car.Km=double.Parse(Console.ReadLine());
            Console.WriteLine("Add TopSpeed");
            car.TopSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Add Engine");
            car.Engine = double.Parse(Console.ReadLine());
            Console.WriteLine("Add Hp");
            car.Hp = int.Parse(Console.ReadLine());
            Array.Resize(ref cars, cars.Length+1);
            cars[cars.Length-1] = car;

            
        }

        public void ShowAllInfo()
        {
            if (cars.Length != 0)
            {
                foreach (Car car in cars)
                    Console.WriteLine($"Model:" + car.Model + "     Km:" + car.Km + "     TopSpeed:" + car.TopSpeed + "     Engine:" + car.Engine + "       Hp:" + car.Hp);

            }
            else
            {
                Console.WriteLine("There is no any car");
            }
        }
    }
}

