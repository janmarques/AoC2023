using AoC2023;

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

bool? ToBool(char c) => c == 'O' ? true : c == '#' ? false : null;
char ToChar(bool? c) => !c.HasValue ? '.' : c.Value ? 'O' : '#';
var grid = Utils.ParseCoordGrid(input, (p) => new Node { x = p.x, y = p.y, state = ToBool(p.c) }).ToList();

void Print() => Utils.PrintGrid(grid, x => x.x, x => x.y, x => ToChar(x.state).ToString());

//Print();

var north = new Direction { Inv = true, x = 0, y = -1, Order1 = j => j.OrderByDescending(x => x.y), Order2 = j => j.OrderByDescending(x => x.state ?? false) };
var west = new Direction { Inv = true, x = -1, y = 0, Order1 = j => j.OrderByDescending(x => x.x), Order2 = j => j.OrderByDescending(x => x.state ?? false) };
var south = new Direction { x = 0, y = 1, Order1 = j => j.OrderBy(x => x.y), Order2 = j => j.OrderBy(x => x.state ?? false) };
var east = new Direction { x = 1, y = 0, Order1 = j => j.OrderBy(x => x.x), Order2 = j => j.OrderBy(x => x.state ?? false) };

var directions = new[] { north, west, south, east };
var maxY = grid.Max(x => x.y);

long GetLoad()
{
    return grid.Where(x => x.state ?? false).Sum(x => maxY + 1 - x.y);
}
string GetFullState()
{
    return string.Join("|", grid.Where(x => x.state ?? false).OrderBy(x => x.x).ThenBy(x => x.y).Select(x => $"{x.x},{x.y}"));
}

var initialState = GetFullState();
var seen = new HashSet<string>() { initialState };
var seen2 = new Dictionary<string, int>() { { initialState, 0 } };

int? target = null;

for (int k = 0; k < cycles; k++)
{
    if (k % 1000 == 0)
    {
        Console.WriteLine(k);
    }


    foreach (var direction in directions)
    {
        var relevantItems = direction.Order1(grid.Where(x => x.state ?? false)).ToHashSet();

        foreach (var item in relevantItems)
        {
            relevantItems.Remove(item);

            var untilWall = TakeUntilWall(item, direction.x, direction.y).ToList();
            var emptyCount = untilWall.Count(x => !x.state.HasValue);
            if (emptyCount > 0)
            {
                var minX = untilWall.Min(x => x.x);
                var minY = untilWall.Min(x => x.y);
                int i = 0;
                var inv = direction.Inv ? -1 : 1;
                //foreach (var item2 in untilWall.OrderByDescending(x => x.state ?? false))
                foreach (var item2 in direction.Order2(untilWall))
                {
                    item2.x = minX + i * direction.x * inv;
                    item2.y = minY + i * direction.y * inv;
                    i++;
                    relevantItems.Remove(item2);
                }
            }
        }
        //Print();
    }

    var fullState = GetFullState();
    if (seen2.TryGetValue(fullState, out var pos))
    {
        if (!target.HasValue)
        {
            var repeats = k - pos;
            var startSettleTime = pos+1;

            var offset = (((cycles % repeats - startSettleTime) + repeats) % repeats);
            target = k + offset;
        }

        if (target == k)
        {
            result = GetLoad();
            break;
        }

    }
    seen2[fullState] = k;
}



IEnumerable<Node> TakeUntilWall(Node node, int x, int y)
{
    if (node == null) { yield break; }
    if (node.state == false) { yield break; }
    yield return node;
    var next = grid.SingleOrDefault(n => n.x == node.x + x && n.y == node.y + y);
    foreach (var item in TakeUntilWall(next, x, y))
    {
        yield return item;
    }
}

void Swap(Node one, Node two)
{
    (one.y, two.y) = (two.y, one.y);
    (one.x, two.x) = (two.x, one.x);
}



timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();

class Node
{
    public int x { get; set; }
    public int y { get; set; }
    public bool? state { get; set; }
    public override string ToString()
    {
        return $"{x},{y} {(!state.HasValue ? '.' : state.Value ? 'O' : '#')}";
    }
}

class Direction
{
    public int x { get; set; }
    public int y { get; set; }
    public bool Inv { get; set; }
    public Func<IEnumerable<Node>, IEnumerable<Node>> Order1 { get; set; }
    public Func<IEnumerable<Node>, IEnumerable<Node>> Order2 { get; set; }
}
