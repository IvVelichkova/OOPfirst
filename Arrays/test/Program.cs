using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            
        }
    }
}
