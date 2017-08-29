using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseNumbersWithAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var values = number.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
            var myStack = new Stack<int>(values);

            var reverseStack = new Stack<int>();
            while (myStack.Count!=0)
            {
                Console.Write($"{myStack.Pop()} ");
               
            }
            




            /*// An example string array.
        string[] values = { "Dot", "Net", "Perls" };

        // Copy an array into a Stack.
        var stack = new Stack<string>(values);

        // Display the Stack.
        Console.WriteLine("--- Stack contents ---");
        foreach (string value in stack)
        {
            Console.WriteLine(value);
        }

        // See if the stack contains "Perls"
        Console.WriteLine("--- Stack Contains method result ---");
        bool contains = stack.Contains("Perls");
        Console.WriteLine(contains); */


        }
    }
}
