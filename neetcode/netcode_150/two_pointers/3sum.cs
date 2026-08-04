public class Program
{
    public static void Main()
    {
        var sol = new Solution();
        var t = sol.ThreeSum([-1,0,1,2,-1,-4]);
        foreach(var x in t)
        {
            foreach(var g in x)
            {
                Console.Write($"{g}, ");
            }
            Console.WriteLine();
        }
    }
}

public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        HashSet<List<int>>res = new();
        var items = nums.ToHashSet();
        
        for(int i = 0;i < nums.Length ; ++i)
        {
            for(int j = i+1 ;j < nums.Length; ++j)
            {
                if(items.Contains(-(nums[i] + nums[j]))) {
                    var tmp = new List<int> {nums[i], nums[j], -(nums[i] + nums[j])};
                    tmp.Sort();
                    if(!res.Contains(tmp)) res.Add(tmp);

                }
            }
        }
        return res.ToList();
    }
}
