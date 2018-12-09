using System;
using System.Collections.Generic;
using Xunit;
using GlobalX_Assignment;

namespace GlobalX_AssignmentTest
{
    public class NameTest
    {
        [Fact]
        public void TestOneName()
        {
            // Arrange
            string name = "Akagi";
            // Act
            Action testPart = () => {
                Name result = new Name(name);
            };
            var exception = Record.Exception(testPart);
            // Assert
            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }

        [Fact]
        public void TestOneGivenName()
        {
            // Arrange
            string name = "Jonathan Nicholas";
            string expectedFirstName = "Jonathan";
            string expectedLastName = "Nicholas";
            // Act
            GlobalX_Assignment.Name actual = new Name(name);
            // Assert
            Assert.Equal(expectedFirstName,actual.FirstName);
            Assert.Equal(expectedLastName,actual.LastName);
        }
        [Fact]
        public void TestTwoGivenNames()
        {
            // Arrange
            string name = "Mei Mirai Mono";
            string expectedFirstName = "Mei Mirai";
            string expectedLastName = "Mono";
            // Act
            GlobalX_Assignment.Name actual = new Name(name);
            // Assert
            Assert.Equal(expectedFirstName,actual.FirstName);
            Assert.Equal(expectedLastName,actual.LastName);
        }
        [Fact]
        public void TestThreeGivenNames()
        {
            // Arrange
            string name = "Mei Mirai Maki Mono";
            string expectedFirstName = "Mei Mirai Maki";
            string expectedLastName = "Mono";
            // Act
            GlobalX_Assignment.Name actual = new Name(name);
            // Assert
            Assert.Equal(expectedFirstName,actual.FirstName);
            Assert.Equal(expectedLastName,actual.LastName);
        }
    }
}
