public class Solution {
    public int ClimbStairs(int n) {
        int one = 1;
        int two = 1;
        int temp = 0;
        for(int i = 0; i < n - 1; i++) {
            temp = one;
            one = one + two;
            two = temp;
        }
        return one;
    }
}