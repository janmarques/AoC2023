using System.Collections.Generic;

var fullInput =
@"";

var smallInput =
@"";

var smallest = "";

var input = smallInput;
//var input = fullInput;
//var input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0;

var T = 46828479;
var D = 347152214061471;

var disc = Math.Sqrt(Math.Pow(T, 2) + 4 * D);
var zero1 = (T + disc) / 2;
var zero2 = (T - disc) / 2;

for (long i = 1; i < 46828479; i++)
{
    var distance = i * (46828479 - i);
    if (distance > 347152214061471)
    {
        result++;
    }
}

Console.WriteLine(result);

timer.Stop();
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();
//28360140
//804ms

void PrintGrid<T>(T[][] grid)
{
    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[i].Length; j++)
        {
            Console.Write(grid[i][j]);
        }
        Console.WriteLine();
    }
}

class Race
{
    public long Time { get; set; }
    public long Distance { get; set; }
    public long Wins { get; set; }
}