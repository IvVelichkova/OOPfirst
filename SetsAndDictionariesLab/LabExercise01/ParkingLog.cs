using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabExercise01
{
    public class Program
    {
        static void Main()
        {

            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input !="END")
            {
                var parram = Regex.Split(input, ", ");
                if (parram[0]=="IN")
                {
                    parking.Add(parram[1]);
                }
                else
                {
                    if (parking.Contains(parram[1]))
                    {
                        parking.Remove(parram[1]);
                    }
                }


                input = Console.ReadLine();
            }
            if (parking.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");   
            }
            else
            {
                foreach (var car in parking)
                {

                    Console.WriteLine(car);
                }
               
            }

        }
    }
}
