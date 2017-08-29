using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEquaToTheirIndex
{
    class Program
    {
        //Read an array of integers and extract the elements which have the same value as their index.
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string a = "";
                ;            
            for (int i = 0; i < num.Length; i++)

            {
                if (num[i] == i)
                {
                    Console.Write(num[i]+" ");

                }

            }
            Console.WriteLine();


        }
    }
}
