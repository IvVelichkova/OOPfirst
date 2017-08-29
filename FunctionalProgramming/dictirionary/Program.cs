using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dictirionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            //
            // Get all words.
            //
            string[] uppercaseWords = Regex.Split(sentence, @"\W");
            //
            // Get all uppercased words.
            //
            var list = new List<string>();
            foreach (string value in uppercaseWords)
            {
                //
                // Check the word.
                //
                if (!string.IsNullOrEmpty(value) &&
                    char.IsUpper(value[0]))
                {
                    list.Add(value);
                }
            }
            //
            // Write all proper nouns.
            //
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
