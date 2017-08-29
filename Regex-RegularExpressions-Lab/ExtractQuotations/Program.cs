using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractQuotations
{
    class Program
    {
        static void Main(string[] args)
        {
            


          
            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;


            string pattern = @"('|"")(.+?)\1";
               

                foreach (Match m in Regex.Matches(input, pattern, options))
                {
                    Console.WriteLine("{0}", m.Groups[2].Value);
                }
            





    }
    }
}
