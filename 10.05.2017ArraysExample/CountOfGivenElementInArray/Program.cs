using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class Program
    {
        //Read an array of integers and print how many times a given element exists in it.
        
        static void Main(string[] args)
        {

            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int exist = int.Parse(Console.ReadLine());


            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==exist)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
