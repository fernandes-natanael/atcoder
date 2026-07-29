List<List<string>> GroupAnagrams(string[] strs) {
    if(strs.Length == 1) return [strs.ToList()];

    Dictionary<string, List<string>> dict = new ();
    Array.Sort(strs);
    foreach(string item in strs)
    {
        var orderItem = string.Concat(item.OrderBy(c => c));
        if(!dict.ContainsKey(orderItem)) dict[orderItem] = [];
        dict[orderItem].Add(item);
    }
    
    return dict.Values.OrderBy(c => c.Count).ToList();
}

var tmp = GroupAnagrams(["act","pots","tops","cat","stop","hat"]);

foreach(var i in tmp)
{
    foreach(var j in i)
    {
        Console.Write($"{j}, ");
    }
    Console.WriteLine();
}

//  GroupAnagrams(["x"]);
