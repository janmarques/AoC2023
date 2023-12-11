﻿using System.Xml.Linq;

var input =
@"...........#...............................................#...................#.....#.............#........................................
..................#..................................#..................#.....................#................#...................#.......#
....#........................................................................................................................#..............
..............................#........#..................................................#.................................................
.............#........#...........................#..........................#..............................#...............................
......................................................................................................#.............#.......................
...........................................................#......................#........................................#................
.........#.....................................#.......................#..................................................................#.
..................#.......#....................................................................#...................................#........
#..........................................#...............................................................#......#.........................
..................................................#.........................................................................................
..............................................................#.....#....................#..................................................
......#..............................#......................................................................................................
...............................................#......#.................#..........#................................#.......................
..............................................................................#........................#.................................#..
.............#....................................................................................#............................#............
.......................#.............................................#......................................................................
...............................#....................#.........................................#.....................................#.......
..........#.................................................................................................#...............................
..........................................................................#.......#..........................................#..............
...#..............................#............................#....................................#..................#....................
..................#..........................#....................................................................................#.........
.........................#.........................#.......#..........#...................#.................................................
........#.....#.............................................................#...................#........#..................................
..............................#.........#......................................................................................#......#.....
......................................................#......................................................#..............................
....................................................................................................#.......................................
.............................................................#.......#.....................#.......................#...............#........
..#...................#......................................................................................................#..............
......................................#..........................#.....................#....................................................
.............#..............................................................................................................................
...............................#.................#.........................#...................#..............#.............................
........................#...........................................................#................................................#......
........................................#................................................#..........#......................................#
......................................................................#............................................#......#.................
............................................................................................................................................
...........#................................................#.................................#.............................................
.....................................#......#...............................................................................................
....#............#..................................................#.............#....................#..........................#.........
............................................................................................................................................
.......................#.....#...........#............................................................................#..................#..
.......#................................................#...............................#......#............................................
...................................#...........................#...........#....................................#...........................
#.............................................................................................................................#.............
...............................#...........................#......................#.......................#.................................
............#.............#..................#..............................................................................................
....................................................#...............#........#.........#...........................................#........
...............................................................................................................#......#...................#.
.......#.............#..............#.......................................................................................................
.............................................................................................................................#..............
............................................................................................................................................
.................#............#...............................#.......#......................#..........#...............#...................
........................#..........................................................#................................................#.......
.#.................................................#........................................................................................
...........#.................................#.....................................................#........................................
......................................#.....................................................................#......#........................
.......#............#...................................................#.............................................................#.....
...............#.....................................#........#...............#............................................#...............#
...................................................................#....................#...................................................
.................................................#..........................................................................................
..................#........................#..................................................#.......#...............#.....................
............................................................................................................................................
......#...........................#..............................#..........................................................#...............
...........................................................#.....................................................#..........................
...........................#........................#..............................................................................#......#.
...........#..............................................................#..................................#..............................
..........................................#.................................................................................................
...#..........................................................#.........................#.......................................#...........
........................................................#......................#..........................#..........................#......
.......................#.............................................#.............................#........................................
.......................................................................................................................#....................
......#......#....................#.........................................................................................................
...............................................................#............#......#.....#..............#..........#..........#.............
.#...............#.....................#......#.....#.......................................................................................
...................................................................#.........................#...........................................#..
............................................................................................................................................
...........................................#...........................#..............................#.....................................
......#....................................................#....................#..............................#....................#.......
......................#.......#....................#........................................................................................
............#.................................#................#...............................#....................#.......................
.......................................#.................................................................................................#..
............................................................................................................................................
...#.....................#.........................................#...................#....................#....................#..........
.................#..............#.....................................................................................................#.....
...........................................................................#....................#.................#.........................
.......#...................................................................................#................................................
............#..........#....................................................................................................................
......................................................................#.......#.............................................#...............
........................................................................................................#...................................
....#.........................................................#.............................................................................
..........#....................#....................#......................#..................#......................#......................
#...............#...................#.........#..........#...................................................#..............................
...................................................................................................................................#........
............................#.........................................................#.....................................................
..........................................#...................................#.............................................................
...#.................................................#.................................................................#.....#.............#
......................#............#................................#...............................#.............#..................#......
.........................................................................................................#..................................
............#.....................................#.......................#...............#...................#.............................
.#....................................#.....#....................................................................................#..........
........#........................................................#..........................................................................
...................#........#............................#.............................#..............................#.....................
..............................................................................................................................#.............
....................................................#..........................#............................................................
........................#.......................................................................#............#............................#.
..........................................#................................................................................#................
..................#..........................................#.........................................#..............................#.....
.............#...................................#..................#........................#..............................................
.............................#...........................#......................#..................#........................................
...................................#................................................................................#........#..............
......#.................................................................#..............#....................................................
.................#.........................................................................................#................................
............................................................................................................................................
...........................#...........#.........................................#...................#................#............#.....#..
.#..........................................................................................#...............................................
.....................#............................#.....#...................#....................................#..........................
.............................................#.................#......................#.....................................................
...................................#................................#.......................................................................
......................................................................................................#.....................................
......#.....#....................................................................................#.............................#.....#......
.......................#...................#........#......................................#................................................
.............................................................................................................#..............................
#................#..........#........#..........#.......#......#........................................................................#...
.....................................................................#.........#........#.....#......#.................#....................
................................#...........................................................................................................
.........................#..............#....................................................................................#..............
..........#.................................................................................................................................
..........................................................................................#........#........................................
.................#...................#..........#.......#......#...................................................#...............#........
............................................................................................................................................
.............................#................................................................#.............................................
...#.......#................................................................#........#...................#............#.........#..........#
........................#.................#................#................................................................................
.....................................................................#.....................................................#................
....................................................#............................#......................................................#...
.#..........................................................................................#......#...............#..............#.........
............................................................................................................................................
..........#........#............#.........................................................................#.................................
........................................................#..........#........................................................................
.....#.............................................#.........#....................#.............................#.........#.................";

var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0L;
var byLine = input.Split(Environment.NewLine);
var width = byLine[0].Length;
var emptyRows = input.Split(Environment.NewLine).Select((x, i) => (x, i)).Where(x => x.x.All(y => y == '.')).Select(x => x.i).ToList();
var emptyColumns = Enumerable.Range(0, width).Where(x => byLine.All(y => y[x] == '.')).ToList();

var nodes = new List<(int x, int y)>(byLine.Length);
for (int i = 0; i < byLine.Length; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (byLine[j][i] == '#')
        {
            foreach (var node in nodes)
            {
                var (xMin, xMax) = node.x < i ? (node.x, i) : (i, node.x);
                var (yMin, yMax) = node.y < j ? (node.y, j) : (j, node.y);
                result += yMax - yMin + xMax - xMin;
            }
            nodes.Add((i, j));
        }
    }
}

result += (long)(emptyColumns.Sum(row => nodes.Count(p => p.x < row) * nodes.Count(p => p.x > row)) + emptyRows.Sum(column => nodes.Count(p => p.y < column) * nodes.Count(p => p.y > column))) * 999999;

timer.Stop();
Console.WriteLine(result); // 649862989626 54ms
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();