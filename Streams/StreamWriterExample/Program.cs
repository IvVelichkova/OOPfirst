
using System;
using System.IO;

namespace StreamWriterExample
{
    class Program
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter(@"someFileExample.txt");
            //string path = Path.Combine(Environment.CurrentDirectory, @"\..\..\someFileExample.txt");
            //string p1 = @"d:\archives\";
            //string p2 = "media";
            //string p3 = "images";
            //string combined = Path.Combine(p1, p2, p3);
            //Console.WriteLine(combined);
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine(i);
            }
            writer.Close();
        }
    }
}
