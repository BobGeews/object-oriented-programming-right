using System;

namespace Auto_olio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**AUTOTEHTÄVÄ**");
            Car bmw = new Car();
            Car audi = new Car();
            bmw.AskData();
            bmw.ShowInfo();
            Console.WriteLine("---------------------------------------------");
            bmw.AccelerateandBrake();
            Console.WriteLine("---------------------------------------------");
            audi.AskData();
            audi.ShowInfo();
            Console.WriteLine("---------------------------------------------");
            audi.AccelerateandBrake();
        }
    }
}
