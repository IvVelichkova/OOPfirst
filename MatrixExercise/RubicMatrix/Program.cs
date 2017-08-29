using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            var size = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            var r = size[0];
            var c = size[1];
            int count = 1;
            var matrix = new int[r][];

            for (int i = 0; i < r; i++)
            {
                matrix[i] = new int[c];
            }


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = count;
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int rolColIndex = int.Parse(comand[0]);
                int moves = int.Parse(comand[2]);
                string directions = comand[1];


                switch (directions)
                {
                    case "up":
                        MoveCol(matrix, rolColIndex, moves);
                        break;
                    case "down":
                        break;
                    case "left":
                        break;
                    case "right":
                        break;
                }









            }














            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    Console.Write("{0} ", matrix[row][col]);
                }
                Console.WriteLine();

            }

        }

        private static void MoveCol(int[][] matrix, int rolColIndex, int moves)
        {
            int [] temp = new int[matrix.Length];
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex][rowIndex];
            }
        }
    }
}
