using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[6];
            int length = n.Length;
            int[] k = new int[6];
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = ((i * 2) + 1);
                k[i] = n[i];
                count = i * 2 + 1;
                if (k[i] == length)
                {
                    break;
                }
            }


            Console.WriteLine(string.Join(" ", k));

            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}

