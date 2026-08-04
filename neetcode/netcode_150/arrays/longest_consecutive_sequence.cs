public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = nums.ToHashSet();
        var biggest = 0;
        foreach(var test in hash)
        {
            if(hash.Contains(test-1)) continue;
            var actual = 0;
            while(hash.Contains(test+actual)) {
                actual++;
            }
            if(actual > biggest) biggest = actual;
        }
        return biggest;
    }
}


// First Valid Solution
// public class Solution {
//     public int LongestConsecutive(int[] nums) {
//         var hash = nums.ToHashSet();
//         var biggest = 0;
//         foreach(var test in hash)
//         {
//             if(hash.Contains(test-1)) continue;
//             var actual = 1;
//             var value = test;
//             while(hash.Contains(++value)) {
//                 actual++;
//             }
//             if(actual > biggest) biggest = actual;
//         }
//         return biggest;
//     }
// }