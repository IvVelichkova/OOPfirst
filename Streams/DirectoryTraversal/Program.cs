namespace _7.Directory_Traversal
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

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
    public class DirectoryTraversal
    {
        public static void Main()
        {
            var files = GetFilesFromDirectory();
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SaveReport(files, desktopPath);
        }

        private static void SaveReport(Dictionary<string, Dictionary<string, long>> files, string dir)
        {
            var report = Path.Combine(dir, "report.txt");

            using (var writer = new StreamWriter(report))
            {
                foreach (var group in files
                    .OrderByDescending(g => g.Value.Count).ThenBy(g => g.Key))
                {
                    var filesInGroup = string.Join(Environment.NewLine, group.Value
                        .OrderByDescending(f => f.Value)
                        .Select(kvp => $"--{kvp.Key} - {kvp.Value}kb"));

                    writer.Write($"{group.Key}{Environment.NewLine}{filesInGroup}{Environment.NewLine}");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, long>> GetFilesFromDirectory()
        {
            var dir = Paths.GetDirectory();
            var files = Directory.GetFiles(dir);

            // The files should be grouped by their extension
            // Dictionary<extension, Dictionary<filePath, fileSize>>
            var result = new Dictionary<string, Dictionary<string, long>>();

            foreach (var file in files)
            {
                var extension = Path.GetExtension(file);
                var fileSize = new FileInfo(file).Length;

                if (!result.ContainsKey(extension))
                {
                    result[extension] = new Dictionary<string, long>();
                }

                result[extension][file] = fileSize;
            }

            return result;
        }
    }
}