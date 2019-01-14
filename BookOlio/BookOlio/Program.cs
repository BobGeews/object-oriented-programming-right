using System;

namespace BookOlio
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = null;
            
            Console.WriteLine("**KIRJATEHTÄVÄ**");

            //Book LOTRO = new Book("Kunkun Paluu", "JumskiLAVIS", "12345", 10);
            //LOTRO.PrintThings();

            //Console.WriteLine("---------------------------------------------------------");

            //Book NARNIA = new Book("Keittokirja", "Soppamies", "11111", 5);
            //NARNIA.PrintThings();

            //Console.WriteLine(LOTRO.CompareBook(NARNIA));
            do
            {
                choise = UserInterface();
                switch (choise.ToUpper())
                {
                    case "Q":
                        {
                            Console.WriteLine("---------------------------------------------------------");
                            Book LOTRO = new Book("Kunkun Paluu", "JumskiLAVIS", "12345", 10);
                            LOTRO.PrintThings();

                            Console.WriteLine("---------------------------------------------------------");

                            Book NARNIA = new Book("Keittokirja", "Soppamies", "11111", 5);
                            NARNIA.PrintThings();
                            Console.WriteLine("---------------------------------------------------------");
                            break;
                        }
                        
                    case "W":
                        {
                            Console.WriteLine("---------------------------------------------------------");
                            Book LOTRO = new Book("Kunkun Paluu", "JumskiLAVIS", "12345", 10);
                            LOTRO.PrintThings();

                            Console.WriteLine("---------------------------------------------------------");

                            Book NARNIA = new Book("Keittokirja", "Soppamies", "11111", 5);
                            NARNIA.PrintThings();
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine(LOTRO.CompareBook(NARNIA));
                            Console.WriteLine("---------------------------------------------------------");
                            break;
                        }
                        

                }
                
            } while (choise.ToUpper() != "X");

            string UserInterface()
            {
                Console.WriteLine("\n Paina [Q] jos haluat listan kirjoista.");
                Console.WriteLine("\n Paina [W] jos haluat vertailla kirjojen hintoja.");
                Console.WriteLine("\n Paina [X] jos haluat sulkea ohjelman.");
                return Console.ReadLine();
            }
        }
    }
}
