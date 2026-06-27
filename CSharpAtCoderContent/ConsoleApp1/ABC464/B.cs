namespace ConsoleApp1.ABC464;

public class B
{
    public static void Ans()
    {
        // . = white
// # =- black

// while top/bottom white continue removing


        var input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        var n = input[0];
        var m = input[1];


        var ignoreTop = 0;
        var stopBttm = n;
        var startLeft = 0;
        var stopRight = m;

        char[,] matrix = new char[n,m];

        for (int i = 0; i < n; ++i)
        {
            var buff = Console.ReadLine()!;
            for ( int k = 0; k <  m; ++k)      
            {
                matrix[i,k] = buff[k];
            }
        }

        for (int i = 0; i < n; ++i)
        {
            var skip = false;
            for (int k = 0; k < m; ++k)
            {
                if (matrix[i, k] != '.')
                {
                    skip = true;
                    break;
                }
            }
            if (skip) break;
            ignoreTop++;
        }
// Console.WriteLine(ignoreTop);


        for (int i = n-1; i > 0; --i)
        {
            var skip = false;
            for (int k = 0; k < m; ++k)
            {
                if (matrix[i, k] != '.')
                {
                    skip = true;
                    break;
                }
            }
            if (skip) break;
            stopBttm--;
        }
// Console.WriteLine(stopBttm);


        for (int i = 0; i < m; ++i)
        {
            var skip = false;
            for (int k = 0; k < n; ++k)
            {
                if (matrix[k, i] != '.')
                {
                    skip = true;
                    break;
                }
            }
            if (skip) break;
            startLeft++;
        }
// Console.WriteLine(startLeft);



        for (int i = m-1; i >= 0; --i)
        {
            var skip = false;
            for (int k = 0; k < n; ++k)
            {
                if (matrix[k, i] != '.')
                {
                    skip = true;
                    break;
                }
            }
            if (skip) break;
            stopRight--;
        }

// Console.WriteLine(stopRight);

        for (int i = 0; i < stopBttm; ++i)
        {
            if (ignoreTop > 0)
            {
                ignoreTop--;
                continue;
            }
    

            for (int k = startLeft; k < stopRight; ++k)
            {
                Console.Write(matrix[i, k]);
            }
            Console.WriteLine();
        }








    }
}