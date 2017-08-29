using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxSequence = 1;
            int sequence = 1;
            string sequenceNumbers = "";
            string maxSequenceNumbers = "";

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    sequence += 1;
                    sequenceNumbers += nums[i] + " ";
                    maxSequenceNumbers = sequenceNumbers;
                }
            }
            Console.WriteLine(maxSequenceNumbers);

        }
    }
}
