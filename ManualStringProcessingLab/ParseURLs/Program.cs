using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string[] link = input.Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);
            if (link.Length != 2 || link[1].IndexOf("/") == -1)
            {
                Console.WriteLine(" Invalid URL");

            }
            else
            {
                string protocol = link[0];
                int serverEndIndex = link[1].IndexOf("/");
                string server = link[1].Substring(0, serverEndIndex);
                string recourses = link[1].Substring(serverEndIndex + 1);
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine(($"Resources = {recourses}"));

            }

        }
    }
}
