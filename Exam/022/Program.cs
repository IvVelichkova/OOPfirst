using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (!str[0].Equals("end"))
            {
                List<int> newNums = new List<int>();
                str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            switch (str[0])
            {
                case "reverse":
                    break;
                case "sort":
                    break;
                case "rollLeft":
                    break;
                case "rollRight":
                    break;
                default:
                    break;

                    
                    

                    






            }






            Console.WriteLine("[{0}]", string.Join(", ", nums));

        }
    }
}
