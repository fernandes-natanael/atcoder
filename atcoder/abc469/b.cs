var _ = Console.ReadLine();
var inp = Console.ReadLine();
int res = 0;
for( int i = 0 ; i < inp.Length; ++i)
{
    if((i-1 < 0  ||  inp[i-1] == 'x') && ((i+1 >= inp.Length  ||  inp[i+1] == 'x')) && inp[i] == 'x')
    {
        res++;
    }
}

Console.WriteLine(res);