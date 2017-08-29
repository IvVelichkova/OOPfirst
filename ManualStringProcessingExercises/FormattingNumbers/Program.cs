using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FormattingNumbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] numbers = Console.ReadLine().Trim().Split(new[] { ' ','\t','\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int a = int.Parse(numbers[0]);
                decimal b = decimal.Parse(numbers[1]);
                double c = double.Parse(numbers[2]);
                var valueAHex = a.ToString("X").PadRight(10, ' ');
                var aToBinary = Convert.ToString(a, 2).PadLeft(10,'0').Substring(0,10);
                
               
                var bToDouble = b.ToString("0.00").PadLeft(10, ' ');
                var cWith3Digit = c.ToString("0.000").PadRight(10, ' ');
                StringBuilder read = new StringBuilder();
                read.Append("|")
                    .Append(valueAHex)
                    .Append("|")
                    .Append(aToBinary)
                    .Append("|")
                    .Append(bToDouble)
                    .Append("|")
                    .Append(cWith3Digit)
                    .Append("|");
                Console.WriteLine(string.Format("|{0,0}|{1,0}|{2,-10}|{3,10}|", valueAHex, aToBinary,bToDouble,cWith3Digit));
               // Console.WriteLine(read);


            }
        }
    }

    