public class Solution {
    public bool IsSubsequence(string s, string t) {
        int success = 0;
            int lastIndex = 0;

            if (s.Length > t.Length) return false;
            if(String.IsNullOrEmpty(s)) return true;
            for (int i = 0; i < t.Length; i++)
            {
                if(s.Contains(t[i]) && s.IndexOf(t[i]) >= lastIndex)
                {
                    success++;
                    lastIndex = s.IndexOf(t[i]);
                }

                if (success == s.Length) return true;
            }

            return false;
    }
}