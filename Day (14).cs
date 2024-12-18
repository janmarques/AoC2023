using AoC2023;
using System;
using System.Diagnostics;
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
@".
O
.
O
.
.
O
#
.
O";

// puzzle ref 2024 day 15

var input = smallInput;
//input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0l;

var cycles = 1_000_000_000;
cycles = 1_000_000;

var grid = Utils.Parse2DGrid(input);
var cache = new Dictionary<char[], char[]>();


// Shift north to west
Utils.PrintGrid(grid);

grid = TransformSouth(grid);

Utils.PrintGrid(grid);

//grid = Utils.RotateClockwise(grid);
//Utils.PrintGrid(grid);
//Shift();
//Utils.PrintGrid(grid);
//grid = Utils.RotateClockwise(grid);
//grid = Utils.RotateClockwise(grid);
//grid = Utils.RotateClockwise(grid);
//Utils.PrintGrid(grid);

//Utils.PrintGrid(grid);

//void Shift()
//{

//    for (int i = 0; i < grid.Count(); i++)
//    {
//        grid[i] = Transform(grid[i]);
//    }
//}

//for (int j = 0; j < cycles; j++)
//{

//    for (int i = 0; i < grid.Count(); i++)
//    {
//        grid[i] = Transform(grid[i]);
//    }
//    //Utils.PrintGrid(grid);
//    grid = Utils.RotateClockwise(grid);
//}



//char[] Transform(char[] line)
//{
//    if (!cache.ContainsKey(line))
//    {
//        cache[line] = TransformInt(line);
//    }
//    return cache[line];
//}
char[][] TransformInt(char[][] line, int xBase, int yBase, int xOffset, int yOffset, int times)
{
    var didSomething = false;
    do
    {
        didSomething = false;
        for (int k = times; k > 0; k--)
        {
            var last = line[xBase + k * xOffset][yBase + k * yOffset];
            var before = line[xBase + (k - 1) * xOffset][yBase + (k - 1) * yOffset];

            if (line[xBase + k * xOffset][yBase + k * yOffset] == '.' && line[xBase + (k - 1) * xOffset][yBase + (k - 1) * yOffset] == 'O')
            {
                line[xBase + k * xOffset][yBase + k * yOffset] = 'O';
                line[xBase + (k - 1) * xOffset][yBase + (k - 1) * yOffset] = '.';
                didSomething = true;
            }
        }
    } while (didSomething);
    return line;
}

char[][] TransformEast(char[][] lines)
{
    var didSomething = false;
    do
    {
        didSomething = false;
        for (int j = 0; j < lines.Length; j++)
        {
            var line = lines[j];
            for (int i = line.Length - 1; i > 0; i--)
            {

                if (line[i] == '.' && line[i - 1] == 'O')
                {
                    line[i] = 'O';
                    line[i - 1] = '.';
                    didSomething = true;
                }
            }
        }
    } while (didSomething);
    return lines;
}

char[][] TransformWest(char[][] lines)
{
    var didSomething = false;
    do
    {
        didSomething = false;
        for (int j = 0; j < lines.Length; j++)
        {
            var line = lines[j];
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] == 'O' && line[i - 1] == '.')
                {
                    line[i] = '.';
                    line[i - 1] = 'O';
                    didSomething = true;
                }
            }
        }
    } while (didSomething);
    return lines;
}


char[][] TransformNorth(char[][] lines)
{
    var didSomething = false;
    do
    {
        didSomething = false;
        for (int j = 1; j < lines.Length; j++)
        {
            for (int i = 0; i < lines[0].Length; i++)
            {
                if (lines[j][i] == 'O' && lines[j-1][i] == '.')
                {
                    lines[j][i] = '.';
                    lines[j - 1][i] = 'O';
                    didSomething = true;
                }
            }
        }
    } while (didSomething);
    return lines;
}

char[][] TransformSouth(char[][] lines)
{
    var didSomething = false;
    do
    {
        didSomething = false;
        for (int j = lines.Length - 1; j > 0; j--)
        {
            for (int i = 0; i < lines[0].Length; i++)
            {
                if (lines[j][i] == '.' && lines[j - 1][i] == 'O')
                {
                    lines[j][i] = 'O';
                    lines[j - 1][i] = '.';
                    didSomething = true;
                }
            }
        }
    } while (didSomething);
    return lines;
}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();
