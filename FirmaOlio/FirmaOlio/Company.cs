using System;
using System.Collections.Generic;
using System.Text;

namespace FirmaOlio
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public int outcome;
        public int expense;

        public Company()
        {
            this.title = null;
            this.address = null;
            this.phone = null;
            this.outcome = 0;
            this.expense = 0;
        }
        public Company(string title,string address,string phone,int outcome,int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }
        public void Printinfo()
        {
            Console.WriteLine($"Yritys: {this.title}");
            Console.WriteLine($"Osoite: {this.address}");
            Console.WriteLine($"Puhelinnumero: {this.phone}");
            Console.WriteLine($"Tulot: {this.outcome}");
            Console.WriteLine($"Menot: {this.expense}");
        }
        public Company(Company anotherCompany)
        {
            title = anotherCompany.title;
            address = anotherCompany.address;
            phone = anotherCompany.phone;
            outcome = anotherCompany.outcome;
            expense = anotherCompany.expense;
        }
        public void Record()
        {
            double profitMarg;
            profitMarg = outcome - expense;
            profitMarg = profitMarg / expense;
            profitMarg = Math.Round( profitMarg * 100);
            Console.WriteLine($"Voitto prosentti on {profitMarg}%");

            if (profitMarg<100)
            {
                Console.WriteLine("Tulos on kehno");
            }
            if (profitMarg>=100 && profitMarg< 200)
            {
                Console.WriteLine("Tulos on välttävä");
            }
            if (profitMarg>= 200 && profitMarg<300)
            {
                Console.WriteLine("Tulos on tyydyttävä");
            }
            if (profitMarg>= 300)
            {
                Console.WriteLine("Tulos on hyvä");
            }
        }
            
            
    }
}
