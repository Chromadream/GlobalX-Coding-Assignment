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
            string name = "Akagi";
            Action testPart = () => {
                Name result = new Name(name);
            };
            var exception = Record.Exception(testPart);

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }

        [Fact]
        public void TestOneGivenName()
        {
            string name = "Jonathan Nicholas";
            string expectedFirstName = "Jonathan";
            string expectedLastName = "Nicholas";
            GlobalX_Assignment.Name actual = new Name(name);
            string actualFirstName = actual.FirstName;
            string actualLastName = actual.LastName;
            Assert.Equal(expectedFirstName,actualFirstName);
            Assert.Equal(expectedLastName,actualLastName);
        }
        [Fact]
        public void TestTwoGivenNames()
        {
            string name = "Mei Mirai Mono";
            string expectedFirstName = "Mei Mirai";
            string expectedLastName = "Mono";
            GlobalX_Assignment.Name actual = new Name(name);
            string actualFirstName = actual.FirstName;
            string actualLastName = actual.LastName;
            Assert.Equal(expectedFirstName,actualFirstName);
            Assert.Equal(expectedLastName,actualLastName);
        }
        [Fact]
        public void TestThreeGivenNames()
        {
            string name = "Mei Mirai Maki Mono";
            string expectedFirstName = "Mei Mirai Maki";
            string expectedLastName = "Mono";
            GlobalX_Assignment.Name actual = new Name(name);
            string actualFirstName = actual.FirstName;
            string actualLastName = actual.LastName;
            Assert.Equal(expectedFirstName,actualFirstName);
            Assert.Equal(expectedLastName,actualLastName);
        }
    }
}
