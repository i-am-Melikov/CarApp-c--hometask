using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Core.Models.BaseModels
{
    public class Car
    {
        private string _model { get; set; }
        private double _km { get; set; }
        private int _topspeed { get; set; }
        private double _engine { get; set; }
        private int _hp { get; set; }


        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length != 0 || value.Length <= 10)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Please add valid model");
                    return;
                    
                }
            }
        }
        public double Km
        {
            get
            {
                return _km;
            }
            set
            {
                if (value >= 0)
                {
                    _km = value;
                }
                else
                {
                    Console.WriteLine("Please add valid km");
                    Km = double.Parse(Console.ReadLine());
                    return;
                }
            }
        }
        public int TopSpeed
        {
            get
            {
                return _topspeed;
            }
            set
            {
                if (value >= 10 && value <= 1000)
                {
                    _topspeed = value;
                }
                else
                {
                    Console.WriteLine("Please add valid topspeed");
                    TopSpeed = int.Parse(Console.ReadLine());
                    return;
                }
            }
        }
        public double Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                if (value >= 0.3 && value <= 10)
                {
                    _engine = value;
                }
                else
                {
                    Console.WriteLine("Please add valid engine");
                    Engine = double.Parse(Console.ReadLine());
                    return;
                }
            }
        }
        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value >= 50 && value <= 1000)
                {
                    _hp = value;
                }
                else
                {
                    Console.WriteLine("Please add valid hp");
                    Hp = int.Parse(Console.ReadLine());
                    return;
                }
            }
        }
    }
}

