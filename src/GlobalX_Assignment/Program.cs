using System;
using System.Collections.Generic;

namespace GlobalX_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLoader fileLoader = new FileLoader(args[0]);
            FileWriter fileWriter = new FileWriter("./sorted-names-list.txt");
            List<Name> input = Name.BatchConvert(fileLoader.All());
            List<Name> output = NameSorter.Sort(input);
            foreach (var item in output)
            {
                Console.WriteLine(item);
                fileWriter.WriteOne(item.ToString());
            }
        }
    }
}
