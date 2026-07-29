// Good approach
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach (string item in strs) {
            int[] count = new int[26];

            foreach (var c in item) {
                count[c - 'a']++;
            }
            var key = string.Join(".", count);

            if (!dict.ContainsKey(key))
                dict[key] = [];
            dict[key].Add(item);
        }
        return dict.Values.ToList();
    }
}



// Valid solution O(N*M*logN)
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 1)
            return [strs.ToList()];

        Dictionary<string, List<string>> dict = new();
        foreach (string item in strs) {
            var orderItem = string.Concat(item.OrderBy(c => c));
            if (!dict.ContainsKey(orderItem))
                dict[orderItem] = [];
            dict[orderItem].Add(item);
        }

        return dict.Values.ToList();
    }
}
