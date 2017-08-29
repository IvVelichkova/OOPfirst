using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRow = size[0];
            int matrixCol = size[1];
            string str = Console.ReadLine();
            string[] inputString = new string[str.Length];
            int[] cell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int inpactRow = cell[0];
            int inpactCol = cell[1];
            int radius = cell[2];
            int count = 0;

            string[][] matrix = new string[matrixRow][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new string[matrixCol];
            }
            for (int row = 0; row < matrix.Length; row++)
            {

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    for (int i = 0; i < inputString.Length; i++)
                    {
                        char s = inputString[col]
                        matrix[row][col] = inputString[i];
                    }
                    


                    

                }
            }






            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
