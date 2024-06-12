using FluentAssertions;
using LeetCode._0001___0100;

namespace LeetCode.Tests._0001___0100
{
    public class _0005_LongestPalindromicSubstring_Tests
    {
        [Theory]
        [InlineData("babad", "bab", "aba")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("ac", "a", "c")]
        [InlineData("racecar", "racecar")]
        [InlineData("aabb", "aa", "bb")]
        public void LongestPalindrome_ShouldReturnCorrectLongestPalindrome(string input, string expected, string orExpected = "")
        {
            // Act
            var result = new _0005_LongestPalindromicSubstring().LongestPalindrome(input);

            // Assert
            result.Should().BeOneOf(expected, orExpected);
        }
    }
}
