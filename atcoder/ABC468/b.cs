int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
var m = input[0];
var d = input[1];

var str = Console.ReadLine()!;
Dictionary<int, bool> ceils_guarded = new();
var is_guarder = 0;

for(int i = 0; i < str.Length; ++i)
{
    if(str[i] == 'G')
    {
        var guard_back=d+1;

        for(int j = i; guard_back != 0 && j >=0; j--)
        {
            guard_back--;
            ceils_guarded[j]=true;
        }
        is_guarder=d;
    } else
    {
        if (is_guarder != 0 )
        {
            // Console.WriteLine(i+1);
            ceils_guarded[i] = true;
            is_guarder--;
            continue;
        }
    }
}

// foreach(var tmp in ceils_guarded.OrderBy(a => a.Key))
// {
//     Console.WriteLine($"{tmp.Key+1}: {tmp.Value}");
// }

Console.WriteLine(str.Length - ceils_guarded.Count());