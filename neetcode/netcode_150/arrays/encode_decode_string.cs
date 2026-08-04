
public class Solution {

    public string Encode(IList<string> strs) {
        var stb = new StringBuilder();
        foreach(var s in strs)
        {
            stb.Append($"{s.Length}|{s}");
        }
        return stb.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> str = new();
        int i = 0;
        while(i < s.Length) {
            var j = s.IndexOf("|", i);
            int len = int.Parse(s[i..j]);
            str.Add(s[(j+1)..(j+len+1)]);
            i = j+len+1;
        }
        return str;
    }
}
