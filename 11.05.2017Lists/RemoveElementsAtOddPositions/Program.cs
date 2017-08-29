using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPositions
{
    class Program
    {
        //Write a program which reads a list of space-separated strings and removes the elements at positions [1…3…5…7…etc.]. After that, print the elements with no delimiter. Note that positions are counted from 1.
        static void Main(string[] args)
        {
            {
                var num = Console.ReadLine().Split().ToList();
                string count = "";
                var remNum = new List<string>();
                num.Insert(0, "b");

                for (int i = 0; i <= num.Count; i++)

                {
                    int d = (int)Math.Sqrt(i);

                    if (i!=0 ||i==1 || Math.Sqrt(i)!=2)
                    {




                        remNum.Add(num[i]);
                        count += num[i];
                    }

                }
                Console.WriteLine(string.Join("", remNum));
            }
        }
    }
}
