// 
public class Solution {
    public int MinimumPushes(string word) {
         int[] freq = new int[26];
        var res =0;
        foreach(var c in word) {
            freq[c - 'a']++;
        }
        Array.Sort(freq);
        var multi = 1; 
        var used_letters = 0;
        for(int i = 25; i >=0 ; --i) {
            var t = freq[i];
            var used = false;
            if (t > 0) { used = true; used_letters++; }
            res += freq[i] * multi;
            if(used && used_letters % 8 == 0) multi++;

        }
        return res;
    }
}



// Brute Force
public class Solution {
    public int MinimumPushes(string word) {
        var count_letters = 0;
        Dictionary<char, int> dict_count = new();
        Dictionary<char, int> dict_input = new();
        var res =0;
        foreach(var c in word) {
            if(!dict_count.ContainsKey(c)) {
                dict_count[c] = 1;
            } else dict_count[c]++;
        }
        var ordered = dict_count.OrderByDescending(c => c.Value);
        foreach(var kv in ordered)
        {
            if(!dict_input.ContainsKey(kv.Key)) {
                if( count_letters < 8) dict_input[kv.Key] = 1;
                else if( count_letters < 16) dict_input[kv.Key] = 2;
                else if( count_letters < 24) dict_input[kv.Key] = 3;
                else dict_input[kv.Key] = 4;

                count_letters++;
            }
        }
        foreach(var c in word) {
            res += dict_input[c];
        }
        return res;
    }
}