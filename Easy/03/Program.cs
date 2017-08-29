using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ').ToArray();
            string[] second = Console.ReadLine().Split(' ').ToArray();
            int min = Math.Min(first.Length, second.Length);
            bool real = true;
            for (int i = 0; i < min; i++)
            {
                if (first[i]!=second[i])
                {
                    real = false;
                    break;
                }
            }
            if (real==true)
            {
                Console.WriteLine("all chars are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }
}
