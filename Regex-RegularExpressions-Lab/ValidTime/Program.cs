using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                Regex regex = new Regex("^(0[0-9]|1[0-2]):([0-5][0-9]):([0-5][0-9]) (A|P)M$");
                Match match = regex.Match(input);



                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                input = Console.ReadLine();
            }
           

        }


    }
}
