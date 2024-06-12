namespace LeetCode._0001___0100
{
    public class _0001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i1 = 0; i1 < nums.Length; i1++)
            {
                for (int i2 = 0; i2 < nums.Length; i2++)
                {
                    if (i1 != i2 && ((nums[i1] + nums[i2]) == target))
                    {
                        return new int[] { i1, i2 };
                    }
                }
            }
            return new int[] { };
        }

        public int[] TwoSumV2(int[] nums, int target)
        {
            Dictionary<int, int> indexNum = new();
            for (int i = 0; i < nums.Length; i++)
            {
                var remaining = target - nums[i];
                if (indexNum.ContainsKey(remaining))
                {
                    return new int[] { indexNum[remaining], i };
                }
                indexNum[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
