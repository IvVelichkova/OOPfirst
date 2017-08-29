using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversForloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] newArr = new int[array.Length];
            int a = 0;
            int count = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                a = array[i];
                //Console.WriteLine(a);
                newArr[count] = a;
                count++;


            }
            Console.WriteLine(string.Join(" ", newArr);
        }
    }
}
