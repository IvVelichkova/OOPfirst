using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceOfElementsInArray
{
    class Program
    {
        //Read an array of integers and find out if all the elements in the array are the same.
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int count = 1;
            int num = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                num = arr[i];
                if (num==arr[i+1])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            if (count==arr.Length)
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
