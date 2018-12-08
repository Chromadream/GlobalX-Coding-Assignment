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
        }

        public void WriteOne(string input)
        {
            writer.WriteLine(input);
        }

        public void WriteBatch<T>(List<T> input)
        {
            foreach (var item in input)
            {
                WriteOne(item.ToString());
            }
        }
    }
}