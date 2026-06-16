namespace ConsoleApp1.ABC462;

public class A
{
    public static void Answer()
    {
        var input = Console.ReadLine();

        foreach (var c in input)
        {
            if (char.IsDigit(c))
            {
                Console.Write(c);
            }
        }

        Console.WriteLine();

    }
}