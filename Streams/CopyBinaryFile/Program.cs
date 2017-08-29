namespace _4.Copy_Binary_File
{
   
    using System;
    using System.IO;

    public static class UserInterface
    {
        public static void WriteRed(string message)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);

            Console.ForegroundColor = currentColor;
        }

        public static void WriteGreen(string message)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(message);

            Console.ForegroundColor = currentColor;
        }
    }
    public static class Paths
    {
        public static string GetFile()
        {
            Console.WriteLine("Enter the location of your file (including the file's name and extension):");
            var file = Console.ReadLine();

            while (!File.Exists(file))
            {
                UserInterface.WriteRed($@"The path you entered does not exists. Please enter the full path of your file.{Environment.NewLine}e.g: ""D:\Folder Name\Second Folder\File Name.txt""");
                file = Console.ReadLine();
            }

            return file;
        }

        public static string GetDirectory()
        {
            Console.Write("Enter Directory path: ");
            var dir = Console.ReadLine();

            while (!Directory.Exists(dir))
            {
                UserInterface.WriteRed($@"This Directory does not exists. Please try again. You must enter the full path to your folder{Environment.NewLine}e.g. ""D:\Software-University-SoftUni\C# Advanced""");
                dir = Console.ReadLine();
            }

            return dir;
        }

        public static string SetOutputFileInSameFolderAsInputFile(string inputFile, string addition)
        {
            var fileName = Path.GetFileNameWithoutExtension(inputFile);
            var extension = Path.GetExtension(inputFile);
            var dir = inputFile.Substring(0, inputFile.LastIndexOf('\\'));

            return Path.Combine(dir, $"{fileName} - {addition}{extension}");
        }
    }
    public class CopyBinaryFile
    {
        public static void Main()
        {
            Console.Write("Copy file - ");
            var inputFile = Paths.GetFile();
            var outputFile = Paths.SetOutputFileInSameFolderAsInputFile(inputFile, "Coppyed");

            using (var reader = new FileStream(inputFile, FileMode.Open))
            {
                using (var writer = new FileStream(outputFile, FileMode.OpenOrCreate))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }

            Console.Write("Ready. Your file is here: ");
            UserInterface.WriteGreen(outputFile);
        }
    }
}