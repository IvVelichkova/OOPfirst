using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[nums.Length];
            int count = 0;

            for (int i = 0; i < k; i++)
            {
                int lastElement = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 1; j--)
                {
                    nums[j] = nums[j - 1];
                    arr[j] += nums[j];

                }
                nums[0] = lastElement;
            }
            
        }
    }
}
