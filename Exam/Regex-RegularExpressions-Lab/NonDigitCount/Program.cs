using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex regex = new Regex(@"[^0-9]");


            MatchCollection match = regex.Matches(text);
            Console.WriteLine($"Non-digits: { match.Count}");
        }
    }
}
