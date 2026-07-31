public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var len = nums.Length;
        var res = new int[len];
        int count = 0, i = 0;
        while(count < n)
        {
            res[i] = nums[count];
            res[i+1] = nums[count+n];
            i+=2; count++;
        }
        return res;
    }
}