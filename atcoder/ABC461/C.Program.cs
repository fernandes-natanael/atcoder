

var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

var N =  input[0];
var K =  input[1];
var M  = input[2];

List<(long v, int c)> gems = new();

//Leitura dos dados
for (int i = 0; i < N; ++i)
{
    var buffer = Console.ReadLine()!.Split();
    var c = int.Parse(buffer[0]);
    var v = int.Parse(buffer[1]);
    gems.Add((v, c));
}

// Ordenacao decrescente
gems.Sort();
gems.Reverse();

long answer = 0;
int count = 0;
HashSet<int> colorsHashSet = new();
// For loopa enquanto n foram somados todsos os items
for (int i = 0; i < N && K != count; ++i)
{
    // Verfica Se cor ja foi escolhida, caso nao escolhe essa para ser usada
    // Caso cor de gema ja tenha sido escolhida
    // Verifico se 
    // (K - count) = quantidade que falta escolher de gemas
    // (M - colorsHashSet.Count) = Quantidade de cores novas que falta para atingir o minimo 
    
    // Resumo: A quantidade de gemas que ainda posso escolher é menor ou igual à quantidade de cores novas que ainda preciso conseguir.
    if (colorsHashSet.Contains(gems[i].c) && K - count <= M - colorsHashSet.Count)
    {
        continue;   
    }
    // Contabiliza valor
    answer += gems[i].v;
    // Soma 1 
    count++;
    
    //Contabiliza cor usada
    colorsHashSet.Add(gems[i].c);
}

Console.WriteLine(answer);

