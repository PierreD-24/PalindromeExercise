using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("madam", true)]
        public void PalindromeTest(string word, bool expected)
        {
            var test = new WordSmith();
            
            bool actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
