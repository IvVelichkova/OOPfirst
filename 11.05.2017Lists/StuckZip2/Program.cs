using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZip2
{
    class Program
    {
        static void Main(string[] args)
        {

            var first = Console.ReadLine().Split().Select(int.Parse).ToList();
            var second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> firstOut = ReformList(first);
            List<int> secondOut = ReformList(second);

            Console.WriteLine(string.Join(" ",first));
            Console.WriteLine(string.Join(" ", second));
        }

        public static List<int> ReformList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //int digit = Math.Abs(list[i]);
                string len = list[i].ToString();
                int lenn = len.Length;
                bool isReal = true;
                for (int j = 0; j < lenn; j++)
                {

                    char[] counter = new char[1];
                    int count = counter.Length;

                    if (lenn > count)
                    {
                       
                        isReal = false;
                        break;
                    }
                   
                }
                if ( isReal!=true)
                {
                    list.Remove(list[i]);

                }
            }
            return list;
        }
    }
}
