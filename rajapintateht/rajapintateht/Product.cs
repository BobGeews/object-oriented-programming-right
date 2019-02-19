using System;
using System.Collections.Generic;
using System.Text;

namespace rajapintateht
{
    class Product: Iproduct
    {
        public string name;
        public double unitprice;
        public int amount;


        public Product()
        {
            this.name = "";
            this.unitprice = 0.0;
            this.amount = 0;

        }
        public Product(string name, double unitprice, int amount)
        {
            this.name = name;
            this.unitprice = unitprice;
            this.amount = amount;
        }
        public override string ToString()
        {
            return $"Tuote: {this.name}\n Hinta: {this.unitprice}\n Määrä: {this.amount}";
        }
        public Object GetProduct(string comparedName)
        {
            if (name == comparedName)
            {
                return this;
            }
            else
            {
                return null;

            }


        }


        
        public double CalculateTotal()
        {
            double totalPrice = this.unitprice * this.amount;
            Console.WriteLine($"Tuotteen kokonaishinta: {totalPrice}"); 
            return totalPrice;
        }
        public void PrintInfo()
        {

            Console.WriteLine($"Tuotteen nimi: {this.name}");
            Console.WriteLine($"Tuotteen kappalehinta: {this.unitprice}");
            Console.WriteLine($"Tuotteen määrä: {this.amount}");
        }
        
    }
}
