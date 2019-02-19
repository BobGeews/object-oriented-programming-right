using System;
using System.Collections.Generic;
using System.Text;

namespace TruckOlio
{
    class Truck : Car
    {
        public double cargoWeight;
        public int consumptionPerKilometer;

        public Truck()
        {
            this.cargoWeight = 0;
            this.consumptionPerKilometer = 0;
        }
        public Truck(double cargoWeight, int consumptionPerKilometer)
        {
            this.cargoWeight = cargoWeight;
            this.consumptionPerKilometer = consumptionPerKilometer;
        }
        public int CalculateConsumption()
        {
            Console.Write("Kuinka monta kilometriä ajetaan autolla?: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int total =  input *  this.consumptionPerKilometer / 100;
            Console.WriteLine($"Auto kuluttaa matkan aikana {total} litraa polttoainetta");
            return total;
        }
        public void Printtruckinfo()
        {
            Console.WriteLine($"Kuorman paino {this.cargoWeight} Kg");
            Console.WriteLine($"Kulutus {this.consumptionPerKilometer}L/100km ");
        }

            


    }
}
