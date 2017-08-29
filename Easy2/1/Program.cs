using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[20];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i * 5;
            }
            for (int i = 0; i < num.Length-1; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
