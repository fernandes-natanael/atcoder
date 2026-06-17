var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

var n = input[0];
var d = input[1];
long[] items = new long[1_000_001];
//long[] items = new long[50];

long ans = 0;
long count = 0;
for (int i = 0; i < n; ++i)
{
    var inp =  Console.ReadLine()!.Split().Select(long.Parse).ToArray();
    var max = inp[1] - d;
    if (inp[0] > max) continue;
    items[inp[0]]++;
    items[max + 1]--;
}

for (int i = 0; i < items.Length; ++i)
{ 
    count +=  items[i];
    ans += count * (count - 1) / 2;
    //Console.WriteLine($"{i}: {items[i]} count = {count} comb={count * (count - 1) / 2} ans {ans}");
}

Console.WriteLine(ans);