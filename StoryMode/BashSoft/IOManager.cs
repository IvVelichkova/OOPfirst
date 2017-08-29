using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = path.Split('\\').Length;
            Queue<string> subfolders = new Queue<string>();
            subfolders.Enqueue(path);

            while (subfolders.Count != 0)
            {


                string currentPath = subfolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;


                foreach (string directoryPath in Directory.GetDirectories(currentPath))
                {
                    subfolders.Enqueue(directoryPath);
                }

                OutputWriter.WriteMessageOnNeLine(string.Format("{0}{1}", new string('-', identation), currentPath));
            }
        }
    }
}
