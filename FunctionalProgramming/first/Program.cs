using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public  enum condition
    {
        older=0,
        younger=1
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                var person = Console.ReadLine().Split().ToArray();
                people.Add(person[0], int.Parse(person[1]));


            }
            var age = int.Parse(Console.ReadLine());
            var nameOrAge = Console.ReadLine();


        }
        public static void nameAge(string name)
        {
           
            Console.WriteLine($"{nameAge.}");
        }

        public static void  nameAge(string name,int userAge,condition,int age,string names)
        {
            Console.WriteLine($"{nameAge.Keys} {nameAge.Values}");
        }
    }
}
