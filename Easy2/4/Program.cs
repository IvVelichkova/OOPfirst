using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int maxEq = 0; ;
            int value = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i].Equals(nums[i + 1]))
                {
                    count++;
                    if (maxEq<count)
                    {
                        maxEq = count;
                        value = nums[i];
                    }
                }
                else
                {
                    count = 0;
                }
            }
            if (maxEq != 0)
            {
                Console.WriteLine("Max is {0},the nums is {1}", maxEq + 1,value);
            }
            else
            {
                Console.WriteLine("There is no sequence of elements");
            }
        }
    }
}
