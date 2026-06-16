namespace ConsoleApp1.ABC462;

public class C
{
    public static void Answer()
    {
        // Nessa resolucao temos N quantidade de pontos
// n existem pontos com x duplicado ou y
// exemplo (1,2) e (1,3) nao eh valido, pois o eixo 1 nao pode possuir 2 pontos

        int N = int.Parse(Console.ReadLine()!);

        List<(int x, int y)> points = new();
        int answer = 1; // menor x sempre eh valido

        for (int i = 0; i < N; ++i)
        {
            var items = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            points.Add((items[0], items[1]));
        }
        var sortedPoints = points.OrderBy(i => i.x);
        int minY = sortedPoints.First().y;

        foreach (var point in sortedPoints)
        {
            if (point.y < minY)
            {
                answer++;
                minY = point.y;
            }
        }

        Console.Write(answer);
    }
    
    public static void TLE_Answer()
    {
        int N = int.Parse(Console.ReadLine()!);

        HashSet<(int x, int y)> points = new();
        HashSet<(int x, int y)> validPoints = new();
        Dictionary<int, HashSet<int>> xRelation = new();
        Dictionary<int, HashSet<int>> yRelation = new();

        for (int i = 0; i < N; ++i)
        {
            var items = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            points.Add((items[0], items[1]));
            if (!xRelation.ContainsKey(items[0]))
            {
                xRelation[items[0]] = new HashSet<int>();
            }
            if (!yRelation.ContainsKey(items[1]))
            {
                yRelation[items[1]] = new HashSet<int>();
            }
            xRelation[items[0]].Add(items[1]);
            yRelation[items[1]].Add(items[0]);
        }

        foreach (var point  in points)
        {
            var validX = true;
            var validY = true;
            for (int i = 1; i < point.x; ++i)
            {
                if(!xRelation.ContainsKey(i)) continue;
                validX = xRelation[i].All(el => el > point.y);
                if (!validX) break;
        
            }
            for (int i = 1; i < point.y; ++i)
            {
                if(!yRelation.ContainsKey(i)) continue;
                validY  = yRelation[i].All(el => el > point.x);
                if (!validY) break;
            } 
            //Console.WriteLine($"({point.x},{point.y}):  {validX}, {validY}");
            if (validX && validY)
            {
                validPoints.Add(point);
            }
        }

        Console.Write(validPoints.Count);
    }
}