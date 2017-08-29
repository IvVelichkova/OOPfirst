using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = Math.Min(first.Length, second.Length);
            bool real = true;

            for (int i = 0; i < min; i++)
            {
                if (first[i] !=second[i])
                {
                    real = false;
                    break;
                }
               
            }
            Console.WriteLine("they are equal {0}",real);
        }
    }
}
