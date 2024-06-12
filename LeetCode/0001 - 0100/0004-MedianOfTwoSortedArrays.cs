using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001___0100
{
    public class _0004_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mergedArray = nums1.Concat(nums2).ToArray();
            Array.Sort(mergedArray);
            if (mergedArray.Count() % 2 != 0)
            {
                return mergedArray[(mergedArray.Count() - 1) / 2];
            }
            int firstIndex = (mergedArray.Count() / 2) - 1;
            return (mergedArray[firstIndex] + mergedArray[firstIndex + 1]) / 2.0;
        }
    }
}
