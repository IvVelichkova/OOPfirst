using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            string[][] matrix = new string[size[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row]=Console.ReadLine().
                    Split(new string[] { " "},StringSplitOptions.RemoveEmptyEntries).
               ToArray();


            }

            int count = 0;
            string letter = "";
            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    var firstRow = matrix[row][col];
                    var FirstCol = matrix[row][col + 1];
                    var secondRow = matrix[row + 1][col];
                    var secondCol = matrix[row + 1][col + 1];



                    if (firstRow==FirstCol && FirstCol==secondRow &&secondRow==secondCol)
                    {
                        count++;
                    }
                    
                }
                
            }
            if (count!=0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(0);
            }








            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write("{0}",matrix[i][j]);
            //    }
               
            //    Console.WriteLine();
            //}
            
        }
    }
}
