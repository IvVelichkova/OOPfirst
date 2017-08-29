using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)

        {

            var size = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();



            int width = int.Parse(size[0]);
            int height = int.Parse(size[1]);
            string[,] matrix = new string[width, height];
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    matrix[row, col] =
                        "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
                }
            }

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

