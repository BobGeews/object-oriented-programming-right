using System;
using System.Collections.Generic;
using System.Text;

namespace TruckOlio
{
    class Car: Vehicle
    {
        protected string engineSize;
        protected string model;
        protected string doors;

        public Car()
        {
            this.engineSize = "";
            this.model = "";
            this.doors = "";
        }
        public Car (string sedan, string brand, string year, double price, string engineSize, string model, string doors):
            base(sedan,brand,year,price)
        {
            this.engineSize = engineSize;
            this.model = model;
            this.doors = doors;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Koneen koko: {this.engineSize}");
            Console.WriteLine($"Malli: {this.model}");
            Console.WriteLine($"Ovien lukumäärä: {this.doors}");
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;
            if (carObj==null)
            {
                return false;
            }
            else
            {
                return this.brand.Equals(carObj.brand);
            }
            
        }
    }
}
