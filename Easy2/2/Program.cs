using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = Math.Min(first.Length, second.Length);

            for (int i = 0; i < length; i++)
            {
                if (first[i].Equals(second[i]))
                {
                    Console.WriteLine(first[i]);
                }
                
            }


        }
    }
}
