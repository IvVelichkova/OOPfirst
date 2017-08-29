namespace _8.Full_Directory_Traversal
{
    
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
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
    public class FullDirectoryTraversal
    {
        public static void Main()
        {
            var folders = new Queue<string>();
            folders.Enqueue(Paths.GetDirectory());

            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var reportPath = Path.Combine(desktopPath, "report.txt");

            using (File.Create(reportPath)) { }

            TraverseDirectory(folders, reportPath);
        }

        private static void TraverseDirectory(Queue<string> folders, string reportPath)
        {
            if (folders == null || folders.Count == 0)
            {
                return;
            }

            var subfolders = Directory.GetDirectories(folders.Peek());

            foreach (var dir in subfolders)
            {
                folders.Enqueue(dir);
            }

            var files = GetFilesFromDirectory(folders.Peek());

            SaveReport(files, folders.Dequeue(), reportPath);

            TraverseDirectory(folders, reportPath);
        }

        private static void SaveReport(Dictionary<string, Dictionary<string, long>> files, string filesDir, string reportPath)
        {
            using (var appender = new FileStream(reportPath, FileMode.Append))
            {
                using (var writer = new StreamWriter(appender))
                {
                    var sb = new StringBuilder();
                    sb.Append($"Folder: {filesDir}{Environment.NewLine}");

                    foreach (var group in files
                        .OrderByDescending(g => g.Value.Count).ThenBy(g => g.Key))
                    {
                        var filesInGroup = string.Join(Environment.NewLine, group.Value
                            .OrderByDescending(f => f.Value)
                            .Select(kvp => $"      --{kvp.Key} - {kvp.Value}kb"));

                        sb.Append($"   {group.Key}{Environment.NewLine}{filesInGroup}{Environment.NewLine}");
                    }

                    sb.Append($"{Environment.NewLine}{new string('*', 70)}{Environment.NewLine}");
                    writer.Write($"{sb.ToString()}{Environment.NewLine}");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, long>> GetFilesFromDirectory(string dir)
        {
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