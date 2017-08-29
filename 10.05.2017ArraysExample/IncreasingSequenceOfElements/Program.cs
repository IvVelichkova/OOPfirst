using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        //Read an array of integers and find out if it is an increasing sequence. Print Yes if it does and No if it doesn’t.
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int count = 1;
            int max = array.Length;
        
            

            for (int i = 0; i < array.Length-1; i++)
            {

              
                if (array[i]<array[i+1])
                {
                    count++;

                }
                else
                {
                    count = 0;
                }
               

            }
            if (count==max)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");

            }
            
        }
    }
}
