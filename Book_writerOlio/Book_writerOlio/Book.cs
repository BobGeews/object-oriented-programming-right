using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjallisuus

{
    class Book
    {
        public string name;
        public string author;
        public string publisher;
        public double price;
        public string theme;

       
        public Book()
        {
            this.name = "";
            this.author = "";
            this.publisher = "";
            this.price = 0;
            
        }

        public Book(string name, string author, string publisher, double price, string theme)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
            
        }
       
        public void GetBook(string name)
        {
            if (this.name == name)
            {
                Console.WriteLine($"Nimi:{this.name}\n" +
                    $"Kirjailija: {this.author}\n" +
                    $"Kustantaja: {this.publisher}\n" +
                    $"Hinta: {this.price:C}\n" +
                    $"Teema: {theme}");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt.");
            }
        }

        public void SwitchTheme()
        {
            Console.Write($"Syötä uusi teema {this.name}:");
            theme = Console.ReadLine();
        }

        public double Price
        {
            get { return price; }

            set
            {
                if (price > 30)
                {
                    Console.WriteLine($"Uusi hinta on: {price * 0.9:C}");
                }

            }
        }
    }
}
