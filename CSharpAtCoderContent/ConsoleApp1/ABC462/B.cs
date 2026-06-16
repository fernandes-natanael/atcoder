namespace ConsoleApp1.ABC462;

public class B
{
    public static void Answer()
    {
        int N = int.Parse(Console.ReadLine()!);

        Dictionary<int, HashSet<int>> dict = new();

        for (int i = 0; i < N; ++i)
        {
            var buffer = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            foreach(var k in buffer.Skip(1))
            {
                if (!dict.ContainsKey(k))
                {
                    dict[k] = new HashSet<int>();
                }
                dict[k].Add(i+1);
            }   
        }

        for (int i = 1; i <= N; ++i)
        {
            if (!dict.ContainsKey(i))
            {
                dict[i] = new HashSet<int>();
            }
        }

        var res = dict.OrderBy(x => x.Key);
        foreach (var item in res)
        {
            if (item.Value.Count != 0)
            {
                Console.WriteLine($"{item.Value.Count} {string.Join(" ", item.Value) }");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}