using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().ToLower().Split();

            string pat = Console.ReadLine();
            int counter = 0;
            int lastIndex = 0;
            // int lastIndex = str.Length;
            ;

            foreach (var s in str)
            {
                if (s.Contains(pat))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
