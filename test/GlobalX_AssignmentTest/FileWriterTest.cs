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
            // Arrange
            string path = "../../../output.txt";
            FileWriter fileWriter = new FileWriter(path);
            string expected = "This is a test string.";
            // Act
            fileWriter.WriteOne(expected);
            // Assert
            FileLoader fileLoader = new FileLoader(path);
            List<string> result = fileLoader.Some(1);
            string actual = result[0];
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void TestWriteStringBatch()
        {
            // Arrange
            string path = "../../../output.txt";
            FileWriter fileWriter = new FileWriter(path);
            List<string> expected = new List<string>();
            expected.Add("This is the first string");
            expected.Add("Another string.");
            expected.Add("Well, this should do.");
            // Act
            fileWriter.WriteBatch(expected);
            // Assert
            FileLoader fileLoader = new FileLoader(path);
            List<string> actual = fileLoader.Some(expected.Count);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void TestWriteNameBatch()
        {
            // Arrange
            String path = "../../../output.txt";
            FileWriter fileWriter = new FileWriter(path);
            List<Name> input = new List<Name>();
            List<String> expected = new List<String>();
            expected.Add("Jonathan Nicholas");
            expected.Add("Mirai Kuriyama");
            expected.Add("Shouko Nishimiya");
            input = Name.BatchConvert(expected);
            // Act
            fileWriter.WriteBatch(input);
            // Assert
            FileLoader fileLoader = new FileLoader(path);
            List<string> actual = fileLoader.Some(input.Count);
            Assert.Equal(expected,actual);
        }
    }
}
