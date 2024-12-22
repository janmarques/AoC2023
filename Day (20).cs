using AoC2023;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

// &mj -> hz, bt, lr, sq, qh, vq
var fullInput =
@"%qm -> mj, xn
&mj -> hz, bt, lr, sq, qh, vq
%qc -> qs, vg
%ng -> vr
%qh -> sq
&bt -> rs
%hh -> qs, bx
%gk -> cs, bb
%js -> mj
%pc -> mj, mr
%mb -> rd, xs
%tp -> qs, ks
%xq -> tp, qs
%bx -> sz
%mn -> cs, md
%cv -> rd
%rh -> rd, sv
%md -> cs
%pz -> mj, vq
%bz -> rd, hk
%jz -> vk
%sz -> jz
%lr -> pz, mj
%xs -> cv, rd
%kl -> rd, mb
%hz -> pc
%hk -> rz, rd
%vk -> qc
%bh -> zm
%vq -> qm
%ks -> qs, nd
&qs -> dl, jz, bx, vk, vg, hh, sz
&dl -> rs
%lf -> rh, rd
&fr -> rs
%xn -> mj, qh
%hf -> qs, xq
%sv -> rd, ng
&rs -> rx
&rd -> ng, fr, rz, lf, vr
%cj -> ss, cs
broadcaster -> hh, lr, bp, lf
%zs -> cs, mn
%vr -> bz
%nd -> qs
%jb -> cj, cs
&rv -> rs
%bp -> cs, lx
%ss -> zs
%lx -> gk
&cs -> lx, ss, rv, bh, bp
%bb -> bh, cs
%mf -> mj, hz
%zm -> cs, jb
%mr -> mj, js
%rz -> kl
%vg -> hf
%sq -> mf";

var smallInput =
@"broadcaster -> a, b, c
%a -> b
%b -> c
%c -> inv
&inv -> a";

var smallest =
@"broadcaster -> a
%a -> inv, con
&inv -> b
%b -> con
&con -> output";

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();
var result = 0l;


var broadcaster = "broadcaster";



var lows = 0;
var highs = 0;


var printDebug = true;
printDebug = false;

var i = BigInteger.One;
var j = 0;

var (modules, pendings) = Initialize(input, broadcaster);
for (int k = 0; k < 1000; k++)
{
    Execute(pendings);
}
if (lows * highs != 834323022) { throw new Exception(); }

//var interesting = new[] { "mj", "qs", "rd", "cs" };
//if (modules.Count < 10)
//{
//    interesting = new[] { "inv", "con" };
//}

(modules, pendings) = Initialize(input, broadcaster);

var interesting = modules.Where(x => x.Value.Type == '&').Select(x => x.Key).Distinct().ToArray();
var intervalDetection = modules.Where(x => interesting.Contains(x.Key)).ToDictionary(x => x.Key, x => x.Value.Previous.ToDictionary(y => y.Key, y =>
{
    (modules, pendings) = Initialize(input, broadcaster);
    return FindCycle(x.Key, y.Key);
}));

var biggy = BigInteger.One;
foreach (var item in intervalDetection)
{
    var qw = item.Value.Select(x => x.Value.Distinct()).SelectMany(x => x).Select(x => new BigInteger(x)).ToArray();
    var lcm = Utils.LeastCommonMultiple(qw);
    Console.WriteLine(item.Value);
    Console.WriteLine(string.Join(",", qw));
    Console.WriteLine(lcm);
    biggy = Utils.LeastCommonMultiple(biggy, lcm);
}
Console.WriteLine(biggy);

var aaa = intervalDetection.SelectMany(item => item.Value.Select(x => x.Value.Distinct()).SelectMany(x => x).Select(x => new BigInteger(x))).ToArray();
var biggy2 = Utils.LeastCommonMultiple(aaa);

Console.WriteLine(biggy2);


(modules, pendings) = Initialize(input, broadcaster);
i = BigInteger.One;
//while (true)
//{
//    if (intervalDetection.Any(item => item.Value.All(x => i % (x.Value.on + x.Value.off) >= x.Value.off)))
//    {
//        goto end;
//    }
//    i++;
//}


end:;

(modules, pendings) = Initialize(input, broadcaster);

i = 0;
while (true)
{
    if (i == 7657470)
    {
    }
    Execute(pendings);
    i++;
}



//lala("mj", "js", 5000);
//FindCycle("mj", "xn");

void lala(string module, string prev, int i)
{
    var sb = new StringBuilder();
    while (--i > 0)
    {
        Execute(pendings);
        //Console.WriteLine(modules[module].Previous[prev]);
        sb.AppendLine(modules[module].Previous[prev].ToString());
    }
    var xx = sb.ToString();
}

List<int> FindCycle(string module, string prev)
{
    var count = 1;
    var was = false;
    var cycles = new List<int>();
    for (int i = 0; i < 25_000; i++)
    {
        Execute(pendings);

        var xx = modules[module].Previous[prev];
        if (xx == was)
        {
            count++;
        }
        else
        {
            if (!was)
            {
                cycles.Add(count);
            }
            was = xx;
            count = 1;
        }
    }
    return cycles;
}

void Execute(List<(Module module, bool highPulse, Module sender)> pendings)
{
    if (pendings.Count == 0) { return; }
    var newPendings = new List<(Module module, bool highPulse, Module sender)>();

    foreach (var (module, highPulse, sender) in pendings)
    {
        lows += (!highPulse) ? 1 : 0;
        highs += (highPulse) ? 1 : 0;

        if (module.Name == "rx" && !highPulse) { Console.WriteLine(i); Console.ReadLine(); return; }

        if (printDebug) { Console.WriteLine($"{sender?.Name ?? "button"} -{(highPulse ? "high" : "low")}-> {module.Name}"); }

        if (module.Type == 'x') { continue; }

        if (module.Type == default)
        {
            foreach (var item in module.Nodes)
            {
                newPendings.Add((modules[item], highPulse, module));
            }
        }
        else if (module.Type == '%')
        {
            if (highPulse) { continue; }
            module.FlipFlop = !module.FlipFlop;
            var val = module.FlipFlop;
            foreach (var item in module.Nodes)
            {
                newPendings.Add((modules[item], val, module));
            }
        }
        else if (module.Type == '&')
        {
            module.Previous[sender.Name] = highPulse;
            foreach (var item in module.Nodes)
            {
                if (module.Previous.Values.All(x => x))
                {
                    newPendings.Add((modules[item], false, module));
                }
                else
                {
                    newPendings.Add((modules[item], true, module));
                }
            }
        }
        else
        {
            throw new NotImplementedException();
        }
    }
    Execute(newPendings);
}


timer.Stop();
Console.WriteLine(result);
// 106337768232960 too low
// 194139118858905 wrong
// 255282961905279 wrong
// 212965241395951388742644547964187965440 too high
// 130672208443392 wrong
// 1522255148144640  wrong
// 2624872963614720 too high
// 1312436481807360 wrong
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();

(Dictionary<string, Module> modules, List<(Module module, bool highPulse, Module sender)> pendings) Initialize(string input, string broadcaster)
{
    modules = input.Split(Environment.NewLine).Select(Parse).ToDictionary(x => x.Name, x => x);
    Module Parse(string line)
    {
        var split = line.Split(" -> ");
        var name = split[0];
        var type = default(char);
        if (name != broadcaster)
        {
            type = name[0];
            name = name.Substring(1);
        }
        return new Module { Name = name, Type = type, Nodes = split[1].Split(", ").ToList() };
    }

    modules.Add("output", new Module { Name = "output", Type = 'x', Nodes = new List<string>() });
    modules.Add("rx", new Module { Name = "rx", Type = 'x', Nodes = new List<string>() });

    foreach (var item in modules.Values.Where(x => x.Type == '&'))
    {
        item.Previous = modules.Where(x => x.Value.Nodes.Contains(item.Name)).Select(x => x.Key).Distinct().ToDictionary(x => x, x => false);
    }

    pendings = new List<(Module module, bool highPulse, Module sender)>();
    pendings.Add((modules[broadcaster], false, null));

    return (modules, pendings);
}

class Module
{
    public char Type { get; set; }
    public string Name { get; set; }
    public List<string> Nodes { get; set; }

    public bool FlipFlop { get; set; }
    public Dictionary<string, bool> Previous { get; set; }
}