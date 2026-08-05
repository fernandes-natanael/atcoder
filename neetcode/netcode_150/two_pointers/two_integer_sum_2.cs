public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var init = 0;
        var last = numbers.Length - 1;
        
        while( init < last)
        {
            var res = numbers[last] + numbers[init];
            if(res == target) return [init+1, last+1];
            else if(res > target) last--;
            else init++;
        }
        return [];
    }
}
