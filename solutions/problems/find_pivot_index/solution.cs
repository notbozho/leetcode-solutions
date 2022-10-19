public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0, leftSum = 0;

            foreach (int num in nums) sum += num;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (leftSum == sum - leftSum - nums[i]) return i;
                leftSum += nums[i];
            }
            return -1;
    }
}