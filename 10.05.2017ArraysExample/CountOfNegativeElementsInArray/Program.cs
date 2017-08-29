using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNegativeElementsInArray
{
    class Program
    {
        //Read an integer N and on the next N lines read an array of integers. Then, find the count of negative elements in the array.
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            int negative = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                nums[i]=int.Parse(Console.ReadLine());
                var neg = nums[i];
                if (neg<0)
                {
                    count++;
                }


            }
            Console.WriteLine(count);

        }
    }
}
