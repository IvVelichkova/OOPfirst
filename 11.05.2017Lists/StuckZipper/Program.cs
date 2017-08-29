using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {


            var first = Console.ReadLine().Split().Select(int.Parse).ToList();
            var second = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;

            char[] digit =new char[1];
            for (int i = 0; i < first.Count; i++)
            {
                int len = first[i].ToString().Length;
                foreach (var digi in first)
                {
                    if (digi.ToString().Length > 1)
                    {
                        first.Remove(first[i]);
                    }
                }
                
            }
            Console.WriteLine(String.Join("",first));
        }
    }
}
