public class Solution {
    public bool IsPalindrome(string s) {
        var stb = new System.Text.StringBuilder();
        foreach (var c in s.ToLower()) {
            if (char.IsLetterOrDigit(c))
                stb.Append(c);
        }
        var half = stb.Length >> 1;
        for (int i = 0, j = stb.Length - 1; i < half; ++i, --j) {
            if (stb[i] != stb[j])
                return false;
        }
        return true;
    }

    public bool IsPalindrome2(string s) {
        for(int i = 0, j = s.Length-1; i < j; ++i)
        {
            if(!char.IsLetterOrDigit(s[i])) continue;

            while(!char.IsLetterOrDigit(s[j])) --j;

            if(char.ToLower(s[i]) != char.ToLower(s[j]))return false;
            --j;
        }   
        return true;
    }

}
