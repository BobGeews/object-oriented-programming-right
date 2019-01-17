using System;

namespace EmployeeOlio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**TYÖNTEKIJÄ TEHTÄVÄ**");
            Employee matti = new Employee("Matti Ollikainen",1111,"Toimitusjohtaja",7500);
            Employee pekka = new Employee("Pekka Pakurinen",1112,"Varatoimitusjohtaja",7000);
            Employee jukka = new Employee("Jukka Jukarainen",1113,"Tuotantopäällikkö",6000);


            string choise = null;
            do
            {
                choise = UserInterface();
                switch (choise.ToUpper())
                {
                    case "Q":

                        Console.WriteLine(pekka.CompareSalary(matti));
                        Console.WriteLine(pekka.CompareSalary(jukka));
                        Console.WriteLine(jukka.CompareSalary(matti));

                            break;
                        

                    case "W":
                        {
                            Console.WriteLine( matti.PrintEmployeeInfo());
                            Console.WriteLine(pekka.PrintEmployeeInfo());
                            Console.WriteLine(jukka.PrintEmployeeInfo());
                            break;
                        }
                }

            } while (choise.ToUpper() != "X");

            string UserInterface()
            {
                Console.WriteLine("\n Vertaile palkkoja: Paina [Q]  ");
                Console.WriteLine("\n Tulosta lista työntekijöistä: Paina [W] ");
                Console.WriteLine("\n Sulje sovellus: Paina [X] ");
                return Console.ReadLine();
            }
            
        }
    }
}
