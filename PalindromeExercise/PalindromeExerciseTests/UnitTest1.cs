using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("gary", false)]
        public void PalindromeTest(string word, bool expected)
        {
            // Arrange
            var ws = new WordSmith();

            // Act
            var actual = ws.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
