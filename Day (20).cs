﻿using AoC2023;
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


var (modules, pendings) = Initialize(input, broadcaster);

var lows = 0;
var highs = 0;


var printDebug = true;
printDebug = false;

var i = BigInteger.One;
var j = 0;

var interesting = new[] { "mj", "qs", "rd", "cs" };
if (modules.Count < 10)
{
    interesting = new[] { "inv", "con" };
}
var intervalDetection = modules.Where(x => interesting.Contains(x.Key)).ToDictionary(x => x.Key, x => x.Value.Previous.ToDictionary(y => y.Key, y =>
{
    (modules, pendings) = Initialize(input, broadcaster);
    return FindCycle(x.Key, y.Key);
}));

(modules, pendings) = Initialize(input, broadcaster);
i = BigInteger.One;
while (true)
{
    foreach (var item in intervalDetection)
    {
        if (item.Value.All(x => i % (x.Value.on + x.Value.off) >= x.Value.off))
        {
            goto end;
        }
    }
    i++;
}
end:;

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

(int off, int on, int delay) FindCycle(string module, string prev)
{
    var delay = int.MaxValue;
    var off = int.MaxValue;
    var on = int.MaxValue;
    var count = 1;
    var was = false;
    while (true)
    {
        Execute(pendings);

        var xx = modules[module].Previous[prev];
        if (xx == was)
        {
            count++;
        }
        else
        {
            if (delay == int.MaxValue)
            {
                delay = count;
            }
            else if (on == int.MaxValue)
            {
                on = count;
            }
            else if (off == int.MaxValue)
            {
                off = count;
                return (off, on, delay);
            }
            was = xx;
            count = 1;
        }
    }
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