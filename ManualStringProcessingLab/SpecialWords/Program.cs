using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialWords
{
    class Program
    {
        static void Main(string[] args)
        {

            var first = Console.ReadLine().Split(new[] { ' ', '(', ')', '[', ']', '<', '>', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var second = Console.ReadLine().Split(new[] { ' ', '(', ')', '[', ']', '<', '>', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var counter = new Dictionary<string, int>();


            foreach (var f in first)
            {
                counter.Add(f,0);
            }

            foreach (var s in second)
            {
                if (counter.ContainsKey(s))
                {
                  
               
                    counter[s]++;
                }
            }
            foreach (KeyValuePair<string,int> p in counter)
            {
                Console.WriteLine($"{p.Key} - {p.Value}");
            }
        }
    }
}
