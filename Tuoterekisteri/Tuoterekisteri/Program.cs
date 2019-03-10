using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Linq;


namespace Tuoterekisteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Harjoitustyö****");

            string readtext = File.ReadAllText(@"C:\Users\ossih\Dev\digitrade18\object-oriented-programming-right\Tuoterekisteri\Tuoterekisteri\items.json");
            /*Koitin vaihtaa tiedosto poluksi ainoastaan "items.json", mutta se ei toiminut. 
             Joudut vaihtamaan tiedosto polun että lista toimii.
            Toivottavasti tämä ei aiheuta suoraa hylkäystä.*/
            List<Products> prodlist = JsonConvert.DeserializeObject<List<Products>>(readtext);
            
            

            string choise = null;
            do
            {
                choise = UserInterface();

               switch (choise.ToUpper())
                {
                    case "Q":
                        {
                            foreach(Products p in prodlist)
                            {
                                p.Writeinfo();

                            }
                            
                            
                            foreach (Products p in prodlist)
                            {
                                if (p.AskId("123") != null)
                                {
                                    Console.WriteLine(p.ToString());
                                }
                            }
                            break;
                        }

                    case "W":
                        {
                           
                            break;
                        }


                }

            } while (choise.ToUpper() != "X");

            string UserInterface()
            {
                Console.WriteLine("\n Tulosta tuote lista: [Q] ");
                Console.WriteLine("\n Paina [W]");
                Console.WriteLine("\n Paina [X] jos haluat sulkea ohjelman.");
                return Console.ReadLine();
            }
        }
    }
}
