

// Time  O(n)
// Space O(1)

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length]; res[0] = 1;
        for(int i = 1; i < nums.Length; ++i) {
            res[i] = nums[i-1] * res[i-1];
        }
        int prod = 1;
        for(int j = nums.Length-1 ; j >= 0 ; --j) {
            res[j] *= prod;
            prod *= nums[j];
        }
        return res;
    }
}

// Time  O(n)
// Space O(n)

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        int[] pref = new int[nums.Length]; pref[0] = 1;
        int[] suf = new int[nums.Length]; suf[nums.Length-1] = 1;
        for(int i = 1, j = nums.Length-2; i < nums.Length; ++i, --j) {
            pref[i] = nums[i-1] * pref[i-1];
            suf[j] = nums[j+1] * suf[j+1];
        }
        for(int i = 0 ; i < nums.Length; ++i) 
            res[i] = pref[i] * suf[i];

        return res;
    }
}


//Divider O(n) with division
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];

        int max = 1;
        int zeros = 0;
        foreach (var x in nums) {
            if (x == 0) {
                zeros++;
                continue;
            }
            max *= x;
        }
        if( zeros > 1) return res;

        for (int i = 0; i < nums.Length; ++i) {
            if (nums[i] == 0) res[i] = max;
            else if(zeros == 0) {
                res[i] = max / nums[i];
            }
        }
        return res;
    }
}