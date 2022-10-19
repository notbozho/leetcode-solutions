public class Solution {
    public int CountTriples(int n) {
      int possible = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    double c = Math.Sqrt(i * i + j * j);
                    if (c == (int)c && c <= n)
                        possible++;
                }
            }

            return possible;  
    }
}