namespace LeetCode._0001___0100
{
    public class _0003_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2) return s.Length;

            var aux = "";
            var substrings = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                var charIndex = aux.IndexOf(s[i]);
                if (charIndex == -1)
                    aux += s[i];
                else
                {
                    substrings.Add(aux);

                    aux = aux.Substring(charIndex + 1);
                    aux += s[i];
                }

                if (i == s.Length - 1)
                    substrings.Add(aux);
            }

            return substrings.Max(x => x.Length);
        }
    }
}
