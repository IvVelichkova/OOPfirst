using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int lenght = 20;
           
            if (input.Length<lenght)
            {
               int count = lenght - input.Length;
                string padded = input.PadRight(lenght, '*');
                Console.WriteLine(padded);
            }
            else
            {
                Console.WriteLine(input.Substring(0,20));
            }
        }
    }
}
