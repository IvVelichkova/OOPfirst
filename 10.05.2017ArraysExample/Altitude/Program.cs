using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var comands = Console.ReadLine().Split(' ').ToArray();
            var first =double.Parse( comands[0]);

            
            for (int i = 0; i < comands.Length; i++)
            {
                switch (comands[i])
                {
                    case "up":
                        first += double.Parse(comands[i+1]);

                        break;
                    case "down":
                        first -= double.Parse(comands[i + 1]);
                        break;
                }
            }
            if (first<=0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {first}m");
            }

        }
    }
}
