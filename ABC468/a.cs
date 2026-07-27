var n = int.Parse( Console.ReadLine()!);

int[] arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int sum = 0;

for( int i = 1; i < arr.Length - 1; ++i)
{
    // Console.WriteLine($"1 {arr[i-1]}");
    // Console.WriteLine($"2 {arr[i]}");
    // Console.WriteLine($"3 {arr[i+1]}");

    if(arr[i] > arr[i-1]  && arr[i] > arr[i+1]) sum++;
}

Console.WriteLine(sum);