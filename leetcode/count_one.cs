public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var count = 0;
        for(int i = 0; i < nums.Length; ++i){
            if (nums[i] == 1) count++;
            else count = 0;
            if( count > max) max = count;
        }
        return max;
    }
}