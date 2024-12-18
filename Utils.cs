using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AoC2023;

public static class Utils
{
    static public void PrintGrid<T>(T[][] grid, Func<T, string> print = null)
    {
        print ??= x => x.ToString();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                Console.Write(print(grid[i][j]));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static public char[][] RotateClockwise(char[][] input)
    {
        var height = input.Length;
        var width = input[0].Length;

        var target = Enumerable.Range(0, width).Select(x => new char[height]).ToArray();

        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
                target[j][i] = input[height - 1 - i][j];
            }
        }
        return target;
    }


    static public void PrintGrid<T>(IEnumerable<T> grid, Func<T, int> X, Func<T, int> Y, Func<T, string> print = null)
    {
        print ??= x => x.ToString();
        var width = grid.Max(X);
        var height = grid.Max(Y);
        for (int i = 0; i <= width; i++)
        {
            for (int j = 0; j <= height; j++)
            {
                var item = grid.SingleOrDefault(o => X(o) == j && Y(o) == i);
                Console.Write(item is null ? "?" : print(item));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static public (char[][] grid, int height, int width) Parse2DGrid(string input)
    {
        var grid = input.Split(Environment.NewLine).Select(x => x.ToArray()).ToArray();
        return (grid, grid.Length, grid[0].Length);
    }

    static public IEnumerable<T> ParseCoordGrid<T>(string input, Func<(int x, int y, char c), T> init) where T : new()
    {
        (char[][] grid, int height, int width) = Parse2DGrid(input);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                yield return init((x, y, grid[y][x]));
            }
        }

    }
}
