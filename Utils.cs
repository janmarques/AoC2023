﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AoC2023;

public static class Utils
{
    public record Direction(char icon, int x, int y);
    public static Direction[] Directions = new[] {
        new Direction('E', 1, 0),
        new Direction('W', -1, 0),
        new Direction('N', 0, -1),
        new Direction('S', 0, 1),
    };
    public static char InverseDirection(char x)
        => x switch
        {
            'E' => 'W',
            'W' => 'E',
            'S' => 'N',
            'N' => 'S',
            _ => throw new NotImplementedException()
        };

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


    static public void PrintGrid<T>(IEnumerable<T> grid, Func<T, int> X, Func<T, int> Y, Func<T, string> print = null, int? width = null, int? height = null, int? minWidth = null, int? minHeight = null, Func<int, int, string> nullPrint = null)
    {
        Console.Write(WriteGrid(grid, X, Y, print, width, height, minWidth, minHeight, nullPrint));
    }


    static public string WriteGrid<T>(IEnumerable<T> grid, Func<T, int> X, Func<T, int> Y, Func<T, string> print = null, int? width = null, int? height = null, int? minWidth = null, int? minHeight = null, Func<int, int, string> nullPrint = null)
    {
        var sb = new StringBuilder();
        print ??= x => x.ToString();
        minWidth ??= grid.Min(X);
        minHeight ??= grid.Min(Y);
        width ??= grid.Max(X);
        height ??= grid.Max(Y);
        nullPrint ??= (_, _) => "?";
        for (int j = minHeight.Value; j <= height.Value; j++)
        {
            for (int i = minWidth.Value; i <= width.Value; i++)
            {
                if (grid.Any(o => X(o) == i && Y(o) == j))
                {
                    sb.Append(print(grid.Single(o => X(o) == i && Y(o) == j)));
                }
                else
                {
                    sb.Append(nullPrint(i, j));
                }
            }
            sb.AppendLine();
        }
        sb.AppendLine();
        sb.AppendLine();
        return sb.ToString();
    }

    static public (char[][] grid, int height, int width) Parse2DGrid(string input)
    {
        return Parse2DGrid(input, x => x);
    }
    static public (T[][] grid, int height, int width) Parse2DGrid<T>(string input, Func<char, T> parse)
    {
        var grid = input.Split(Environment.NewLine).Select(x => x.Select(y => parse(y)).ToArray()).ToArray();
        return (grid, grid.Length, grid[0].Length);
    }

    static public IEnumerable<(int x, int y, char c)> ParseCoordGrid(string input) => ParseCoordGrid(input, x => (x.x, x.y, x.c));

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

    static public int Manhatten((int x, int y) from, (int x, int y) to) => Math.Abs(from.x - to.x) + Math.Abs(from.y - to.y);

    static Dictionary<string, int> Counters = new Dictionary<string, int>();
    static Dictionary<string, Stopwatch> Timers = new Dictionary<string, Stopwatch>();
    static public int Counter(string name, int threshold = 10000, long expectedTotal = 0, bool timer = false, string extraText = "")
    {
        if (timer && !Timers.ContainsKey(name))
        {
            Timers[name] = new Stopwatch();
            Timers[name].Start();
        }
        if (!Counters.ContainsKey(name))
        {
            Counters[name] = 0;
        }
        Counters[name]++;
        var value = Counters[name];
        if (value % threshold == 0)
        {
            var timerStr = "";
            if (timer)
            {
                var elapsedSeconds = Timers[name].ElapsedMilliseconds / 1000;
                timerStr = $" {TimeSpan.FromSeconds(elapsedSeconds)}";
                if (expectedTotal != 0)
                {
                    var prognosis = TimeSpan.FromSeconds(expectedTotal * elapsedSeconds / value);
                    timerStr += $" expected {prognosis}";

                }
            }
            var totalStr = expectedTotal == 0 ? "" : $"/{expectedTotal} {(double)value * 100 / expectedTotal}%";
            Console.WriteLine($"{name} {value} {totalStr} {timerStr} {extraText}");
        }
        return Counters[name];
    }

    public static string ReplaceFirst(string input, string search, string replacement) => new Regex(Regex.Escape(search)).Replace(input, replacement, 1);

    public static BigInteger gcf(BigInteger a, BigInteger b)
    {
        while (b != 0)
        {
            BigInteger temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static BigInteger LeastCommonMultiple(params BigInteger[] x)
    {
        var result = BigInteger.One;

        for (int i = 0; i < x.Length; i++)
        {
            result = LeastCommonMultiple(result, x[i]);
        }
        return result;
    }

    public static BigInteger LeastCommonMultiple(BigInteger a, BigInteger b)
    {
        return (a / gcf(a, b)) * b;
    }

    public static int SafeMod(int a, int b)
    {
        return ((a % b) + b) % b;
    }
}