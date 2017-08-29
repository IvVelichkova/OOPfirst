using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        //Read an array of strings and find the last three consecutive equal strings.
        //Input
        // one one one one two hi hi my echo last last last pi
        //output
        //last last last
        static void Main(string[] args)
        {
            //var arr = Console.ReadLine().Split(' ').ToArray();

            //int n = arr.Length  /*-arr.Length % 2*/;
            //int end = arr.Length-1;
            //int count = 1;
            //int len = n / 2 ;
            //string[] word = new string[n+1];
            //string some = "";
            //for (int i = n-len-1 ; i < n-1; i++)
            //{
            //    if (arr[i]==arr[i+1])
            //    {
            //        some += arr[i];
            //        word[i] = arr[i];
            //        count++;
            //    }
            //    else
            //    {
            //        count = 1;
            //    }

            //}
            //Console.WriteLine(some,count);

            var word = Console.ReadLine().Split().ToArray();

            int count = 1;
            for (int i = word.Length - 1; i > 0; i--)
            {
                if (word[i]==word[i-1])
                {
                    count++;
                    if (count==3)
                    {
                        Console.WriteLine("{0} {0} {0} ",word[i]);
                        break;
                    }
                    
                }
                else
                {
                    count = 1;
                }


            }


        }
    }
}
