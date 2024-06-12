using FluentAssertions;
using LeetCode._0001___0100;

namespace LeetCode.Tests._0001___0100
{
    public class _0003_LongestSubstringWithoutRepeatingCharacters_Tests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        [InlineData("au", 2)]
        [InlineData("dvdf", 3)]
        public void LengthOfLongestSubstring_ShouldReturnExpectedLength(string s, int expectedLength)
        {
            // Act
            var result = new _0003_LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s);

            // Assert
            result.Should().Be(expectedLength);
        }
    }
}
