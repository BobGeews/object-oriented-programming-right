using System;
using System.Collections.Generic;
using System.Text;

namespace Tuoterekisteri
{
    class Products
    {
        public string name { get; set; }
        public string id {get; set;}
        public string groupName { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public string comment { get; set; }
        

        public Products()
        {
            this.name = "";
            this.id = "";
            this.groupName = "";
            this.price = 0.0;
            this.amount = 0;
            this.comment = "";
        }
        public void Writeinfo()
        {

            Console.WriteLine($"Tuotteen nimi: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Kategoria: {groupName}");
            Console.WriteLine($"Hinta: {price}");
            Console.WriteLine($"Määrä: {amount}");
            Console.WriteLine($"Kommentti: {comment}");
            Console.WriteLine("------------------");
        }
        public Object AskId(string comparedId)
        {
            Console.Write("Anna tuote id");
            comparedId = Console.ReadLine();
            if (this.id == comparedId)
            {
                return this;
            }
            else
            {
                return null;
            }
           

        }
        
        public override string ToString()
        {
            return $"Asiakas: {this.name},{this.id},{this.price}";
        }
    }
}
