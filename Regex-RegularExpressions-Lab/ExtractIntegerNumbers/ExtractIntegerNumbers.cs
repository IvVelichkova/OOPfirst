using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex("\\d+");
            MatchCollection mathces = regex.Matches(text);

            foreach (var match in mathces)
            {
                Console.WriteLine($"{match}");
            }
            
        }
    }
}
