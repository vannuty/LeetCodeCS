namespace LeetCode._0001___0100
{
    public class _0005_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1) return s;

            var startIndex = 0;
            var endIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandFromIndex(s, i, i);
                int len2 = ExpandFromIndex(s, i, i + 1);
                int len = Math.Max(len1, len2);

                if (len > endIndex - startIndex)
                {
                    startIndex = i - (len - 1) / 2;
                    endIndex = i + len / 2;
                }
            }

            return s.Substring(startIndex, endIndex - startIndex + 1);
        }

        private int ExpandFromIndex(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}