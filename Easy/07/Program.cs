using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7.Sorting an array means to arrange its elements in increasing order.
             *  Write a program to sort an array.Use the „selection sort“ algorithm: 
             *  Find the smallest element, move it at the first position,
             *   find the smallest from the rest, move it at the second position, etc.*/

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int p = i + 1; p < nums.Length; p++)
                {
                    if (nums[p] < nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[p];
                        nums[p] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
        }
    }
}
