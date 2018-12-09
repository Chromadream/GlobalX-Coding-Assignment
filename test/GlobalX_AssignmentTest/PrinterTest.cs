using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using GlobalX_Assignment;

namespace GlobalX_AssignmentTest
{
    public class PrinterTest
    {
        [Fact]
        public void TestBatchPrinting()
        {
            // Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            List<String> input = new List<string>();
            input.Add("Test string");
            input.Add("Another string");
            String expected = "Test string\nAnother string\n";
            // Act
            Printer.Batch(input);
            // Assert
            String actual = writer.GetStringBuilder().ToString();
            Assert.Equal(expected, actual);
        }
    }
}
