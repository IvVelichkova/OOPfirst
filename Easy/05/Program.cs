using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.Write a program that finds the maximal increasing sequence in an array. Example: { 3, 2, 3, 4, 2, 2, 4}  –> { 2, 3, 4}.

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countSeq = 0;
            int maxCountSeq = 1;
            string numSeq = "";
            string maxNumSeq = "";

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    countSeq++;
                    numSeq += nums[i] + " ";
                    maxNumSeq = numSeq;
                }
                else
                {
                    if (maxCountSeq<countSeq)
                    {
                        maxCountSeq = countSeq;
                        numSeq = nums[i] + " ";
                        maxNumSeq = numSeq;
                    }
                    countSeq = 1;
                    numSeq = "";
                    
                }
            }
            if (maxCountSeq<countSeq)
            {
                numSeq += nums[nums.Length - 1];
                maxNumSeq = numSeq;
            }
            Console.WriteLine(maxNumSeq);


        }  
    }
}
