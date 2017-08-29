using System;
using System.IO;
namespace OddLines
{
    public class OddLine
    {
        public static void Main()
        {
            string dir = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\FileForRead.txt";
            StreamReader reader = new StreamReader(file);
            using (reader)
            {
               
                for (int i = 0; i < 10; i++)
                {
                    var input = reader.ReadLine();
                    if (i%2==0)
                    {
                       
                        Console.WriteLine($"Odd Line : {input}");
                        Console.WriteLine();

                    }

                }
            }
        }
    }
}
