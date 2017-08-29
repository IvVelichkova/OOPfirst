using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] first = Console.ReadLine().Split().ToArray();
            string[] second = Console.ReadLine().Split().ToArray();
            int min = Math.Min(first.Length, second.Length);

            for (int i = 0; i < min; i++)
            {
                if (first[i].Equals(second[i]))
                {
                    Console.WriteLine(first[i]);
                }
            }
        }
    }
}
