using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_sMatrix
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] size = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());
            string[][] comands = new string[n][];
            for (int i = 0; i < n; i++)
            {
                comands[i] = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }


            int count = 1;
            int[][] matrix = new int[size[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[size[0]];
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = count;
                    count++;
                }
            }

            int num;
            int num1;
            int rowChange = 0;
            int colChange = 0;
            for (int c = 0; c < comands.Length; c++)
            {
                for (int commandCol = 0; commandCol < comands[c].Length; commandCol++)
                {

                    if (int.TryParse(comands[c][0], out num))
                    {
                        rowChange = num;
                    }
                    if (int.TryParse(comands[c][2], out num1))
                    {
                        colChange = num1;
                    }

                    switch (comands[c][1])
                    {
                        case "left":
                            for (int row = 0; row < matrix.Length; row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {

                                    var first = matrix[rowChange][rowChange];
                                    var second = matrix[rowChange][rowChange - int.Parse(comands[c][2])];
                                    var three = first;


                                }

                            }
                            break;

                        case "right": break;
                        case "up": break;
                        case "down": break;
                    }


                }
            }

            //Console.WriteLine(num);
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write("{0} ", matrix[row][col]);
                }
                Console.WriteLine();

            }
        }
    }
}

