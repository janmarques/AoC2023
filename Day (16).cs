﻿using AoC2023;
using System.Collections.Generic;
using System.Transactions;

var fullInput =
@"\....|...-...../.....|....................-./............|/.....................-........./.....-.............
\..........-.....................-......................................|....................\..../.....-.....
....\......-...../../../...\......................\.........................-.............|.............|.....
.........../..../...........|/\.............\........\.......|.........|..|../............/.........|.........
\./...\........\..........\......./....../...............................|....|........|................/.....
|-.....|............/...............|...\...|...../......../.....|............|..\..|..../.......-.........\..
........-.............||../..........|.........../..................../.|.....|\..-/......./...\...\....-.....
....................//........................./..........\.......|...|.........../......\-......-...\........
....../..........\......\.....................\................\......\..\..|.................................
.................\...............-....../........./....-./..........|..../..-..|../................\..........
.............-...............-......|.../.....-.....//.\................../..........-......-...........-.....
.........../.\.....................\............-..........|.......\..................\.......................
...............\............/.|...\........../....\.............|...........\...............|.../........\....
./..............\................-\.../\.......-....................-..............-|.............\.-.........
../....../.........|..../......\...\.\.................|......./.......|...............-.........-............
-...-............................\.............-.\........-.....|.........././-......|......-..../...|........
................-.....................|..|...\.././.............|..........................-.............-....
.......|...............................|.......................................-......../.............|-...-..
.\|............................\................|.....-.....-................................./...-..\...../..
.......\......-....\|......|........................................./...||...............\...................
.................../......../.......-......\..............|..\...........-.........-.............../..........
........................\......................../.................-........................\.....\...........
..........|......|........................|.|\...............\...|.............-...-....-............--.......
............|........../....\..........\........../..-..|...........-...\........................./..-........
.............||../..../.......................-/.......\.....\............./|..-...............|.....|........
................................|..\.........-......./...........-../-............\................\....-../..
.............-.............................|.\...............................\\...............................
..|.......-................................\.......|.......\.....................|../\..........\..........-..
......-..\..........-.................\.-..../\......./......./..-.......................\.....-........\.....
............................../.....................\.................\................|..../\.............\..
..............................-.......\.........-..........\....../............./.....-........\...-.........|
/..................\...||..|...........\...............-............\..........|./.....-.-./.............../..
.....|......./...............\.......-................-...........................................\...........
.|.................../.....\............./.....\.................-.../.......-..............\..-..............
......\........|...|...........//..........|\.\..............................-..../...-............|..........
|......\....|\......|........../.........../........-.........|.-\//................/..\....|.../........|....
.-....-......................./.........\.........-.../............................-..|........|.....|...|....
.........-..................-..........-....-....................-....-./.......................|.../......\..
..-../......................-\.....|...\........./.-...............-.................../../............|......
.-/.......-../.......-...|\...../..........-...\.......\.........-....\-................-......|........-.....
.............................\\\............-..............|........../...................-......../....../../
.....-....\....\......................-..\...............-..|...............-................-.......\......|.
..-...\.............................../.../.............................--.......-..|.|\...../...............\
......\.../...-.....|....|......\.../|...................................-................-................./.
.......-......-.../..................|../..................\..........................\-..........-\..........
.-.......\.........|....|\/./-\.-.....|..................-...................................-|...\...........
...........-........../\..................\./..........................\...../...........-...\...../..\....-..
..-.|...../|......\..\........|.............-.....|..........\...-...-../......................../.......|....
......../................/..\.......\..-...|.....\.......|\..........................-..\../..........\./.....
........\.-......|......|..........|........-...................-..\.....-./..............-.\......\..........
........|./..................\........|......................\............................./.-\....\........-.
........\.|......\................/..\....-/.\.....-.....|............................\..\.|............|...-.
...-.....-|..................|...............-./.....................\..\............|.....-..................
..........|\./.....\..................|.........|.....................-\./..\........\........................
../........\..............|....-...............................................|..........-......../..........
..\..............|...../../....................-....\.....................|........\...\\.....................
...........................-...\......\......./../..........\-...../.......................-...........\......
-.|........................../.....|...............\..........-.............\...-................-.......-....
/../.........\........./......-.../..-..................-.......................\............--...............
\...............|......-..../......................................-........./|......................\|....../
.....\.......................................-...................-.../...........\.......|../.............|...
....-....||......\..\.......-.........-......../..../............\..................................-.........
...-..|.......\..\..|..........-../-..........\............../...............|..../........./....../.......|./
.......................\.......././.............\..................-..........|................../....|.......
-.|.....................\\.........../......./.|................/................|./......./....-.............
......-...............-....-................|./\..\-/...../......../....-....\....|.-.................../...\.
...............\......-...\...\....-....-/....................\./....../..................-|........\./...../.
.\......................./..\.........\.........|............|.......-../..\.-..|.-..........................|
..|../.....................|/......................./......../.../.........-.../.|./.|.-..............|....-..
...-.-/............/............|..........|....../\...\./.....|..................|....\............/.........
.....|........./.........\.............../......./../../...................|.......//.......\..\..........\...
......./.............\...........\.\..............................................\...................|.......
...............-|...../..-............................\.....-.............../\.........-....................\.
.........-.....................-...\...................-..../.................||....\.........-.......-..-....
.|../..\...\......|..\./.........\..............|..\/......../...............-..-....................-.....\..
..................|........\.-.....|.......\............../................................/...-....|...../...
...........-......./........-...--........\.../..-...../.|............|......./...............|....../\......\
.../.....\...................-..../....................................-......................|.............-.
.\.....|....-.....|.....-...................................................|../....\..................\.....-
....-........../\......../.......-....\............................./-.............-..........................
....\.........-........./......../....|..............\........\../.................\.|...............\........
.........-..............|./............-.......................\.......\......-\......\......../..............
-.|...|./-..........\..........-...-............|...-......................\..\.............................-.
............/......................../.........................................\/..........|.....|.-........|/
....../..|./..././.....-......................../....|................../..|........-.....................|./.
.......................\....................../......./......\/........\......./....../\|.....\...............
\...........\/.|../..................../...............\\...\..../..................\......./.................
.../................/...............\./....-./........../........./\..-.................................\.....
........-.......-...........\........-.......\............|............|.....-........|..|..../...............
.............|...|............/....\............................................-..\......./.../..........\...
...................../-..|...........-................../.\...|.....\.....|/.................|................
..|................\.....-...........|.\............-.........|....../...................\......-.|.......\...
........\......../.....-...\..\...........\........|/.............../......|.......|.\..|........|............
..........\.....................-..|/.....\............-............../.......................|./........\....
.......\........|...........\......\.......-..-.....|............./......|\..............................|....
.........\.......................-............-/.................................\............|...............
.........\................/.............................../..........\................-../../......|......-...
....\...-./...............\...............|.....\|....|/...............-...........................-..........
.|.......\.......-............./.......\............./....................|......|../......-...........\......
.....\.....-.....\...\................/......\...\../.\...\....\-....-././...............................|./..
.....................-.\.\.........../......./...-......./-.........................\.......|../....\..|..../.
|..\......./-......-...../..-....../.................../..-.....................-..../...........\...../......
......................................./................|....\/....\............/....../......................
......................../..........|........-............|.........................|.\................|....../
-.............-...|...........-....-..-.|\.......|......\..........-......|-...-......\.......................
...........\.\\.../.................\..........\..-......-......|.-............................-.||...|....../
....|................--........|.|..........|......\.............................................-............
.-..|................/../..-.........................../...../.....\.../....-.....\-..................../.....
............./|..........................\...................................-..-..........|....\..|..........
....|...../........./.-....-..................../.........../....................-................\./.........";

var smallInput =
@".|...\....
|.-.\.....
.....|-...
........|.
..........
.........\
..../.\\..
.-.-/..|..
.|....-|.\
..//.|....";

var smallest = "";

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();
(_, int height, int width) = Utils.Parse2DGrid(input);

var result = 0l;

var top = Enumerable.Range(0, width).Select(x => (x, 0)).ToArray();
var bottom = Enumerable.Range(0, width).Select(x => (x, height - 1)).ToArray();
var left = Enumerable.Range(0, height).Select(x => (0, x)).ToArray();
var right = Enumerable.Range(0, height).Select(x => (width - 1, x)).ToArray();
var sides = top.Union(bottom).Union(left).Union(right);

foreach (var dir in new[] { 'N', 'E', 'S', 'W' })
{
    foreach (var side in sides)
    {
        result = Math.Max(result, CheckEntry(side.Item1, side.Item2, dir));
    }
}



timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();

long CheckEntry(int x, int y, char dir)
{

    (char[][] grid, int height, int width) = Utils.Parse2DGrid(input);
    var energized = grid.Select(x => x.Select(y => false).ToArray()).ToArray();
    long result;
    var todo = new List<(int, int, char)>() { (x, y, dir) };

    var evaluated = new HashSet<(int, int, char)>();

    while (todo.Any())
    {
        var newTodo = new List<(int, int, char)>();
        foreach (var i in todo)
        {
            evaluated.Add(i);
            var next = Traverse(i.Item1, i.Item2, i.Item3, width, height, grid, energized).Where(x => !evaluated.Contains(x)).ToList();
            newTodo.AddRange(next);
        }
        todo = newTodo;
    }
    result = energized.Sum(x => x.Count(y => y));
    return result;
}

IEnumerable<(int, int, char)> Traverse(int x, int y, char dir, int width, int height, char[][] grid, bool[][] energized)
{
    if (x < 0 || y < 0 || x >= width || y >= height) { yield break; }
    energized[y][x] = true;
    if (grid[y][x] == '.')
    {
        switch (dir)
        {
            case 'E': yield return (x + 1, y, dir); break;
            case 'W': yield return (x - 1, y, dir); break;
            case 'N': yield return (x, y - 1, dir); break;
            case 'S': yield return (x, y + 1, dir); break;
        };
    }
    else if (grid[y][x] == '-')
    {
        switch (dir)
        {
            case 'E': yield return (x + 1, y, dir); break;
            case 'W': yield return (x - 1, y, dir); break;
            case 'S':
            case 'N':
                yield return (x + 1, y, 'E');
                yield return (x - 1, y, 'W');
                break;
        };
    }
    else if (grid[y][x] == '|')
    {
        switch (dir)
        {
            case 'W':
            case 'E':
                yield return (x, y - 1, 'N');
                yield return (x, y + 1, 'S');
                break;
            case 'N': yield return (x, y - 1, dir); break;
            case 'S': yield return (x, y + 1, dir); break;
        };
    }
    else if (grid[y][x] == '\\')
    {
        switch (dir)
        {
            case 'E': yield return (x, y + 1, 'S'); break;
            case 'W': yield return (x, y - 1, 'N'); break;
            case 'N': yield return (x - 1, y, 'W'); break;
            case 'S': yield return (x + 1, y, 'E'); break;
        };
    }
    else if (grid[y][x] == '/')
    {
        switch (dir)
        {
            case 'E': yield return (x, y - 1, 'N'); break;
            case 'W': yield return (x, y + 1, 'S'); break;
            case 'N': yield return (x + 1, y, 'E'); break;
            case 'S': yield return (x - 1, y, 'W'); break;
        };
    }
    //var cpy = grid.Select(x => x.ToArray()).ToArray();
    //cpy[y][x] = '*';
    //Console.Clear();
    //Utils.PrintGrid(cpy);
}