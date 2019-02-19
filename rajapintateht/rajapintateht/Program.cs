using System;
using System.Collections.Generic;

namespace rajapintateht
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product("Vasara", 5.50, 3);
            Product b = new Product("Kirves", 10.99, 2);
            Product c = new Product("Naula", 1.00, 10);
            Store rautia = new Store();

            List<Product> prodlist = new List<Product>();
            {

                prodlist.Add(a);
                prodlist.Add(b);
                prodlist.Add(c);
            }  
            
            foreach(Product p in prodlist)
            {
                if (p.GetProduct("Vasara") != null)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine("------------------------");
            foreach (Product p in prodlist)
            {
                Console.WriteLine($"{p.CalculateTotal()}");
            }
            customer d = new customer("Jani", 5000);
            customer e = new customer("Virpi", 500);
            customer f = new customer("Timo", 40000);
            
            List<customer> custlist = new List<customer>();
            {
                custlist.Add(d);
                custlist.Add(e);
                custlist.Add(f);
                
            }
            Console.WriteLine("--------------------------");
            foreach(customer i in custlist)
            {
                
                if (i.GetCustomer("Jani")!= null)
                {
                    Console.WriteLine( i.ToString());
                }
            }
            foreach (customer i in custlist)
            {
                Console.WriteLine($"{i.GetBonus()}");
            }
            rautia.AddProduct(a);
            rautia.AddProduct(b);
            rautia.AddProduct(c);
            rautia.AddCustomer(d);
            rautia.AddCustomer(e);
            rautia.AddCustomer(f);
            rautia.PrintCustomers();

            Console.WriteLine("-------------------------------");
            rautia.PrintProducts();
            Console.WriteLine("---------------");

            rautia.CalculateTotal();
            Console.WriteLine("------------------------");
            rautia.GetBonus();
            Console.WriteLine("----------------------------");

            

        }
    }
}
