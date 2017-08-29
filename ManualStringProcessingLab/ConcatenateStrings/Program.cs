using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
           StringBuilder builder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (i < n)
                {
                    string text = Console.ReadLine();
                    builder.Append(text).Append(" ");



                }
                
               
            }
            Console.WriteLine(builder);
        }
    }
}
