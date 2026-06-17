namespace ConsoleApp1.ABC462;

public class D
{
    public static void Answer()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var n = input[0];
        var d = input[1];
        long[] items = new long[1_000_001]; // define  uma matrix com todos os items iniciais igual a 0 com tamanho maximo de horarios possiveis 10v6
//long[] items = new long[50];

        long ans = 0;
        long count = 0;
        for (int i = 0; i < n; ++i)
        {
            var inp =  Console.ReadLine()!.Split().Select(long.Parse).ToArray();
            var max = inp[1] - d;
            if (inp[0] > max) continue; // chega se o horario maximo de inicio e menor que o horario que a pessoa chegou. caso seja desconsidere como suspeito
            items[inp[0]]++; // marca que a partir daqui deve-se contabilizar este suspeito
            items[max + 1]--; // marca que a partir desse horario nao deve contabilizar esse suspeito
        }

        for (int i = 0; i < items.Length; ++i)
        { 
            count +=  items[i]; // contabilziando as possibilidades naquele periodo
            ans += count * (count - 1) / 2; 
            // somatorio dos combinatorios usando combinacao simples Cc,2 (2 porque sei que estou procurando combinacao de 2 suspeitos)
            // Sera a resposta
            //Console.WriteLine($"{i}: {items[i]} count = {count} comb={count * (count - 1) / 2} ans {ans}");
        }

        Console.WriteLine(ans);
    }
    
    public static void AnswerBruteForce()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var n = input[0];
        var d = input[1];

        List<(long S, long T)> culprits = new();
 
        for (int i = 0; i < n; ++i)
        {
            var inp =  Console.ReadLine().Split().Select(int.Parse).ToArray();
    
            if(inp[1] - inp[0] < d) continue;
    
            culprits.Add((inp[0], inp[1]));
        }

// culprits.Sort((a, b) => a.S.CompareTo(b.S));

        long ans = 0;
        for (int i = 0; i < culprits.Count; ++i)
        {
            for (int k = i+1; k < culprits.Count; ++k)
            {
                if(i == k) continue;

                var startLimit = long.Max(culprits[i].S, culprits[k].S);
                var endLimit = long.Min(culprits[i].T, culprits[k].T) - d; // o -d ocorre para que eu saiba qual o ultimo periodo que pode comecar o assassinato
                //Console.WriteLine($"{i}: {startLimit} > {endLimit}");
        
                ans += long.Max(0L, endLimit - startLimit + 1);
            }
    
        }

        Console.WriteLine(ans);
    }
}