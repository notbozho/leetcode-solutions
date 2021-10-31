public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
            else if (strs.Length == 1) return strs[0];

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                for (int j = 0; j < prefix.Length; j++)
                {
                    if (strs[i].Length <= j)
                    {
                        prefix = prefix.Substring(0, j);
                        break;
                    }
                    if (prefix[j] == strs[i][j]) continue;
                    else if (j == 0) return "";
                    else prefix = prefix.Substring(0, j);
                }
            }
            return prefix;
    }
}