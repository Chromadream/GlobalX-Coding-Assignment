using System;
using System.Collections.Generic;
using Xunit;
using GlobalX_Assignment;

namespace GlobalX_AssignmentTest
{
    public class FileWriterTest
    {
        [Fact]
        public void TestWriteOne()
        {
            string path = "../../../output.txt";
            FileWriter fileWriter = new FileWriter(path);
            string expected = "This is a test string.";
            fileWriter.WriteOne(expected);
            FileLoader fileLoader = new FileLoader(path);
            IEnumerator<string> loaderEnumerator = fileLoader.Generator().GetEnumerator();
            loaderEnumerator.MoveNext();
            string actual = loaderEnumerator.Current;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void TestWriteStringBatch()
        {
            string path = "../../../output.txt";
            FileWriter fileWriter = new FileWriter(path);
            List<string> expected = new List<string>();
            expected.Add("This is the first string");
            expected.Add("Another string.");
            expected.Add("Well, this should do.");
            fileWriter.WriteBatch(expected);
            FileLoader fileLoader = new FileLoader(path);
            List<string> actual = fileLoader.Some(expected.Count);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void TestWriteNameBatch()
        {
            String path = "../../../output.txt";
            FileWriter fileWriter = new FileWriter(path);
            List<Name> input = new List<Name>();
            List<String> expected = new List<String>();
            expected.Add("Jonathan Nicholas");
            expected.Add("Mirai Kuriyama");
            expected.Add("Shouko Nishimiya");
            foreach (var item in expected)
            {
                input.Add(new Name(item));
            }
            fileWriter.WriteBatch(input);
            FileLoader fileLoader = new FileLoader(path);
            List<string> actual = fileLoader.Some(input.Count);
            Assert.Equal(expected,actual);
        }
    }
}
