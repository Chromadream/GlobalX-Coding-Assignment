using System;
using System.Collections.Generic;

namespace GlobalX_Assignment
{
    class Program
    {
        static int Main(string[] args)
        {
            // Check if input filename is specified on execution
            if(args.Length == 0)
            {
                Console.WriteLine("Please specify input file name.");
                return 1;
            }
            // setting up I/O related classes
            FileLoader fileLoader = new FileLoader(args[0]);
            FileWriter fileWriter = new FileWriter("./sorted-names-list.txt");
            // get all names from the file
            List<String> initialInput = fileLoader.All();
            //convert the List of strings to Name instances
            List<Name> input = Name.BatchConvert(initialInput);
            // perform actual sorting
            List<Name> output = NameSorter.Sort(input);
            // print the sorted list in batch
            Printer.Batch(output);
            // write the sorted list to a new file
            fileWriter.WriteBatch(output);
            return 0;
        }
    }
}
