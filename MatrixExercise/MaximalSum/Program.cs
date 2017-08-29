using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {

            var size = Console.ReadLine().
                Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).
                ToArray();

            var matrixR = size[0];
            var matrixC = size[1];
            var matrix = new long[matrixR][];
            
            for (long row = 0; row < matrixR; row++)
            {
                matrix[row] = Console.ReadLine().
                    Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
                    Select(long.Parse).
                    ToArray();
            }
            

            long maxRowIndex = 0;
            long maxColindex = 0;
            long maxSum = 0;
            long matrixSumCuurent = 0;



            for (long row = 0; row < matrixR - 2; row++)
            {
                for (long col = 0; col < matrixC - 2; col++)
                {
                    matrixSumCuurent = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                              matrix[row + 1][col] +
                              matrix[row + 1][col + 1] + matrix[row + 1][col + 2] + matrix[row + 2][col] +
                              matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    if (matrixSumCuurent > maxSum)
                    {
                        maxSum = matrixSumCuurent;
                        maxColindex = col;
                        maxRowIndex = row;


                    }
                    
                }


            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRowIndex][maxColindex]} {matrix[maxRowIndex][maxColindex+1]} {matrix[maxRowIndex][maxColindex+2]}");
            Console.WriteLine($"{matrix[maxRowIndex+1][maxColindex]} {matrix[maxRowIndex+1][maxColindex + 1]} {matrix[maxRowIndex+1][maxColindex + 2]}");
            Console.WriteLine($"{matrix[maxRowIndex+2][maxColindex]} {matrix[maxRowIndex+2][maxColindex + 1]} {matrix[maxRowIndex+2][maxColindex + 2]}");

        }
    }
}

