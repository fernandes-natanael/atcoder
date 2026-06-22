namespace ConsoleApp1.ABC463;

public class C
{
    public static void TLE()
    {
        var n = int.Parse(Console.ReadLine()!);
        Dictionary<int, int> dict = new();


        for (int i = 0; i < n; ++i)
        {
            var entries = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            if (!dict.ContainsKey(entries[1]))
            {
                dict.Add(entries[1], entries[0]);
            }
            var actual = dict[entries[1]];
            if (entries[0] > actual)
            {
                dict[entries[1]] = entries[0];
            }
        }


        var q = int.Parse(Console.ReadLine()!);
        var list = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        foreach (var quer in  list)
        {
            var bAct = -1;

            foreach (var i in dict)
            {
                if(quer >= i.Key) continue;
                if (i.Value > bAct) 
                {
                    bAct = i.Value;
                }
            }
            Console.WriteLine(bAct);

        }
    }
}