using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZip3
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().Select(int.Parse).ToList();
            var second = Console.ReadLine().Split().Select(int.Parse).ToList();

            int min = MinCountDigit(first);

            List<int> firstOut = ReformList(min,first);
            List<int> secondOut = ReformList(min,second);

            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));

        }

       public static int MinCountDigit(List<int> list)
        {
            int length = 1;

            int mindigit = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {

                int len = 1;
                int num = (list[i]);
                int number = Math.Abs(num);
               
                while ((number /= 10) >= 1)
                    length++;
                if (length<mindigit)
                {
                    mindigit = length;
                }


            }
            return mindigit;
        }
        
        public static List<int> ReformList(int num,List<int> lists)
        {
            int minCount = MinCountDigit(lists);

            for (int l = 0; l < lists.Count; l++)
            {
                int digit = lists[l];
                if (lists[l] > minCount)
                {
                    lists.Remove(lists[l]);
                    l--;

                }
            }
            return lists;
        }


    }
}
