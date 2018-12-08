using System;
using System.IO;
using System.Collections.Generic;

namespace GlobalX_Assignment
{
    public class FileLoader
    {

        private StreamReader instance;
        public FileLoader(string fileName)
        {
            instance = File.OpenText(fileName);
        }

        // Generator()
        // Returns an Enumerable instance of the file
        public IEnumerable<string> Generator()
        {
            while(instance.Peek() >= 0)
            {
                yield return instance.ReadLine();
            }
        }

        // Some()
        // returns the List of string, with the size specified at input value
        public List<string> Some(int n)
        {
            List<string> result = new List<string>();
            IEnumerator<string> enumerator = Generator().GetEnumerator();
            for (int i = 0; i < n; i++)
            {
                while(enumerator.MoveNext() != false)
                {
                    result.Add(enumerator.Current);
                }
            }
            return result;
        }
        
        // All()
        // returns all of the string available from the file
        public List<string> All()
        {
            List<string> result = new List<string>();
            IEnumerator<string> enumerator = Generator().GetEnumerator();
            while(enumerator.MoveNext() != false)
            {
                result.Add(enumerator.Current);
            }
            return result;
        }
    }
}