using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();
            string[] secondArr = Console.ReadLine().Split().ToArray();
            char[] firstBuffer = new char[firstArr.Length];
            char[] secondBuffer = new char[secondArr.Length];


            for (int i = 0; i < firstArr.Length; i++)
            {
                firstBuffer[i] = Convert.ToChar(firstArr[i]);
            }
            //Console.WriteLine(string.Join(", ", buffer));
            for (int i = 0; i < secondArr.Lastength; i++)
            {
                secondBuffer[i]=Convert.ToChar(second)
            }
        }
    }
}
