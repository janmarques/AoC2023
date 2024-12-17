var fullInput =
@"Register A: 30886132
Register B: 0
Register C: 0

Program: 2,4,1,1,7,5,0,3,1,4,4,4,5,5,3,0";

var smallInput =
@"Register A: 729
Register B: 0
Register C: 0

Program: 0,1,5,4,3,0";

var smallest =
@"Register A: 0
Register B: 0
Register C: 0

Program: 0,0,0";

smallest =
@"Register A: 2024
Register B: 0
Register C: 0

Program:  0,1,5,4,3,0 ";

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0;

var inputs = input.Replace(Environment.NewLine, "").Replace("Register A: ", "").Replace("Register B: ", ",").Replace("Register C: ", ",").Replace("Program: ", ",").Replace(" ", "").Split(',').Select(int.Parse).ToList();

var registers = Enumerable.Range(0, 3).ToDictionary(x => (char)(x + 65), x => inputs[x]);
var program = inputs.Skip(3).ToList();

var output = new List<int>();
for (int pointer = 0; pointer < program.Count; pointer = pointer + 2)
{
    int GetValue(int n)
    {
        if (n < 4) { return n; }
        if (n == 7) { return 9999; }
        return registers[(char)(n + 61)];
    }
    var opcode = program[pointer];
    var literalOperant = program[pointer + 1];
    var comboOperant = GetValue(literalOperant);

    switch (opcode)
    {
        case 0: registers['A'] /= (int)Math.Pow(2, comboOperant); break;
        case 1: registers['B'] ^= literalOperant; break;
        case 2: registers['B'] = comboOperant % 8; break;
        case 3: if (registers['A'] != 0) { pointer = literalOperant - 2; }; break;
        case 4: registers['B'] ^= registers['C']; break;
        case 5: output.Add(comboOperant % 8); break;
        case 6: registers['B'] = registers['A'] / (int)Math.Pow(2, comboOperant); break;
        case 7: registers['C'] = registers['A'] / (int)Math.Pow(2, comboOperant); break;

        default:
            break;
    }

}


Console.WriteLine(string.Join(",", output));

timer.Stop();
Console.WriteLine(result); // 6,3,7,4,2,6,3,3,4 WRONG!?
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