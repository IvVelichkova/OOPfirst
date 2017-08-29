using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix= new int[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();



            }
            int counter = 1;
       
            
            int sum1 = 0;
           int sum2 = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int current = matrix[row][col];
                    if (col== matrix[col].Length-1-row  )
                    {
                        sum1 += current;
                    }
                    if (row == col)
                    {
                        sum2 += current;
                    }
                }
                counter++;
            }

           
            Console.WriteLine(Math.Abs(sum1-sum2));
           
        }
    }
}
