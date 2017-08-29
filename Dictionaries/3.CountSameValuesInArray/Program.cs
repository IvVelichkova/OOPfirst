using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var list = new List<string>();

            for (int i = 0; i <input.Length; i++)
            {
                int start = input.IndexOf('(');
                int end = input.IndexOf(')');
                int count = 0;
                while ((count = input.IndexOf('(', end)) != -1)
                {
                    list.Add(input);
                   

                    // Increment the index.

                }
            }
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }            
        }
    }

}

