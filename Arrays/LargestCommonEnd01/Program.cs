using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split().ToArray();
            string[] second = Console.ReadLine().Split().ToArray();
            int min = Math.Min(first.Length, second.Length);
            int leftCount = 0;
            int rightCount = 0;
            for (int i = 0; i < min; i++)
            {
                if (first[i] == second[i])
                {
                    leftCount++;
                }
            }
            Array.Reverse(first);
            Array.Reverse(second);
            for (int i = 0; i < min; i++)
            {
                if (first[i]==second[i])
                {
                    rightCount++;
                }
            }
            int max = 0;
            max = Math.Max(rightCount, leftCount);
            Console.WriteLine(max);       }
    }
}
