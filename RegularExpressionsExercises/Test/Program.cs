using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone = Console.ReadLine();
            while (phone != "end")
            {


                Regex regex1 = new Regex("^(([+359]{4})(-)([0-9{1}])(-)([0-9]{3})(-)([0-9]{4}))$");
                Regex regex2 = new Regex("^(([+359]{4})( )([0-9{1}])( )([0-9]{3})( )([0-9]{4}))$");

                Match match1 = regex1.Match(phone);
                Match match2 = regex2.Match(phone);

                if (match1.Success)
                {
                    Console.WriteLine(match1.Value);
                }
                if (match2.Success)
                {
                    Console.WriteLine(match2.Value);
                }
                phone = Console.ReadLine();

            }
        }
    }
}
