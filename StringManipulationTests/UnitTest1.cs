using System;
using Xunit;
using StringManipulationApp;

namespace StringManipulationTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRemoveFirstCharacter()
        {
            string input = "Hello";
            string expected = "ello";
            string result = Program.RemoveFirstCharacter(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRemoveLastCharacter()
        {
            string input = "Hello";
            string expected = "Hellxx";
            string result = Program.RemoveLastCharacter(input);
            Assert.Equal(expected, result);
        }
    }
}
