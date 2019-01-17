using System;

namespace FirmaOlio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**FIRMATEHTÄVÄ**");
            Company Ensto = new Company("Ensto", "Suntiokatu 22", "0501235212", 100, 29);
            Company Casemet = new Company(Ensto);
            Ensto.Printinfo();
            Ensto.Record();
            Console.WriteLine("-----------------------------------------------");
            Casemet.Printinfo();
            Casemet.Record();
        }
    }
}
