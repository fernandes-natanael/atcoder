
public class Program
{
    public static void Main()
    {
        var sol = new Solution();
        var t = sol.ProductExceptSelf([1,2,4,6]);
        foreach(var x in t)
        {
            Console.WriteLine(x);
        }

    }
}



public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        
        int max = 1;
        foreach(var x in nums)
        {
            max *=x;
        }
        for(int i = 0 ; i < nums.Length; ++i)
        {
            res[i] = max / nums[i];
        }
        return res;
    }
}
