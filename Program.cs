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

foreach (var line in input.Split(Environment.NewLine))
{

}

var sampleRaces = new List<Race> {
    new Race { Time = 7, Distance    = 9},
    new Race { Time = 15, Distance    = 40},
    new Race { Time = 30, Distance    = 200},
}

Console.WriteLine(result);

timer.Stop();
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();

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
    public int Time { get; set; }
    public int Distance { get; set; }
}