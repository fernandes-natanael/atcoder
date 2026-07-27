public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; ++i) {
            var diff = target - nums[i];
            if (dict.ContainsKey(diff)) return [dict[diff], i];
            dict[nums[i]] = i;
        }
        return [];
    }
}

// A Try
//public class Solution {
//    public int[] TwoSum(int[] nums, int target) {
//        Dictionary<int, List<int>> dict = new();
//        for (int i = 0; i < nums.Length; ++i) {
//            if (!dict.ContainsKey(nums[i])) {
//                dict[nums[i]] = new List<int>();
//            }
//            dict[nums[i]].Add(i);
//        }
//        
//        foreach (var kv in dict) {
//            var values = kv.Value;
//            var diff = target - kv.Key;
//            if (!dict.ContainsKey(diff))
//                continue;
//            if (diff == kv.Key) {
//                if (values.Count() < 2)
//                    continue;
//                return [values[0], values[1]];
//            }
//            return [values[0], dict[diff][0]];
//        }
//        return [];
//    }
//}

// Brute force
// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         for( int i = 0; i < nums.Length; ++i)
//         {
//             for(int j = i + 1; j < nums.Length; ++j)
//             {
//                 if (nums[i] + nums[j] == target) return [i, j];
//             }
//         }
//
//         return [];
//     }
// }
