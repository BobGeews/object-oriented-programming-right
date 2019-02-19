using System;

namespace TruckOlio
{
    class Program : Vehicle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**AUTOTEHTÄVÄ2**");
            
            Truck volvo = new Truck(200.0, 12);

            Car rekka = new Car("Sedan", "Audi", "2015", 20000, "2l","A4","5");
            rekka.PrintInfo();
            volvo.Printtruckinfo();
            volvo.CalculateConsumption();

        }
    }
}
