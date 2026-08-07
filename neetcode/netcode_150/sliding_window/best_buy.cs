// Recommended Solution
public class Solution {
    public int MaxProfit(int[] prices) {
        var buy_pos = 0;
        var sell_pos = 1;
        var best = 0;
        while (sell_pos < prices.Length) {
            if(prices[sell_pos] > prices[buy_pos])
            {
                best = int.Max(best, prices[sell_pos - buy_pos]);
            } else
            {
                buy_pos = sell_pos; // when I find a better buy price than what I already have I switch to use it
            }
            sell_pos++;// always look to next sell position
        }
        return best;
    }
}


// My solution
// O(2n) time so O(n)
// O(1) space
//public class Solution {
//    public int MaxProfit(int[] prices) {
//        var buy_pos = 0;
//        var sell_pos = 1;
//        var best = 0;
//        while (sell_pos < prices.Length) {
//            if (prices[sell_pos] < prices[buy_pos]) {
//                buy_pos++;
//            }
//            if (sell_pos <= buy_pos) {
//                sell_pos++;
//                continue;
//            }
//            if (prices[sell_pos] - prices[buy_pos] > best)
//                best = prices[sell_pos] - prices[buy_pos];
//            sell_pos++;
//        }
//
//        while (buy_pos < sell_pos) {
//            if (prices[sell_pos] - prices[buy_pos] > best)
//                best = prices[sell_pos] - prices[buy_pos];
//            buy_pos++;
//        }
//        return best;
//    }
//}


// Brute force
// O(n²) time
// O(1) space
//public class Solution {
//    public int MaxProfit(int[] prices) {
//        var best = 0;
//        for(int i =0; i < prices.Length; ++i)
//        {
//
//            for(int j =i+1; j < prices.Length; ++j)
//            {
//                if(prices[j] - prices[i] > best) best = prices[j] - prices[i];
//            }
//        }
//        return best;
//    }
//}
