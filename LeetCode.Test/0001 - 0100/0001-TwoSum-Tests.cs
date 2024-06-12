using FluentAssertions;

namespace LeetCode.Tests._0001___0100
{
    public class _0001_TwoSum_Tests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 3, 2, 4 }, 6)]
        [InlineData(new int[] { 3, 3 }, 6)]
        public void TwoSum_ShouldReturnExpectedValues(int[] nums, int target)
        {
            var result = new _0001_TwoSum().TwoSum(nums, target);
            target.Should().Be(result.Select(x => nums[x]).Sum());
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 3, 2, 4 }, 6)]
        [InlineData(new int[] { 3, 3 }, 6)]
        public void TwoSumV2_ShouldReturnExpectedValues(int[] nums, int target)
        {
            var result = new _0001_TwoSum().TwoSumV2(nums, target);
            target.Should().Be(result.Select(x => nums[x]).Sum());
        }
    }
}
