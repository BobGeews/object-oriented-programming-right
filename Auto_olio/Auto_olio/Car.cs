using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_olio
{
    class Car
    {
        
        public string brand;
        public double speed;

        public Car()
        {
            this.speed = speed;
            this.brand = brand;
            
        }
        public void AskData()
        {
            Console.WriteLine("Minkä merkkinen auto on?");
            this.brand = Console.ReadLine();
            Console.WriteLine($"Kuinka kovaa {this.brand} ajaa?");
            this.speed =Convert.ToInt32 (Console.ReadLine());
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Auton merkki on {this.brand} ja se ajaa nopeutta {this.speed}km/h");
        }
        public void AccelerateandBrake()
        {
            Console.WriteLine("Jos haluat lisätä auton nopeutta 10% paina [K]. Jos haluat hidastaa auton nopeutta 10% paina [E].");
            Console.Write(":");
           string userInput = Console.ReadLine();
            if (userInput == "e")
            {
                this.speed = this.speed * 0.9;
                Console.WriteLine($"{this.brand} hidastettu nopeus on {this.speed} km/h");
            }
            if (userInput== "k")
            {
                this.speed = this.speed * 1.1;
                Console.WriteLine($"{this.brand} kiihdytetty nopeus on {this.speed}km/h");
            }
            

        }
        
    
        




        
    }
}
