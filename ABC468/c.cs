
int n = int.Parse(Console.ReadLine()!);

int[] less = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int[] bigger = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int[] start = new int[n];

for(int i = 0; i < n; i++)
{
    start[i] = i+1;
}

static bool Bigger(int[] f, int[] s)
{
    for(int i = 0; i < f.Length; ++i)
    {
        if(f[i] > s[i]) return true;
        if(f[i] < s[i]) return false;
    }

    return false;
}


static long GeneratePermutations(int[] array, int start, int end, int[]less, int[]bigger)
{
    if (start == end)
    {
        // foreach(var it in array)
        // {
        //     Console.Write($"{it}. ");
        // }
        // Console.WriteLine();

        if(Bigger(array, less) && Bigger(bigger, array)){
            // foreach(var it in array)
            // {
            //     Console.Write($"{it}, ");
            // }
            // Console.WriteLine();
            return 1L;
        }
        return 0L;
    }

    long total = 0L;
    
    for (int i = start; i <= end; i++)
    {
        Swap(ref array[start], ref array[i]);
        total += GeneratePermutations(array, start + 1, end, less, bigger);
        Swap(ref array[start], ref array[i]);
    }
    return total;
}

static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}



Console.WriteLine(GeneratePermutations(start, 0, start.Length-1, less, bigger));