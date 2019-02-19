using System;
using System.Collections.Generic;
using System.Text;

namespace rajapintateht
{
    class Store : IProducts, ICustomer
    {
        public string name;
        public double revenue;
        List<Product> pList;
        List<customer> cList;

        public Store()
        {
            this.name = "";
            this.revenue = 0;
          pList = new List<Product>();
            cList = new List<customer>();
        }
        public Store(string name,double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }
        public void AddProduct(Product product)
        {
            pList.Add(product);
        }
        public void AddCustomer(customer customer)
        {
            cList.Add(customer);
        }
        public override string ToString()
        {
            return $"Nimi {this.name}\n Liikevaihto: {this.revenue}\n Asiakkaiden määrä:{cList.Count}\n Tuotteiden määrä: {pList.Count}";

        }
        public void PrintProducts()
        {
            Console.WriteLine($"Tuotteiden määrä kaupassa:{pList.Count}\n Tuotteet ovat:");
            foreach (Product product in pList)
            {
                Console.WriteLine($"{product.ToString()}");
            }
        }
        public void CalculateTotal()
        {
            double totalValue = 0;
            foreach (Product product in pList)
            {
                totalValue = product.amount * product.unitprice;
                totalValue++;
            }
            Console.WriteLine($"Tuotteitten yhteisarvo on {totalValue}");
        }
        public void PrintCustomers()
        {
            Console.WriteLine($"Kaupan jäsen määrä:{cList.Count}\n Jäsenet ovat:");
            foreach(customer customer in cList)
            {
                Console.WriteLine($"{customer.ToString()}");
            }
        }
        public void GetBonus()
        {
            double bonus = 0;
            foreach (customer customer in cList)
            {
                if (customer.items <1000)
                {
                    bonus = customer.items * 0.02;
                }
                else if (customer.items >= 1000 && customer.items >= 2000)
                {
                    bonus = customer.items * 0.03;
                }
                else
                {
                    bonus = customer.items * 0.05;
                }
                Console.WriteLine($"{customer.customerName} saa {bonus} verran´bonuksia");
            }
                
        }


    }
}
