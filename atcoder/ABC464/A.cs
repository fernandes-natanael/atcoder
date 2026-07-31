
var input = Console.ReadLine()!;
Dictionary<char, int> map = new();
foreach (var c in input)
{
    if (!map.ContainsKey(c)) map[c] = 1;
    else map[c]++;
}
var list = map.ToList();
var biggest = list.OrderByDescending(x => x.Value).First();
switch (biggest.Key)
{
    case 'E':
        Console.WriteLine("East");
        break;
    case 'W':
        Console.WriteLine("West");
        break;

}