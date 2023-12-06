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
    new Race { Time = 7, Distance = 9},
    new Race { Time = 15, Distance = 40},
    new Race { Time = 30, Distance = 200},
};


var realRaces = new List<Race> {
    new Race { Time = 46, Distance = 347},
    new Race { Time = 82, Distance = 1522},
    new Race { Time = 84, Distance = 1406},
    new Race { Time = 79, Distance = 1471},
};

var races = sampleRaces;
races = realRaces;

var product = 1;
foreach (var race in races)
{
    for (int i = 1; i < race.Time; i++)
    {
        var distance = i * (race.Time - i);
        if (distance > race.Distance)
        {
            race.Wins++;
        }
    }
    product *= race.Wins;
}

Console.WriteLine(product);

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
    public int Wins { get; set; }
}