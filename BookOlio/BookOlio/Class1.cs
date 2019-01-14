using System;
using System.Collections.Generic;
using System.Text;

namespace BookOlio
{
    class Book
    {
        public string title;
        public string author;
        public string idNum;
        public int price;

        public Book(string title, string author, string idNum, int price)
        {
            this.title = title;
            this.author = author;
            this.idNum = idNum;
            this.price = price;
            
        }
        public void PrintThings()
        {
            Console.WriteLine($"Kirjan nimi: {this.title}");
            Console.WriteLine($"Kirjoittaja: {this.author}");
            Console.WriteLine($"ID: {this.idNum}");
            Console.WriteLine($"Hinta: {this.price}e");
        }
        public string CompareBook(Book book)
        {
            string text = "";

            if (this.price > book.price)
            {
                text = $"{this.title} on kalliimpi kuin {book.title} kirja";
            }
            else
            {
                text = $"{book.title} on kalliimpi kuin {this.title} kirja";
            }
            return text;

        }
       
    }
}
