using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startIndex = 0;
            int endIndex = 0;
            int CurrSum = 0;
            int sumS = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                sumS = (array[i]);

                CurrSum += array[i];
                startIndex = i;
                for (int p = i + 1; p < array.Length; p++)
                {
                    CurrSum += array[p];
                    endIndex = p;
                    if (CurrSum == sumS)
                    {
                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            Console.WriteLine(array[k]);
                        }
                        return;
                    }
                }
                CurrSum = 0;
            }
            Console.WriteLine("The sumS is not present in the array.");
        }
    }
}
