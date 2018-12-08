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

        public IEnumerable<string> Generator()
        {
            while(instance.Peek() >= 0)
            {
                yield return instance.ReadLine();
            }
        }

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
    }
}