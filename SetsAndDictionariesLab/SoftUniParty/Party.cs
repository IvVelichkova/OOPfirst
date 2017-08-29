using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParty
{
   public class Party
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var party = new SortedSet<string>();



            while (input!="PARTY")
            {
                party.Add(input);
                input = Console.ReadLine();
            }
            while (input != "END")
            {
                if (party.Contains(input))
                {
                    party.Remove(input);

                }
                input = Console.ReadLine();
            }
            if (party.Count!=0)
            {
                Console.WriteLine(party.Count);
                foreach (var p in party)
                {
                    Console.WriteLine(p);
                }

            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
