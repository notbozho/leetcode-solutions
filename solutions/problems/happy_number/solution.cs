public class Solution {
    public bool IsHappy(int n) {
            int cycle = 0;
            int finalNum = n;
            while (finalNum != 1 && cycle++ < 20)
            {
            double sum = 0;
                while (n > 0)
                {
                    sum += Math.Pow((n % 10), 2);
                    n = n / 10;
                }
                finalNum = (int)sum;
                n = finalNum;
            }
            return finalNum == 1 && true;
    }
}