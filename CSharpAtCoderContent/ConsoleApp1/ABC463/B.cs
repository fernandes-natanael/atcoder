namespace ConsoleApp1.ABC463;

public class B
{
    public static void Ans()
    {
        var input = Console.ReadLine().Split().ToArray();

        var n = int.Parse(input[0]);
        var col = char.Parse(input[1]);
        var hasSeatInColumn = false;
        var str = "ABCDE";
        int pos = 0;
        foreach (var c in str)
        {
            if  (c == col)
            {
                break;
            }

            pos++;
        }

        for (int i = 0; i < n; ++i)
        {
            var item = Console.ReadLine()!;
            if (item[pos] == 'o')
            {
                hasSeatInColumn = true;
                break;
            }
    
        }

        Console.WriteLine(hasSeatInColumn ? "Yes" : "No");
    }
}