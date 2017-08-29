using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (decimal i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime days = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",
                                  CultureInfo.InvariantCulture);
                decimal capsuls = decimal.Parse(Console.ReadLine());
                decimal allDays = DateTime.DaysInMonth(days.Year, days.Month);
                decimal total = (allDays * capsuls) * price;

                Console.WriteLine("The price for the coffee is: ${0:f2}", total);
                sum += total;

            }
            Console.WriteLine("Total: ${0:f2}", sum);
        }
    }
}

