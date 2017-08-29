using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9. Write a program that finds the most frequent number in an array.
              Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} –> 4 (5 times)*/

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int p = i + 1; p < nums.Length; p++)
                {
                    if (nums[i] > nums[p])
                    {
                        int temp = nums[i];
                        nums[i] = nums[p];
                        nums[p] = temp;
                    }
                }
            }
            int count = 1;
            int maxCount = 0;
            int numFrequent = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (nums[i] == nums[i + 1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        numFrequent = nums[i];
                    }
                }
                else
                {
                    count = 1;
                }

            }
            Console.Write("{0} > {1}", numFrequent, maxCount);

            Console.WriteLine();
        }

    }
}
