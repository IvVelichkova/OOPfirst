using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine();
            StringBuilder read = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                read.Append(text[i]);
            }
            Console.WriteLine(read);
        }
    }
}
