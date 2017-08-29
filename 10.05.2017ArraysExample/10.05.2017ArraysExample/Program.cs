
namespace _10._05._2017ArraysExample
{
    using System;
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                numbers[i] = num;

            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
               
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
