using System;
using System.Collections.Generic;
using Xunit;
using GlobalX_Assignment;

namespace GlobalX_AssignmentTest
{
    public class SorterTest
    {
        [Fact]
        public void TestSorterWithUniqueNames()
        {
            List<Name> input = new List<Name>();
            input.Add(new Name("Janet Parsons"));
            input.Add(new Name("Beau Tristan Bentley"));
            input.Add(new Name("Hunter Uriah Mathew Clarke"));
            List<Name> expected = new List<Name>();
            expected.Add(new Name("Beau Tristan Bentley"));
            expected.Add(new Name("Hunter Uriah Mathew Clarke"));
            expected.Add(new Name("Janet Parsons"));
            List<Name> actual = NameSorter.Sort(input);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void TestSorterWithSameLastNames()
        {
            List<Name> input = new List<Name>();
            input.Add(new Name("Yuzuru Nishimiya"));
            input.Add(new Name("Shouko Nishimiya"));
            List<Name> expected = new List<Name>();
            expected.Add(new Name("Shouko Nishimiya"));
            expected.Add(new Name("Yuzuru Nishimiya"));
            List<Name> actual = NameSorter.Sort(input);
            Assert.Equal(expected,actual);
        }
    }
}
