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
            if(n <= 0)
            {
                return new List<string>();
            }
            List<string> result = new List<string>();
            IEnumerable<string> enumerable = Generator();
            int count = 0;
            foreach (var item in enumerable)
            {
                if(count >= n)
                {
                    break;
                }
                result.Add(item);
                count++;
            }
            return result;
        }
        
        // All()
        // returns all of the string available from the file
        public List<string> All()
        {
            List<string> result = new List<string>();
            IEnumerable<string> enumerable = Generator();
            foreach (var item in enumerable)
            {
                result.Add(item);
            }
            return result;
        }
    }
}