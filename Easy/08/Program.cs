using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8. Write a program that finds the sequence of maximal sum in given array.
Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} –> {2, -1, 6, 4}
Can you do it with only one loop (with single scan through the elements of the array)? KADAN*/
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int max = int.MinValue;
            int tempMax = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                tempMax += nums[i];

                if (tempMax>max)
                {
                    max = tempMax;
                }
                if (tempMax < 0)
                {
                    tempMax = 0;
                }
            }
            Console.Write("{0} ", max);

            Console.WriteLine();


        }



    }
}
