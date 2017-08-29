using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();


            while (name!="END")
            {
                Regex validation = new Regex("^[\\w\\d-]{3,16}$",RegexOptions.Multiline);
                MatchCollection match = validation.Matches(name);



                if (match.Count>0)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                name = Console.ReadLine();

            }


        }
    }
}
