using System;

namespace Kirjallisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirja ja kirjailija");
            Author harri = new Author("Harri Höpö","13.3.1968");
            Author tuomas = new Author("Tuomas Enbuske", "2.12.1975");
            Book kirja = new Book("Lastenlauluja", "Harri Höpö", "Joku random kirjapaino", 50.00, "Musiikki");
            Book lehti = new Book("Jallu", "Tuomas Enbuske", "Otava", 29.90, "Poke");
            kirja.GetBook("Lastenlauluja");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            lehti.GetBook("Jallu");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            kirja.SwitchTheme();
            lehti.SwitchTheme();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            kirja.GetBook("Lastenlauluja");
            kirja.Price = kirja.price;
            Console.WriteLine("--------------------------------------------------------------------------------------");
            lehti.GetBook("Jallu");

            

        }
    }
    
}
