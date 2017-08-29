using System;
using System.IO;


namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {



            using (var reader = new StreamReader("../../ReadFile.txt"))
            {
                using (var writer = new StreamWriter("../../WriteFile.txt"))
                {
                    string line = reader.ReadLine();
                    int counter = 0;
                    while (line != null)
                    {
                       
                        {
                            for (int i = 0; i < line.Length; i++)
                            {

                                counter++;
                                writer.Write(counter +" "+ line[i]);
                            }
                            writer.WriteLine();
                            line = reader.ReadLine();
                        }




                    }
                }
            }

        }
    }
}

