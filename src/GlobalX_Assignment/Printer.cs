using System;
using System.Collections.Generic;

namespace GlobalX_Assignment
{
    public class Printer
    {

        // Batch<T>()
        // Generic function that prints to a Console.
        // Separates the concern of printing to a separate function.
        public static void Batch<T>(List<T> input)
        {
            foreach(var item in input)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}