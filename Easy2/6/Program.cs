using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MaxIncreaseSeq
{
    class MaxIncreaseSeq
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal increasing sequence in an array. 

            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine("Enter {0} elements: ", length);
            for (int index = 0; index < length; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            int maxSequence = 0;
            int sequence = 1;
            string sequenceNumbers = "";
            string maxSequenceNumbers = "";
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    sequence++;
                    sequenceNumbers += array[i] + " ";
                }
                else
                {
                    if (maxSequence < sequence)
                    {
                        maxSequence = sequence;
                        sequenceNumbers += array[i] + " ";
                        maxSequenceNumbers = sequenceNumbers;
                    }
                    sequence = 1;
                    sequenceNumbers = "";
                }
            }

            if (maxSequence < sequence)
            {
                sequenceNumbers += array[array.Length - 1];
                maxSequenceNumbers = sequenceNumbers;
            }

            Console.WriteLine("The maximal increasing sequence in an array is: ");
            Console.WriteLine(maxSequenceNumbers);
        }
    }
}
