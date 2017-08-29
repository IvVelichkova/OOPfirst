using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        { //4. Write a program that finds the maximal sequence of equal elements in an array.

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int maxSequence = 0;
            int value = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                    if (maxSequence < count)
                    {
                        maxSequence = count;
                    }
                    value = nums[i];
                }
                else
                {
                    count = 0;
                }


            }
            if (maxSequence == 0)
            {
                Console.WriteLine("there are not sequane");
            }
            else
            {
                Console.WriteLine("yes,there are seq {0}", value);
            }
        }
    }
}
