using FluentAssertions;
using LeetCode._0001___0100;

namespace LeetCode.Tests._0001___0100
{
    public class _0004_MedianOfTwoSortedArrays_Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 }, 0.0)]
        [InlineData(new int[] { }, new int[] { 1 }, 1.0)]
        [InlineData(new int[] { 2 }, new int[] { }, 2.0)]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2, 3 }, 2.0)]
        [InlineData(new int[] { 1, 2, 5, 7 }, new int[] { 1, 2, 3, 4, 6 }, 3.0)]
        public void FindMedianSortedArrays_ShouldReturnCorrectMedian(int[] nums1, int[] nums2, double expectedMedian)
        {
            // Act
            var result = new _0004_MedianOfTwoSortedArrays().FindMedianSortedArrays(nums1, nums2);

            // Assert
            result.Should().BeApproximately(expectedMedian, 0.00001);
        }
    }
}
