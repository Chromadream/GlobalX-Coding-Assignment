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
            // Arrange
            const string path = "../../../input.txt";
            const string expected = "Jonathan Nicholas";
            IEnumerator<string> enumerator = new FileLoader(path).Generator().GetEnumerator();
            // Act
            enumerator.MoveNext();
            string actual = enumerator.Current;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLoadMultipleString()
        {
            // Arrange
            const string path = "../../../input.txt";
            List<string> expected = new List<string>();
            List<string> actual = new List<string>();
            expected.Add("Jonathan Nicholas");
            expected.Add("Mirai Kuriyama");
            expected.Add("Mei Mirai Mono");
            IEnumerable<string> enumerable = new FileLoader(path).Generator();
            // Act
            using(IEnumerator<string> enumerator = enumerable.GetEnumerator())
            {
                while(enumerator.MoveNext() != false)
                {
                    actual.Add(enumerator.Current);
                }
            }
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLoadSomeEqual()
        {
            // Arrange
            const string path = "../../../input.txt";
            const int count = 3;
            GlobalX_Assignment.FileLoader fileLoader= new FileLoader(path);
            // Act
            List<string> actual = fileLoader.Some(count);
            // Assert
            Assert.Equal(count,actual.Count);
        }

        [Fact]
        public void TestLoadSomeOverload()
        {
            // Arrange
            const string path = "../../../input.txt";
            const int count = 3000;
            const int actualCount = 3;
            GlobalX_Assignment.FileLoader fileLoader= new FileLoader(path);
            // Act
            List<string>  actual = fileLoader.Some(count);
            // Assert
            Assert.NotEqual(count,actual.Count);
            Assert.Equal(actualCount,actual.Count);
        }

        [Fact]
        public void TestLoadAll()
        {
            // Arrange
            const string path = "../../../input.txt";
            const int count = 3;
            FileLoader fileLoader = new FileLoader(path);
            // Act
            List<string> actual = fileLoader.All();
            // Assert
            Assert.Equal(count,actual.Count);
        }
    }
}
