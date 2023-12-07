//using System.Collections.Generic;

//var fullInput =
//@"";

//var smallInput =
//@"";

//var smallest = "";

//var input = smallInput;
////var input = fullInput;
////var input = smallest;
//var timer = System.Diagnostics.Stopwatch.StartNew();

//var result = 0;

//foreach (var line in input.Split(Environment.NewLine))
//{

//}

//var sampleRaces = new List<Race> {
//    new Race { Time = 71530, Distance = 940200},
//};


//var realRaces = new List<Race> {
//    new Race { Time = 46828479, Distance = 347152214061471},
//};

//var races = sampleRaces;
//races = realRaces;

//var product = 1L;
//foreach (var race in races)
//{
//    for (int i = 1; i < race.Time; i++)
//    {
//        var distance = i * (race.Time - i);
//        if (distance > race.Distance)
//        {
//            race.Wins++;
//        }
//    }
//    product *= race.Wins;
//}

//Console.WriteLine(product);

//timer.Stop();
//Console.WriteLine(timer.ElapsedMilliseconds + "ms");
//Console.ReadLine();
////28360140
////804ms

//void PrintGrid<T>(T[][] grid)
//{
//    for (int i = 0; i < grid.Length; i++)
//    {
//        for (int j = 0; j < grid[i].Length; j++)
//        {
//            Console.Write(grid[i][j]);
//        }
//        Console.WriteLine();
//    }
//}

//class Race
//{
//    public long Time { get; set; }
//    public long Distance { get; set; }
//    public long Wins { get; set; }
//}