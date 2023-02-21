using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loome sõnastiku, mis mäpib int-võtmed string-väärtustele
            Dictionary<int, string> koolid = new Dictionary<int, string>();

            // lisame sõnastikku mõned võtme-väärtuse paarid
            koolid.Add(1, "Kehra Gümnaasium");
            koolid.Add(2, "Tallinna mehnikaülikool");
            koolid.Add(3, "TTHK");

            // kasutame foreach-tsüklit, et sõnastik üle käia ja väljastada iga kooli nimi ja ID
            foreach (KeyValuePair<int, string> kvp in koolid)
            {
                Console.WriteLine("Kooli ID {0} on {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();
        }
    }
}