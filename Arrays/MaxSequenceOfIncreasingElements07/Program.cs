using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countMax = 0;
            int count = 1;
            List<int> lis = new List<int>();

            for (int i = 0; i < nums.Length ; i++)
            {
                if (nums[i+1]> nums[i])
                {
                    countMax++;
                    lis.Add(nums[i]);

                    count = 1;
                }
            }
            Console.WriteLine(string.Join(" ", lis));

        }
    }
}
