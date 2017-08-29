using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] lady = new int[n];
            int[] position = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = position[];
            for (int i = 0; i < lady.Length - 1; i++)
            {
                
                lady[i] = 0;
                index=position[index];
                lady[index] = 1;
            }
            Console.WriteLine(string.Join(" ", lady));
        }
    }
}
