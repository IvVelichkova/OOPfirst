using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VowelCount
{
    class ProgramVowelCount
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex regex = new Regex(@"[aeiouyAEIOUY]");
            MatchCollection match = regex.Matches(text);
            Console.WriteLine($"Vowels: {match.Count}");
        }
    }
}
