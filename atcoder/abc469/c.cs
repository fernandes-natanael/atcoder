var n = int.Parse(Console.ReadLine());
var s = Console.ReadLine();
int res = 0;
for( int count = 0 ; count < n; ++count)
{
    for(int i = res; i < s.Length; ++i)
    {
        res++;
        if(s[i] == 'x') break;
    }

    Console.WriteLine(res);
}