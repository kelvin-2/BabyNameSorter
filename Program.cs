using System;
using System.Collections;
using System.IO;

namespace Comparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            ReadAndCheckLines();
        }

        public void ReadAndCheckLines()
        {

            using (StreamReader sr = new StreamReader("TestInputs.txt"))
            {
                string line;
                int lineNumber = 1; // Track the line number for user clarity
                while ((line = sr.ReadLine()) != null)
                {
                    // Split the line into parts
                    string[] parts = line.Split(',');

                    // Check if the line is sorted
                    if (IsSorted(parts))
                    {
                        Console.WriteLine($"Line {lineNumber}: Sorted");
                    }
                    else
                    {
                        Console.WriteLine($"Line {lineNumber}: Unsorted");
                    }
                    lineNumber++;
                }
            }
        }

        public bool IsSorted(string[] parts)
        {
            for (int i = 0; i < parts.Length - 1; i++)
            {
                
                if (parts[i].CompareTo(parts[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
