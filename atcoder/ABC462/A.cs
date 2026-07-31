var input = Console.ReadLine();
foreach (var c in input)
{
    if (char.IsDigit(c))
    {
        Console.Write(c);
    }
}
Console.WriteLine();