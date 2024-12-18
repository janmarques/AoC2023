﻿using AoC2023;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks.Dataflow;

var fullInput =
@"O....#.O.#.O...O.O....#.#O....#.#..OO##.......#...O..O......O.OO.OOO.#...##...O...O#O....O..O#......
.....#.....O....O...##OOO#O.O..O..#...OO.#O#.#.O....O#...O##O.........##.........#.....O..O..O...OOO
...#OO#..#...#..O#.#......#.O......#.........O.#...O##....#.#..O..##..O...#......O.O.......##.#O.OO.
OO..##.#...O..O.OO#..#.#...O.O....OO.O.O.O......O#..#O...#.O.....#...........O.....O##..O.#..OO..O..
..O...O.....O..#O.O.....##..#..#..O......#..#.#.O.O#....##.O..O#....#..#....#.##O..#.O..OOO....O.#.#
#..O.OO.....#...#..O...#..O##..O#..O.....O...O..#.#...O.#..O.....OO...##.O.O....#..O..O...#....OO...
......O..O...#.#.....OO.........###O....O..O.##....O#.#.O.#.O.O..#....O.#.O....#.O.O##...O.....#....
..#.O#..O....O...O.O.....#O#.O.OO..#OO..O..#.....#...#.....#.#.##..O##..#.O.O#...O..#.O#OOOO.....O..
O#O.O.O.O.....#......O......O.O..O.OO.O..O#...O.O..OO.O.#.OO.O.#...OO...#.O...O.....#.O##O.....#O#O.
..#.#..O......#....#.#O..O..##OO.....OO.#O.O..O.....#...O...#O....O....O.OO....OO..#.#.##.........#.
O..............O..O.......##.....#..#......#O....##OO........OOOOO......O.O...O#..OO.#.#OO.O#....O.#
#.....#O....O......OO#....##O#..O...O.....OO#...OO...O#.#..OO.OO...O#..O.OO.........#.OO.........O#.
.O.O.#.#O....#...#.O..OO.....O.#.O......O.....O.....#OO..#OOO..#O...#.O.OO...#..O.#O..O...#O.O..#.O.
OOO..#OO#...##..O........####...#O#.....O..#OO.....O.O.......O.....OO.O..OO....O#O.O.#O..O.OO....#..
.O.......#OOO..#.O.OO.O............#....O..O..........O..O....OO......#..#.....O.OOO.#O....O..#.....
#..#...O.O#..OO.O.##..#.O.....O..#.O#...#.O...O#.#..OO.O..#O.O#O#O....#.O.O....#...O...O...#O.#.O.#.
..#..O.O.#...O.##.#O.O..#....O..O.###O.O......##..O..#O.O..O..#..#...###...........O.......#....O...
O.....O###...#.#O.#....#.#OO#...OO##.O#...#O..O...#.O..OO...O..OO.....OOO.......O.O.......#.........
.O#..O.#.OO.O....O.#O...O..#O#O.O....O.#..#O.OO#..#...O.##.O.O.##...#...#O......O..#.#......O##.....
.......O....O#..#....O.O...#.OOO..O.O....O#..O#....OO.O..#...O.##O..#..#O.O....#.#...#O...O.##O.....
..O.#O..O.#O#...O.OOO##.O....#####OO#...#.O.O....O..OO..#..O..O.O.O...O#.O.#......#..#OO......##....
.#.O.O.#.OO#..#..O...O.#.#.OO.#.#.OO...O#....#......OO..O#.#.O............O.OO##.O.O..#..#.....O....
...#.O..O.#.......##..O..#O#...O.........O..#.##O#O#.#O....###..##..#..O#.#........O.......#O.....#.
O#.#O.O..O.....#..O.O.##..........###..#..#O...O.OO#OO...O..O.....O#..OO#O.........#.#O..........#..
..O.O...O......O...#.....O.#..O.O.....OO#.#.#.OO...OO...#........O##O....OOOO...O.O......O..#O..O##.
..O#...O........O.#...##.O.O...O...#...O.##..#O..OO..#....##.#O..#O..OOO......O#.OO#.#.#...........O
.OO#.#.....O.......#O.##O...#.......O.#..OO##OO.O...##........#.O.#.#...#.#O....#..#......#..#......
..###..#.#O.....O..O.#.OO...#O.#.#...#...O#....#.O.##.#.#....##.#.O#.O.#.##..O..O......#.#...O...#.O
##O#..#..O.....O.....#O......#..#O....O..O##...O..O...OO....#.....O#..#.#O#.O.......##...#......OO#.
....O#....#O.#..O.....O.....OO.O.O.O#....O..#.O......O..OO..#..#.O....O#..#.#...#....#.....O.....###
..O....#O#.OO.......#..#...#...#O.#O#O..........O...O#O...O.....O..#O...O.#.#...O.##.O..###OOOO.O.O.
O.....#.....##O......O..O...O.O..#...#.......#O.O#.O..#...O....O...O.#.#O..#.#.O.O.OO..O...O.##OOO.O
........#.O...O#.......O....O.O.#.....#.....O....##.....#...#...#......O#.#......#...O..O.O...O...#.
#..O.O..O......#...#.O...#OO..O.O...##O#O....O.#O..#....O.#O#.#....#O.O..OO.##...#.###...#.O.#.OO..#
.OO........O.....#O....#O#.OO...#...O....OO.#.#...#O..O..O.#O.OOO....#.OOOO..O.O...#...#O..O..O.#...
O.#.O##O.O....O..#.....OO.#O.#.O..#..#.O.....O.#.O....#O....#.....O.#.O.O...#....#.O..O#..#.#..O...#
#...#......#...#..#O.......O...O..O....#OO.......#.O.....##..O###....#..#O...#...OO..O.O...O...O#OO.
.....#O.O...##O.#....O..........#...........O...##.......O..O#....O.#...OO#.O...OOO...O....O........
...O.#..#.O...O..O..O..#OO............#.O#..##....#OOO#.#.O.#.O...#....#....OO#O.O..#..#O...O..O...#
OOO......#...#.......O#...........O.....O#.#.O.O....##.OOO.....#O...O.#.#OO.###....O##.#....O..#....
.#..###.#O...#..O##....O....OO##...#....O....#.O#..#.OO....O#O...##.#O.....#.O##O#.OO...O.....O##.#.
..#....OO...#.O..#.O###.#..#..O..O..O#...#.O.#..O..OOO#OO........O.#O#O.#.O..###.##O#..OO..O.#.#....
....O..#..#..O.O#O....O#...#.O.OO...O#.O.....O#.#..O...#..#.#O......O..#.............#.O...O.#..O...
#.#...O.#..O..#...O...#..OOO....O.O...O....O...O#.....#.....#.OO.O.O......#........#...O.O......#...
...#.....O.OO#...O...O..##O.OO...#....##.#.O#...OO.......O.O#O....OO.O.#OOO..O.#.......O#......#.#..
.###....#.O....#O.#.O#.OO..#...O......##O....O#.#.#.O...#...OOO.O#O.O..O.O..#..##..O..OO#...........
.O.#.##O#....O....O..O.#OO...##..#...#O..O.#O##....O.##....O...O#..#...O.O#...#..#.#....##....O.....
...O..#O#O...O.O.#O.OO......O.#O#...#....O.#O......#..O...O...###...#..O....O.O..OO###..O#.O..O....#
.#O..#OO.OO.......O..OO.....#.OO.O.##.#OO.#.#....#O.#O..#.#O..#......#O......#.O.#.O#...OO......O#O.
...O.O......#....O.O#O...O.O.#...#..#OO.#.O.........#...#.#.#.O.#..#...O.#.#......#.#O...#.....O...#
...#O.......OO.O.OO.#O......O...#...O...#.O......O..##O.....#OO......#.#O.O.#..O.#O#.......#OO#.O...
...#..###O..#..O........O..##.................O.O.....OO.#..O.....O.O.#OO...#.O....O.O....#.#O#O#..#
...#OOO...O...#..OOO...#..O.....O#O..O...........O.#.....#..#.O..............O....O.....#O...#O#.OO.
...#...#O..O#.....O....OO...#....#O.#....#..O.....OO#.#.O.O.....##...O.OO.O...OOOO.O...O...O...O....
...OOO...O.O#.#........OO.#.#.OO...#O...###.O#.O#.#.O.##O.O.O#.....##.....#.O..O.O.....#.#.......#..
.#.O..O.OO#.O.............O#....O#O...#.O.O.OO##.OO.O..O....O...O.....OO.#.O.O.......O..#O..#..O#..#
O....#O.O.O....#..O..#O....OOO...#.O#..O......O..O....OO.OO...#O#O..#O..#...##.#OOOOO..O..##....#.O.
..O.....#...OO#.O.......##OO#.O........O......O..#..O#...OOO....#.O.O#OO....#...#....#.OO#..OO....O.
..O#...#..#..O........#..O..#O..#..O..O...O.#..O...#O.#..##..##...O.....O.O.O....#.O.O....#.##......
...#......#.OO.O.#OO..O..##...O.....O.#O#..#O..............O.O..O.#..#..##...........OO.#.....###OO.
...#......O..#O.O.OOO...OO..O..O........#..............#.#.OO..####..#...#.#...#.O#.............#.O#
....#....O.......#....O..#....O#.#.#..#.#OO.#.O.O.....#O#......#.#......#...#...O..O......OOO###...O
O##..OO..#.O...OOOOO#.#........##..OOOO.O.#.O.O.O...OO...O...#..#...#...O......O..O#O#.#O.....##....
O..O...O....O...#.O.....O...O.#..#.O...#..#..#.OOO....O..##.#......O.#..O...O...#.O.O#.##O...#O...O.
..O.O..#.......O......O..#....O..#.#OO#.#.#...OOOOOO.#OO........O..###O....O.#OO#..O.O#.##.#.O......
#...##..OO.O#..O.OO#...##.#.#O.........O.......O....O........##.O.###......O...#O...O.O.O#..O#O...O.
..OOO........O.##O....#...#.##..O..O....#.O........O##.........OO.#OOO#OOO..#..#O.#.#...O......#.O.O
...##.#.#O........OO.OOO.#O.O#..#..O#.O..#.O##....O#O##O#...#.O....O....#..##O..#.O..O.#.....#.#..O.
.O.O.O##..#..O....OOO.O.#.##.##.....O...#O#.....#O...#.OO.O..O......O.O.OO.O.O..#..O..OO...#..#...#.
#......O..OO.....O#.O...##...#.O.O...O#....##.##.OO.O...O.#....#...#...O...#....O.......OO.O..O.#..#
....#......O...##...OO.O...........#..O.###...#...##.OOOO#...#...#....O#...#..#O....#.O.......OO.O..
...##O...#....##..##..##..O.#O.O##...O.........O........O..O#..O#.....O.O.#O##.O#OOO..O...OO#...#..O
.O..O###.#O...O..O.O.O.....#.#.#.#..OO....O..O.O##.#O....#...#OO...#.#OO.O.OO....##...OO#.#O.#....#O
#OO..O...O..#..OO.O.................#O.......####.#..O##.O..OOO#.....##O.OO..O#O...#.##.#.......#...
O#..#.....O#.......#.....O..#OOO..O...O.....#...O.....O#.O..O.#O....##...##.O.#O.O.##......O....O#OO
.#O......##..O.....O...#.O#....##.O.O.#.....#O#..OO#OO.O.##O.#.......O.O....#.#.#....#O..O...#....OO
###.#O.......OO#..O#.O#.O.#..#...O...O...#.....O#...........#....O...##....#.#.......#.#O.....O.....
O#.#O.....O....OO....O...#..O.O.......##.#..O...O.#O...#O.#.#O#......O......OO#...#....O.O.#......#.
OO..#O....O..O#..#......#O...#..#.##......O..O.#.O.O.O.O.O...#.OO.O.O...O........O.....#.OO.O.#...#.
..O.#..O....O#..OO##O..O...O..#...#..#......###...........###O...#...........##O....#.O....#.#..OO#.
......OOO.OO.####.O...#..#...##..O..#.#...#...#...#.#..#.........OO..O#O.O.##O#....#O....#.....#O#..
O....O.O...#..O.....#.O...O..O.O...#OO..#OO.O..O#.O#O..#....#..#OO.O..#O.O..#........#O.#..##.....O.
#O#O#.....O...##.O.O..#O..#.OO.#OO........OO#..#.#O....#.OO..O.O#...#.O....O......O...O..O..##.O..#.
.......##O..OO#.O#.O.#O.....#.#.#.OO..O.O......OO.#...#...O..#O#........#.....O#.O#...OO..#.#OO.O...
..#O.O#O.O....#....OOO....O.#O.O#..#..O#.#.......#O...OOO.#..OO..#...#..#.......O..O..O..OO...OO#.O.
O....#..#O..O#..O##..#O........O....O.OO.OOOOO#.OOOO.....OOO#....O..#.....#..............#..#..O##.#
O.##.O..#O...#OO.........O...O..O.......OO#..##.O##.O.O....#.....O#....O.....O#..O..OO..O.........O.
...#OO..O......#..O#O..#O#...#...OO#.#.#O.#..O...#......O.O...O##.......#....O......O....#OO.#O.OO.O
.....#OO#...#..#......#.O...#OO..O#......O....O..O#..#.O.O...O..#O..O..OO.....O.O..O..#O....O..O..OO
.#.OOO.OO...##.......#OO.OO...O......O.OO.O.#O#.O..#...OO.O..O..#O........OOO#..#.#OO.#.O...O.O.....
...#..O..#...O..##......#....OOO..##.O...O#..#............O#O..O..O.#OOO...#...#...O......#...#.....
............#.O.#...#..O..O.....O.O#..O.....O#..#...#.......O#..#....O.#.O##...OO.O#.#.....O..OO..#.
......O#..O....O.....#........OO..O.#.#O.#...O#....##..O.#...#O#O.......#.....#...O....##...O...O.O.
.O..O...O.O.#.O..O#.......#..#.O...OO..OO..#O...............#O.O......##.OO.......OO..O.......#....#
O#.....#.O.O..O.OOOO.....OOO...#........O...#...##.......##O#.OO#O#...#.O..O.OOO....##..........#..O
...O.#.O..O.#.#O.....#...OO...O.O.....OO......O..O..O..OO##....O....O...O...O#..#..#.O...O.......#..
#.....O#.....#.....#......#.O.............O.O..OO.O..O.......O.OO...O..#...#.....#.O.O.......O......
.#.#.O.OO...#.##.....O....#...O.O...#.......OO.O.O.....O..#....O.........O..#..#.#.O.......O...O...O
O..O#.O.#OO..#.#.#......OOO.#..#.#.O#O.O...OO..#O#O.....O.O..O#O.#..O...O#...O.O.O###...O....O.O..O.
..O.#......O.O....#..#O.............#..OOO.O...........O....O.OO.....#.#O.OO...OO...#....#..#...##.#";

var smallInput =
@"O....#....
O.OO#....#
.....##...
OO.#O....O
.O.....O#.
O.#..O.#.#
..O..#O..O
.......O..
#....###..
#OO..#....";

var smallest =
@".OO.O..O#.O";

// puzzle ref 2024 day 15

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0l;

var cycles = 1_000_000_000;
//cycles = 1_000_000;

var grid = Utils.Parse2DGrid(input);
var cache = new Dictionary<char[], char[]>();

//grid = TransformNorth(grid);
//Utils.PrintGrid(grid);
//Console.WriteLine(GetLoad());


long GetLoad()
{
    return grid.Select((x, i) => x.Count(y => y == 'O') * (grid.Length - i)).Sum();
}
string GetFullState()
{
    return string.Join("|", grid.Select(x => new string(x)));
}


var initialState = GetFullState();
var seen = new Dictionary<string, int>() { { initialState, 0 } };


int? target = null;
for (int i = 0; i < cycles; i++)
{
    if (i % 1000 == 0)
    {
        Console.WriteLine(i);
    }
    TransformNorth(grid);
    TransformWest(grid);
    TransformSouth(grid);
    TransformEast(grid);

    var fullState = GetFullState();
    if (seen.TryGetValue(fullState, out var pos))
    {
        if (!target.HasValue)
        {
            var repeats = i - pos;
            var startSettleTime = pos + 1;

            var offset = (((cycles % repeats - startSettleTime) + repeats) % repeats);
            target = i + offset + repeats;
        }

        if (target == i)
        {
            result = GetLoad();
            break;
        }

    }
    seen[fullState] = i;
}

//Utils.PrintGrid(grid);

//result = grid.Select((x, i) => x.Count(y => y == 'O') * (grid.Length - i)).Sum();


char[][] TransformEast(char[][] lines)
{
    for (int j = 0; j < lines.Length; j++)
    {
        var line = lines[j];
        var block = 0;
        for (int i = 0; i < line.Length - 1; i++)
        {
            if (line[i] == 'O')
            {
                block++;
            }
            else
            {
                block = 0;
            }

            if (line[i] == 'O' && line[i + 1] == '.')
            {
                line[i + 1] = 'O';
                line[i - block + 1] = '.';
                block--;
            }
        }
    }
    return lines;
}

char[][] TransformWest(char[][] lines)
{
    for (int j = 0; j < lines.Length; j++)
    {
        var line = lines[j];
        var block = 0;
        for (int i = 0; i < line.Length - 1; i++)
        {
            if (line[i] == '.')
            {
                block++;
            }
            else
            {
                block = 0;
            }

            if (line[i] == '.' && line[i + 1] == 'O')
            {
                line[i + 1] = '.';
                line[i - block + 1] = 'O';
                block--;
            }
        }
    }
    return lines;
}


char[][] TransformSouth(char[][] lines)
{
    for (int i = 0; i < lines[0].Length; i++)
    {
        var block = 0;
        for (int j = 0; j < lines.Length - 1; j++)
        {
            if (lines[j][i] == 'O')
            {
                block++;
            }
            else
            {
                block = 0;
            }

            if (lines[j][i] == 'O' && lines[j + 1][i] == '.')
            {
                lines[j + 1][i] = 'O';
                lines[j - block + 1][i] = '.';
                block--;
            }
        }
    }
    return lines;
}

char[][] TransformNorth(char[][] lines)
{
    for (int i = 0; i < lines[0].Length; i++)
    {
        var block = 0;
        for (int j = 0; j < lines.Length - 1; j++)
        {
            if (lines[j][i] == '.')
            {
                block++;
            }
            else
            {
                block = 0;
            }

            if (lines[j][i] == '.' && lines[j + 1][i] == 'O')
            {
                lines[j + 1][i] = '.';
                lines[j - block + 1][i] = 'O';
                block--;
            }
        }
    }
    return lines;
}





timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();
