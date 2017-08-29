using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        //Read an array of strings and find the last three consecutive equal strings.
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            int count = 1;
            string[] three = new string[3];

            for (int i = words.Length-words.Length/2; i > 0; i--)
            {
                if (words[i] == words[i-1])
                {
                    count++;
                    three[i] = words[i];

                    
                }
            }
            if (count==3)
            {
                Console.WriteLine(string.Join(" ",three));
            }

        }
    }
}
