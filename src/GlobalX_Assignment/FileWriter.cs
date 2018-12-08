using System;
using System.IO;
using System.Collections.Generic;

namespace GlobalX_Assignment
{
    public class FileWriter
    {
        private StreamWriter writer;

        public FileWriter(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        // WriteOne()
        // A generic method to write an object to file
        // Have to implement ToString() 
        public void WriteOne<T>(T input)
        {
            writer.WriteLine(input.ToString());
        }

        // WriteBatch()
        // A generic method to write a list of objects to file
        // utilizes WriteOne()
        public void WriteBatch<T>(List<T> input)
        {
            foreach (var item in input)
            {
                WriteOne(item);
            }
        }
    }
}