public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var len = nums.Length;
        int[] res = new int[len*2];
        for(int i = 0; i < len; ++i) {
            res[i] = nums[i];
            res[i+len] = nums[i];
        }
        return res;
    }
}