using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var matrix = new int[input][];


            for (int row = 1; row < input; row++)
            {
                for (int cow = 1; cow < input/2; cow++)
                {
                    matrix[row][cow] = row;
                }
                

            }
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(matrix[i]);
            }
            for (int i = input/2 - 1; i >= 0; i--)
            {
                
            }
        }
    }
}
