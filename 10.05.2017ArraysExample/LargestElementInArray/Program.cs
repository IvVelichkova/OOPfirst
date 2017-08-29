using System;

using System.Linq;


namespace LargestElementInArray
{
    class Program
    {
        //Read an integer N and on the next N lines read an array of integers. Then, find its largest element.
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = array[i];
                if (max<num)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
