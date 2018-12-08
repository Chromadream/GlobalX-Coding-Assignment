using System;
using System.Collections.Generic;
using Xunit;
using GlobalX_Assignment;

namespace GlobalX_AssignmentTest
{
    public class FileLoaderTest
    {
        [Fact]
        public void TestLoadFirstString()
        {
            string path = "../../../input.txt";
            string expected = "Jonathan Nicholas";
            IEnumerator<string> enumerator = new FileLoader(path).Generator().GetEnumerator();
            enumerator.MoveNext();
            string actual = enumerator.Current;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLoadMultipleString()
        {
            string path = "../../../input.txt";
            List<string> expected = new List<string>();
            List<string> actual = new List<string>();
            expected.Add("Jonathan Nicholas");
            expected.Add("Mirai Kuriyama");
            expected.Add("Mei Mirai Mono");
            IEnumerable<string> enumerable = new FileLoader(path).Generator();
            using(IEnumerator<string> enumerator = enumerable.GetEnumerator())
            {
                while(enumerator.MoveNext() != false)
                {
                    actual.Add(enumerator.Current);
                }
            }
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLoadSomeEqual()
        {
            string path = "../../../input.txt";
            int count = 3;
            List<string> actual = null;
            GlobalX_Assignment.FileLoader fileLoader= new FileLoader(path);
            actual = fileLoader.Some(count);
            Assert.Equal(count,actual.Count);
        }

        [Fact]
        public void TestLoadSomeOverload()
        {
            string path = "../../../input.txt";
            int count = 3000;
            List<string> actual = null;
            GlobalX_Assignment.FileLoader fileLoader= new FileLoader(path);
            actual = fileLoader.Some(count);
            Assert.NotEqual(count,actual.Count);
            Assert.Equal(3,actual.Count);
        }
    }
}
