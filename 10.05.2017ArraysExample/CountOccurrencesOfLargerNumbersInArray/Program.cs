using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurrencesOfLargerNumbersInArray
{
    class Program
    {
        //Read an array of real numbers and a number p. Find how many elements are bigger than p in the array and print the count.
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double p = double.Parse(Console.ReadLine());
            int count = 0;
           double num = 0;

            for (int i = 0; i < array.Length; i++)
            {
                num = array[i];
                if (num>p)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
