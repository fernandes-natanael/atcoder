public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();
        foreach (var num in nums) {
            if (!dict.ContainsKey(num))
                dict[num] = 1;
            else
                dict[num]++;
        }
        return dict.OrderByDescending(c => c.Value).Take(k).Select(c => c.Key).ToArray();
    }
}
