using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfCapitalLettersInArray
{//Read an array of strings and find out how many of them are capital English letters (such as A, B, C etc.). Print the count on the console.
    class Program
    {
        static void Main(string[] args)
        {

            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int count = 0;
            int wordCount = 0;

            for (int i = 0; i < words.Length; i++)
            {

                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (word.Length==1)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
