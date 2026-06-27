// . = white
// # =- black

// while top/bottom white continue removing


var input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

var n = input[0];
var m = input[1];

(int A, int D, int B)[] items = new(int A,  int D, int B)[m];


for (int i = 0; i < m; ++i)
{
    var buff = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    items[i] = (buff[0], buff[1], buff[2]);
}

var birdsChanges  = items.OrderBy(x => x.D);