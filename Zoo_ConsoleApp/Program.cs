using System;
using System.Collections.Generic;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");

            Abe abe = new Abe(7, "hankøn");
            Elefant elefant = new Elefant(6000, "hankøn");
            Panda panda = new Panda(80, "hunkøn");
            Tiger tiger = new Tiger(170, "hunkøn");

            List<Dyr> dyr = new List<Dyr>();

            dyr.Add(abe);
            dyr.Add(elefant);
            dyr.Add(panda);
            dyr.Add(tiger);

            foreach (var item in dyr)
            {
                Console.WriteLine(item.ToString());
                if (item is IRovdyr)
                {
                    Console.WriteLine($"En {item.Navn} er et rovdyr.");
                }
                else
                {
                    Console.WriteLine($"En {item.Navn} er et byttedyr.");
                }

            }



        }
    }
}
