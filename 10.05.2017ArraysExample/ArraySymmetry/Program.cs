using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        //Read an array of strings and find out if it’s symmetric. If it is, print “Yes”, otherwise print “No”.
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int len = arr.Length / 2;
            bool isSymmetric = true;
            


            for (int i = 0; i < len; i++)
            {
                string firstWords = arr[i];
                string secondWords = arr[arr.Length - i - 1];
                if (firstWords !=secondWords)
                {
                    isSymmetric = false;
                }

            }

            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
