using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchCount
{
    class ProgramMatchCount
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection mathc = regex.Matches(text);


            Console.WriteLine($"{mathc.Count}");
        
            

        }
    }
}
