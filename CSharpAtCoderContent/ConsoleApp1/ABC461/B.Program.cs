// var input = int.Parse(Console.ReadLine()!);
//
// int[] claim = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
// int[] real = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
//
// Dictionary<int, int>  realGroup = new Dictionary<int, int>();
//
// for (int i = 0; i < input; ++i)
// {
//     realGroup.Add(i+1, claim[i]);
// }
//
// for (int i = 0; i < input; ++i)
// {
//     var exp = realGroup.GetValueOrDefault(real[i]);
//     if (exp != i+1)
//     {
//         Console.WriteLine("No");
//         return;
//     } 
// }
//
// Console.WriteLine("Yes");
