using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;

namespace Uppgift4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Skriv in ett heltal");
                string svar = Console.ReadLine();
                int heltal = int.Parse(svar);
                while (true)
                {
                    Console.WriteLine("Vill du skriva in ett till heltal?");
                    string svar2 = Console.ReadLine();
                    if (svar2 == "nej" || svar2 == "Nej")
                    {
                        Console.WriteLine("Ditt största tal är" + heltal);
                        break;
                    }
                    if (svar2 == "ja" || svar2 == "Ja")
                    {
                        Console.WriteLine("Skriv in ett heltal");
                        int heltal2 = int.Parse(Console.ReadLine());
                        if (heltal2 > heltal)
                        {
                            heltal2 = heltal;
                        }
                    }
                }
            }
        }
    }
}