
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
var restoX = input[0] % 16;
var restoY = input[1] % 9;
if (restoX == 0 && restoY == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}