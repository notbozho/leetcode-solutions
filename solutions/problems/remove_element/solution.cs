public class Solution {
    public int RemoveElement(int[] nums, int val) {
            if(nums.Length < 1) return 0;
            int numsLength = nums.Length;
            int i = 0;
            do {
                if (nums[i] == val)
                {
                    nums[i] = nums[numsLength - 1];
                    //nums[numsLength] = 0;
                    numsLength--;
                } else
                {
                    i++;
                }
                
            } while (i < numsLength);
            return numsLength;
    }
}