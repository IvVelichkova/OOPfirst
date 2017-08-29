using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();  //1 2 3 4 5 6 7 8 9 10 11 12
            int[] middle = new int[array.Length / 2];
            int[] left = new int[array.Length / 4];
            int[] right = new int[left.Length];
            int[] sumArr = new int[array.Length/2];
            int[] leftRight = new int[middle.Length];

            int k = array.Length / 4;

            left=array.Take(k).ToArray();
            Array.Reverse(left);
            middle = array.Skip(k).Take(2*k).ToArray();
            right = array.Skip(3 * k).ToArray();
            Array.Reverse(right);
            //Console.WriteLine(string.Join(" ", left));
            //Console.WriteLine(string.Join(" ", middle));
            //Console.WriteLine(string.Join(" ", right));
            leftRight = left.Concat(right).ToArray();
            for (int i = 0; i < middle.Length; i++)
            {
                sumArr[i] = leftRight[i] + middle[i];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
