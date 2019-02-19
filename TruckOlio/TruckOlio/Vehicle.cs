using System;
using System.Collections.Generic;
using System.Text;

namespace TruckOlio
{
   abstract class Vehicle
    {
        protected string sedan;
        protected string brand;
        protected string year;
        protected double price;

         public Vehicle()
        {
            this.sedan = "";
            this.brand = "";
            this.year = "";
            this.price = 0.0;
        }
        public Vehicle(string sedan,string brand,string year,double price)
        {
            this.sedan = sedan;
            this.brand = brand;
            this.year = year;
            this.price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Muoto: {this.sedan}");
            Console.WriteLine($"Merkki: {this.brand}");
            Console.WriteLine($"Valmistusvuosi: {this.year}");
            Console.WriteLine($"Hinta: {this.price}");

        }

    }
}
