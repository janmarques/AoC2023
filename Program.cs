﻿var fullInput = // with original S
@"..FL-77L|7FL--J.F.77.F--F7J7FF-JJ.F-7J77.LJ7.L77F7F.F7777FFJ---7-77.FF-|.7---L7FL.-J.L-7F-J77FL7FF----|----J.FLF-F7.F-F-LJ..-FJJ7.FJ-7J-FJFL
L-7|FJJ||F77J.F-F7FJ-7FL|.LFJ|.L|.|.||7L7JLJFLJ-F---7L.FL7L-L-FL-|-F7JLLLJ|-|-F77L77-.L7|.|FF7L7-FFJ7.LF-L7.--||.-F-7.L77F|7.|JF-7|.L|J.L||7
LFL|||.J-JJ7.FF.F|7J|LFJFJ...LJLFLJ.FF-LJ7.F7J.LLF-L|7F7J|J.|J|.F|LJ|--.|-F-L7|L-F-L.7FFJF|7|JFJJJ|.|JFF-..|7..-.FLLJ-.L--J--LFLJFL7-FJFFLJ7
FJJFJL-7F|J|.F--FJJ.F.L-L77LL7L.-JFFJL7-|--L|FF7||7LJLF7||J|J7-F||7F--.F|7J.FL7J.FJL|JFJ|L|L-7||F-|-LJF|F-7|-|7.JJ||7L-7|L-L.F-J7JF-.F-|-L7J
FL.LL-LLF7|F-7FJJFLLL777LF7|FJ7FJF77-|LLLJ-LJJLJ-F7|J|||-7F|L7FJ|-|-J-F|LJLLFL7.FL.|LL--L-J.|FFLL--.|.LJ|.LJJL7|J.J--.FFJL|L-LJ.7F-|-|7L|F7.
J-FLL-7JL|FJF-|-FFJL.L-7J|FL--JJ|L.|F--7JF-7JF7JF|-F.FFJ.L7J.J|-.F|.|.J7.F||LJJ-L|-FF.JJ|FL7.LJL||FJL--|LLJ..L|JLF|-7FJ.|-|.|LFJLJ.7-L..--77
|JLJ|-LJ|JLJ-LF7FJ.FJ..|-FF7L77|FJ-J-|-JF-JLFJJ|LL7.FL|77.LJ7FJJ7JL7777L77F|7|-F.L-FL|J7L7.LF7J--J-LF-777J.-L77.LFF7|F|.F.L7|-7|FL-|7|7FLLF-
7.L-F7FFJ7.|FL|L-.FFJ7.J7L|FF-|7|J.L7|.|---7J|7|.|L7-J|FF-JLJJ.||7.L|F7-F7FFF|F|7.F|JJLF7|.LL|-LFL-7LF|J|7LJLL77.||JLFL.LF-F|777F-LJ-L-|..|J
.JFLJJ|JF-L7|.LJJ7.|.J.L|7LJ7J.7|F7.LJFJ7J7L-J7JF|-J.7J.LFF-|JFJJFF-L-JFJ|F-7F777-F||J.LLL-.-F77F|F77-J-F7-|.F|J|.FJ.7|FF-77|L7J77..FJJ|7-7.
.|F7.FFJ||-F7.|7.-|.LJL7L|J||.LJJL--JLL-7-F--7|FJJFF.|FF77F--7J|-F|-|.LL7||FJ|L-7.|L|..-.7.7LFF7F7|||L7|||-7FL7J|FL--|-JJJL---JJLJF-LJ||--J7
FLJF|-|FLL-.F7F7.L-7FLLJ-...FJJLJ-J-7|FFF77-LJJ-LFF77-FJL7|F-J7|7L7-FF--J|||FJF-JF7F7-L-FF77JFJLJ||L7-F-J|-|7F|7L|F7J|J|-F-|7L|7|FLJ-L7LFL-J
L-|LJ-L|.JJLL--L|-|F7.L|.L7-.LF-|||7|FFFJ|F-7JF-7FJL7.L7FJ|L--7|F7F-7|F7FJ||L7L7-||||7LF-JL-7L--7|L7L7|F-J-F-7JJL--J.|L--7--J-FJ-LJ-LFL7|JJ|
.|.FJ7LJ-L.FLJ.FL-J7|F7L7-|7.-|.LF--7F7L7||FJLL7|L7FJ.FJL7|F--JFJ||FJLJ|L7||-L7|FJ||L7-L-7F-JF--JL7|FJ|||F7|FJJ|.LL.L-JJ.||FL-7|F|.F.L.7LF.7
FF--|JJ||LL|L-F-JFL.F-7J|LL--JF77L-7|||7||||F-7||L|L-7L-7LJ|F7FJFJ||F-7L7LJ|F-JLJFJ|FJ.F|||F7L---7LJ|FJL-JLJ|FJ-F7JJ.||--L-|.LJF7LFJ7L-|-7F|
|7J7|L7FFJLJF7FJF|F-JJLF-7L||FJL-77|LJL7||||L7||L7L7FJF7|F-J||L7|FJ||FJ|L-7|L---7L-JL7F7FJLJ|F-7FJF7LJF--7F-J7JLF77LL7F-7|.LFJ.-L7LL77F|.|F-
JL|FFF.FJ7F-J|J-FF7|J|FL7L7-LL--7L7L7F-J|LJL-J||FJFJ|FJLJL-7|L-J||FJ||F7F-JL7F7J|F---J||L-7FJL7|L-JL-7L-7LJ7.FF7F77..-|LJJL-JFF7LJ.L7|LL7F77
|F7LJ-.7JJ-F7JJ.|L7F7FF7|FJ||LLL|FJF||L|L----7|||FJFJL----7|L7F-J|L-J|||L--7|||FJL7LF7||F7|L--J|F7F7FJF7L---7JF7||F77.LF|FLJ.|.F7.|.LLL7F|L7
-|-7.|-JJJF|.L7FJJLJLFJLJL7F7J|FJ|JFJL7F7LF7FJLJ|L7|F-7F-7|L7||F7L7F-J||F--JLJ|L7FJFJLJLJLJF--7||LJLJFJL----J7|||LJL77---F7|.FJ.L7J|7.|LJ.FJ
|JLF-J.F|-L-7.|-|7LL|L-7F-J||F7L7L7L-7||L-J|L--7L7||L7||FJ|FJ||||FJL-7||L--7F7L-J|FJF------JF7LJL---7|F7F7F--7||L7F7L7|.|L-|FJJL.LFLJF|.L7|.
7-7.||F---J-|7.L|J|FF7FJ|F7||||FL7|JFJLJF--JF7FJFJ||FJLJ|FJL-J||LJF7FJ|L7F-J|L7F7||FJF---7F-JL-7F---J||||LJF-J||-||L7L7.F7L|J.L|-LL7|.|J.L|7
||-|7FJ.L-F-J-77.|F-||L7||||||L7FJL-JF--JLF7||L7|L||L--7|L7F--J|F-JLJJ|FJL7FJLLJ|LJL-JF7FJL7F--JL---7LJ|L7FJF7||FJL7L-J7J||LJ|7|L7JF77|J|7.F
LF7L-77FFFJ7|.7J-F-.||FJLJ|||L7|L---7L7LF7||||J|L7||7F-JL-JL--7|L7LF7FJL7-LJF-7FJF----JLJF7||LF7F7F7L-7L7||FJ|||L7FJF7L7.JJ-7L7|F|.|L-J7|L-L
FJ-JFLF--|--JFLJL|7L||L--7|||.|L7F-7L7L7|||||L7L7LJL7L-7F--7F-JL7|FJ||F7L7F7L7|L7|F7F7F7F|LJL7||||||F-JFJ||L7LJL7|L7|L77.||--FJJ-|JLF7F-7|-|
L||FJJJ.7L-.F-.-F-7|||F-7||||FJFJ|FJFJFJ|LJLJFJLL--7L-7LJF-JL7JFJLJFJLJL7|||FJ|FJ||||LJL7L--7LJ|||||L-7L-J|FJF7FJ|FJL7L7-|J.L|-J7|.|L-LJLJ7J
|F|7-F-7..|LJ|.LL7|FJ|L7LJLJ||FJFJ||L7L7L-7F-JF7F77|F-JF7L7F7L7L7F-JF7F-J|||L7LJFJ|||F-7|F7FJF-J|LJ|F7L7F7LJFJLJFJ|F7|FJ7.FFF7L|FL77J-J|FJL7
F7L77J.L---JFF-|F|||FJLL-7F7LJ|FL7L-7|FJF7||F-J|||FJL7FJL7LJL7L-JL-7|||F-J|L7L-7L-JLJL7LJ||L7|F7L7FJ||FJ|L-7L-7L|FJ|||L---7FJ|||JJJ|L|7FL-7|
|F-J77.|7||FL-F-7||||FF-7LJL-7|F7L-7LJ|FJ|||L-7|||L-7|L-7|F7FJF7F--J|LJL-7|FJF7L-7F---JF-JL7|LJ|FJ|F||L7L-7L--JFJL7|||F---JL7L7.F|-|J|7F7|||
-JFL77F..FL|J-L7LJLJ|FJFJ|F--J||L--JF-JL7LJL7|||||FFJL7J||||L7||L7F7L--7FJ||FJL7J|L-7F7L--7LJF-JL7|FJ|||F-JF--7L7FJ|LJ|.F-7FJFJ-7J|.F7J|FF-7
|-JL|--7FJ.JFF7L--7FJL7|F7L-7FJL---7|F-7L--7L7|LJ|FJF7|FJLJL7||L7LJ|F7FJL-J||F-JFJF-J||F7LL-7L-7FJ|L7|FJ|F7L7FJFJL7|F-JFJFJ|FJJFJ.|7-|-J-JFL
|7FFJ77FL7L7-|L---JL7FJLJ|F-JL7-F7FJ||FJLF7L7|L-7||FJLJL--7FJ|L7L--J||L-7F7||L-7L7L-7||||F-7L-7|L7L7||L7||L-JL7L7FJ||F7L7L-JL7F|L-JL-JJ|JL7J
FF|J.J-|.F|7FL-----7|L-7FJL--7L7||L7LJ|LFJL-J|F7|LJ|F7F---JL7L7L7F-7|L7JLJ|||F-JFJF-J|||||FJF-JL7L7|||7|||F--7|FJL-JLJL-JF-7FJF7.F--77JLJFL7
|L7..LF--77F7F7F7F7||F7||F7F7L7||L7L-7L7L---7||LJF-J||L-7F7FJ.L7LJFJL7L-7FJLJL7-L7L7FJLJ||L7L--7L7|||L7|LJL-7LJS7F-------J-|L-JL77JL-7|LF-7L
F-J.F7L|LFFJLJLJLJ||||LJ||LJL7||L7|F7L7|F7F7||L-7L7FJL-7LJ||.F7|F-JF7L-7|L7F--JF7L7||F--J|FJFF7L7LJLJFJ|F---J|F7||F7F77F7F7L-7F-JJJF-LFJL|JJ
LJ|.J--7FLL------7LJ|L-7|L-7FJ||FJ|||FJ|||||||F-JFJ|F--JF-JL7|LJL-7||F7|L7|L7F7||FJ|||F-7|L7FJL7|F7F-JL|L7F7F-JLJLJLJL-J||L7JLJF7|-77-LF-|.|
J.-77FF-7J.F7F7F-JF7L7FJ|F-JL7||L7||||FJ||||||L-7|7||7F7L-7FJL-7F-J|||||FJ|FJ||||L7|||L7|L7|L-7|LJ||LF7|FJ|||F--7F7F----J|FJF--JL--7JJ.L-|7J
|.LFJ-|JF--J|||L--J|FJL7|L7F7LJL-JLJ||L-J|||||F7|L7|L7|L7FJL7F7|L7FJ||LJL7||FJ||L-J||L-JL7|L7FJL7FJ|FJLJL-JLJL7.LJLJF7F7FJL7L--7F--J.LF7.LJ.
777FJFL7L--7LJL--7FJ|-FJL7LJL------7LJF--J|||||||F||F|L7||F-J|||.||FJL-7FJ||L7||F--JL-7F7||FJL7L|L7LJ|F-------JF7F7FJLJ|L-7L--7|L-7F-7F-7LLJ
LL-.F|-FF7FJF7F-7|L7L7L7FJJF7F7F7F-JF7|F7FJ||||||FJL7|FJ|||F-J|L7LJ|F7FJ|FJL7|LJL7F7F7LJ|||L-7|FJFJFF7L--------JLJLJF--JF-JF--J|F7||FJ7F|F-J
7-JFJ|.FJLJFJLJFJL7L7L7||F7|LJLJLJF7||LJ|||LJLJLJL7FJ||J||LJF-JFJF-J|||7LJLFJ|F--J||||F-J|L7FJ||FJJFJ|F7F-----------JJF7L7FJF7F||LJ||F777|JJ
|FF--L-L--7|F--JF7L7L7LJ|||L7F----JLJL-7||F7F7JF7L|L7||FJL-7L7FJLL-7||L-7F7L-J|F7FJ|||L-7L7|L7|||F7L7LJ|L7F7F7F--7F7F-JL-JL-JL-JL--JLJL7J|.F
|||.|.|.FFJ|L---JL7L7L-7LJL-J|F-----7F7||LJLJL-JL7L-JLJL7F-JFJL-7JFJ||F7LJL-7FJ||L7LJ|F7L7LJFJ||LJ|JL-7L7LJLJLJF-J|||F---7F----7F-7F7F7|-J-|
--77F|7LFL-JF7F7F7|FJF7L---7FJL7F7F7LJLJ|F--7F--7L---7F-JL7FL7F-JFJFJ|||F-7FJL-J|FJF-J||FJF-JFJ|F7L--7L7L-7F--7L-7|||L7F7LJF7F7LJFLJLJLJ7.-.
LFL.LJF.F-7FJLJLJLJL-JL--7-LJJ-LJ||L-7F-JL-7|L7FJF--7|L7F-JF7|L-7L7|FJ||L7|L7F--J|FJF7|||FJF7L7|||F--JFJF7|L-7|F-J|LJFJ||F7|LJL--7F7F7J|F77.
F7JF-FF7|FJL--7F7F-7F7F7FJF-7.F7LLJF7||F7F-J|FJ|FJF7LJFJ|F-JLJF-JFJ||FJ|FJL-JL--7|L7||||||FJL7|||||F7JL-J|L--JLJ7FJF7L-JLJLJF----J||||F7|L-7
L7-7LF|LJL7F-7LJLJ-LJLJ||FJFJFJ|F--J||||LJF7LJFJL-JL-7L7|L7F-7L7LL-J||FJ|F----7FJ|7LJ||LJLJF7||LJLJ||F7F-JF7F----JFJL7F7F7F7L7F7FFJLJLJLJF-J
LJ-F-LL7F7LJFJLF7F7F--7|LJFJFJFJL7F7LJLJF7|L-7L7F-7F-JFJ|.LJLL7L---7||L7LJF-7FJL7L--7||F---JLJL7F7FJLJ|L--J||F--7FJJFJ|LJLJL-J|L-JF7F7F7FJJ|
.7F--|LLJL-7|FFJLJLJF7LJF7L7L7|F7LJL7F7FJLJF7L7||JLJFFJFJF7LF-JF7F-JLJJ|F7L7LJJFJF7FJ||L7F7F-7FJ||L-7FJF7F7LJ|F7LJF7L-JLF7F7-FJF7FJ||LJ|L-7J
-LLJ7--|-|||L7L7F7F-JL7FJL7L-JLJ|F--J|||F--JL7|||F7F7L-JFJL-JF7||L7F---J|L7L--7|FJLJFJ|-||||FJ|FJL--JL-JLJL-7LJL-7|L7F7FJLJL-JFJLJ-LJJLL7FJJ
FFJL-JJF7F7L7L7LJLJF77LJF7L---7FJL---JLJL-7F7LJLJ|||L---JF7F7||||FJ|F7F7|FJF7FJ|L--7|FJFJ|LJL-JL-----------7|F7F-J|FJ|LJF-----JF7F7F7||.|||J
F-.7..-|LJL-JFJF7F-JL---JL----JL----7F7F--J|L7F-7||L---7FJLJ|||||L7LJ|||||FJLJJ|F--JLJFJFJ-F---------------JLJLJF7||FJF7L------JLJLJL7F7LJJ.
LJFJF7.L7F7F7L7||L-------7F---7F---7LJ|L--7|FJ|FJ|L-7F-JL7F-J|||L7L7LLJLJ|L---7|L----7|FJF7L--------7F7F-7.F7LF7|LJLJFJ|F--7F7F7F-7F-J||JL||
FL|.L-FFJ|||L7LJ|-F7F----J|F--J|F7F|F7|F--J|L-JL7|F-JL7F7|L7FJ|L7L-JF----JF-7FJL7F7F7|LJFJL----7F7F7LJ|||L-JL-JLJF7F7L7|L7FJ|||||FJL7FJL7.|J
F7F7JL-L-JLJ.L-7L-JLJF-7F-JL--7||L7LJ|LJF7FJF7F-J|L--7||LJFJL7L7L-7FJF--7FJF|L-7LJLJ||F7L-----7LJ||||FJ|F---7F-7FJ|||FJL-JL-JLJLJL-7LJF7|-|J
|FLJ|L|.|JF7.F-JF7F--JFLJ7F---J||FJF7L--JLJFJLJF7|F--J||F-JF7|FJF7||FJF7||F7L-7L---7LJ||F--7F7L-7||L7L-JL--7|L7|L7|||L------------7L7FJLJLF7
LJ|||7L-F-JL-JF-J||F7F7F7FJF---J|L-JL-----7L7F-JLJL7F7LJ|F7|||L7|||LJFJLJLJ|F7L----JF7||L-7||L--J||FJF7F---JL-JL-JLJ|F7F7F------7FJFJ||J.FFJ
|F-7.|.LL---7FJF7LJ|LJLJLJFJF--7L7F------7|FJ|F-7F7LJL-7||||||F||||.FJF7F-7LJL---7F-JLJL--J||F--7LJL-J||F7F7F------7|||||L-7LF7JLJ-L-J-77F.7
|FJ|FJF--7.FJ|FJL--JF7F-7FJ-|F7L-J|F7F---J||FJL7LJL----JLJLJ|L7|||L7L7|||FJF7F-7FJ|F7F----7|LJF7L--7F7|||LJLJF7F---J|||||F-JFJL---7F7JFJ7J.-
FJJF7-L-7L7L7|L----7|LJL||F7LJL-7FJ||L-7F7LJ|F7L-7F77F-7|F7FJFJ|||FJFJ|LJ|FJ||FJ|F||LJF---J|F7||F--J|||LJF-7FJ|L--7JLJLJ|L--JF-7F7LJ|LJF|F-7
|LFF7-F7|FJFLJF7F7.||F--J|||F---J|FJL--J||F7||L-7LJL-JFJFJLJFJFJ|||.|FJF-JL7||L7L7|L7FL---7||||LJF7FJ|L--JFLJ7L---JF---7L-7F-JJLJL7FJJL7L--L
7--|L-JLJL7F7FJLJL-J|L7F7LJ|L----JL-77F7|LJLJL-7|F---7L7L7F7|LL7||L7||FJF7FJ|L7L7|L-JF----JLJLJF7|||FJF7F-7F7F7F7F7|F-7|F-JL----7JLJL--FJ.-J
|7JL7F---7||LJF7F---JJLJ|F-JF--7F---JFJLJF7F7F7||L--7L-JFJ|||F-J||FJLJL7||L7L-JJ||F7JL----7F7F7|||LJL7|LJFJ|LJLJLJLJL7LJL----7F7|-J|L|7LF-.-
L|LLLJ-F-JLJF7|||F--7F7FLJF-JF7|L----JF7FJ||||||L7F7|F7-L7|||L-7|LJ-F--J|L7L7LF7LJ||LF----J|||||LJ.F-J|F-JFJF7F-7F7F7L7JF7LF7LJ|L7LF|L--J-7J
|J|-J|.L-7F7|||LJ|F7LJ|F--JF-J|L------JLJJLJLJLJ||||LJ|F7LJLJLFJL7F-JF7FJLL7L7||JFJL7L7F7F7|LJLJJF7L--JL--JFJLJLLJLJL7L-JL7|L7FL-J.||7J.FF7-
L7.FL|JLLLJ||LJF7LJL-7LJF--JF7L----7F7F----7JF7|FJ|L--J|L--7F-JF-J|F7||L-7FJFJ|L-JF7L7||LJ||F----JL--7.F---JF-------7L---7LJFJF7F-7J-L7FFFJ|
L7F|F|J-F--JL7FJL7F7FJF7L7F-JL--7F7LJLJF---JFJL7L7L----JF7FJ|F7L-7|||||F-JL7L7|F7FJL7LJL-7||L7F--7F-7L-JF---JF----7FJF--7L--JFJ||FJ-LJJ7JL-L
.J7LFJLLL--7FJ|F7LJLJFJ|FJL7F--7||L----JF7F7L7FJJL-7F7F-J||-LJL7FJ||||||-F7|FJLJ||F-JF7F-J||FJ|F-J|.L---JF7F7L---7LJFJF-JF-7F|FJ|L77FJF7F|-|
.FJ.J||FF--JL7LJL7F--JL||F7|L7FJLJF7F--7|||L-JL--7JLJLJ-|LJ7|7.||FJ|LJ||FJLJL--7LJL--J|L-7LJL-JL--JF7F---JLJL----JF7|FJF7L7L-JL-JFJ7-.LF7|-L
F-J7FFJFL----JF--J|F---J|||L-J|F--JLJF7LJLJF7F-7FJF------7JLF--J|L7L7||||F--7F7|FFF7F7L--JF---7F7F7||L--------7-F7|||L-JL-JF----7L7|-7-L-7|7
7|L|-7-F------JF7FJL-7F-J||F--J|F----J|F-7FJ|L7LJ.|F-----J|.L-7FJ-|FJ-LJ||JJLJLJ7-||||F-7FL--7LJLJLJ|F-----7F7L-JLJLJF----7L-7F7L7L7F7F-.|.-
-J-J||JL-7F---7||||F-J|F-J|L-7FJL---7|LJ7LJFL-J|F-JL--7F7F-7J7||.LLJF--FLJ7JL|-F7-||||L7L7F7FL-7F7F7LJF---7LJ|F------JJF7||F-J||FL-J||7LF7.|
.L-L|.FJ7LJF7JLJLJFJF7|L-7L7FLJJF---JF7F7F7F7LF7L-7F-7LJLJFJF-JL7.||J-FLJJF77JFJ|FJLJL-JFJ||F7FJ|||L--JF7FJ.FJL---7F7F7|L7|L--JL7F7|||F7F--7
L|-FF|J.F7L||JF7|FJFJLJF-JFJF7F7L----JLJLJLJL7|L--JL7L7F7FJ.L-7FJ-7|-F-..F|L-7L7|L-----7|FJ|||L-J||F---JLJF7L-7F-7LJLJLJFJ|F---7LJL-JLJLJF-J
.77F7LJ-|L7|L-JL7L-J|F-JF7L-JLJL7F-------7F-7LJF---7L7LJLJF--7LJJ|||.J|FF-JF-JF|L---7F-J|L7|||F-7LJL-----7||F7LJFJF7F7F7L7|L7F7L7F-7F7F--J7J
FJJFJ7LFJFJL7F7FJF7F-JF7||F----7|L------7|L7|F7L--7L7L-7F7|F-JJ-F7L77F-F|F7L7.FJF7F7LJF7L-JLJLJFJF7F7F--7LJLJL-7L-JLJLJL-JL7LJ|FJL7|||L--77|
|--7FJ.L7|F7LJ|L7||L--JLJLJF---JL-----7FJ|FJLJ|F--J-L7FJ|LJL7JJFJ7.J-F--LJL7L-JFJ||L-7|L-----7FJL||||L-7L---7F7L----------7L7FJ|F7|||L7F-J-L
LF.|L-FFJLJ|F7L7|||F7FF7F7FJF7F----7F7|L7|L--7|L---7FJL-JF7FJ|||-JF|.J7|LFLL7F7L7LJ|LLJ-F----JL-7||||F7L---7||L-7F-7F-----J|LJFLJLJ|L7|L7|L|
|JFJ|F-JF-7LJL-JLJ||L7|LJLJFJLJF--7LJ|L-JL--7||F---JL7F7FJLJF77F7JFF7LJJ77.LLJ|FJF---7F-JF7F-7F7LJ|||||F7F-JLJFFJ|FJL7F7F7F---7J|LFL7|L-JJ-7
LFJ7LL-7|L|F-----7||FJL----J|JFJF7L--JF7F7F7LJLJF-7F7|||L7F-J|FJL7-F77|.J|..F-J|-L7F7LJF7|||FJ||F7|||||||L----7L-JL-7LJLJLJF7FJ.L7FL||7.|FLL
FL--7|-LJFJ|F----JLJL7.F7F7-FFJFJL----J||LJL---7L7LJ|LJL7LJF-JL7FJ7||-F7LF|.L--J7LLJL--JLJ||L7||||LJLJLJL-----JF7|F7|F7F---J|L-7|||JLJ-J-|7J
|---FF-L7L-JL--7F-7F7L-JLJL7FJFJF7-F--7LJF7F7F-JFJF7|F7JL-7L7FFJL7FJ|FJ|-|LFF---7FF7F----7LJLLJLJ|F--7F7F7F7F7.|L-J|LJ|L--7FJF7L-77-L|F|JL|J
||LFJ|-FLF--7F7LJLLJ|F----7|L-JFJL-JF7L--JLJLJF7|FJLJ|L7F7L-JFJF-JL7||FJF7FLL-7FJFJ|L---7L------7|L7FJ|LJLJLJL-JF-7L-7L---JL-J|F7L77FLLFJ7|.
F7F|-7F-JL-7LJL--7F7LJF---JL---JF7F7|L-7LF7F7FJLJ|F7FJFJ|L7.|L7L7LFJLJ|FJ|-F7FJ|FJFJF---JF-----7LJFJ|FJF------7FJFL7FJ7F----7FJ|L7|||JL7FF77
L7F--FJJLLLL7F--7LJL--JF-7F-----JLJLJF-JFJLJLJF--J||L7|FJFJF7LL7L7|F--JL7L7||L7|L7L7L-7F7|F----JF7L7||FJF7F7F7LJLF7|L--JF7F-JL-J7LJ--JL|J|-J
FLLJ.L.|FFLFLJF7L-----7|FJ|F---------JF-JF----J|F-JL7||L7|FJL-7L7LJL7F-7|FJ||FJL-JFJF7LJLJL7F-7FJ|FJ||L-JLJLJL7.FJ|L7F-7||L7|F--7-||L7.J-LJ|
|.L--|-L7-FF--JL-----7LJL-JL7F-7F7F7F7|F-JF-7LF7L7F-J|L7||L--7|LL-7FJL7|||FJ|L-7F-JFJL-7F--J|FJ|.LJ7LJF-------JFJFJFJL7LJL-JFJF-J-|-FF-JF|.F
|.|J||L||FLL-----7F-7|F7F---J|7||||LJLJL-7L7L7|L7||F7|FJ||-F7|L-7J|L7FJ|||L7|F-JL7-L--7||F--JL7|F7F--7L-----7F-JFJJL--JF7F--JFJ|J7LJJL.L7LFJ
L.J|L7LLLF7JF----J|FJLJLJF-7FJFJ|LJF-----JFJFJL7||LJLJL-JL7|LJF-JFJFJL7LJL7||L--7L7JF7||LJF--7LJ|||F7L-----7LJF7L------JLJF7FJL7F|JF7.FFJF-7
..FL-|F|L|L-JF----JL----7|7LJ.L7L7FJF--7LFJFJF7||L7F--7F--J|F7L-7L7|F7L-7FJ||F7F|FJFJLJL-7|F7L--J|LJL-----7L7FJL7F-----7F-JLJF-7F-7||--F.77L
F--L7.F|-L7F-JF7F7F7F7F7LJF7F-7L-JL-JF7L7|FJFJLJL-JL77LJ.F7LJ|F-JFJ|||F7||FJLJL-JL7L7F---JLJL---7|F7FF7F--J.LJF7LJF7F-7|L-7F7|FJL7LJ|.|F-JF|
-JL|JFF|.||||FJLJLJLJLJL-7|||FJF7F7F-JL7LJL-JF---7F7L---7||-FJL7FL7LJ||LJ|L----7F-JF|L7F7F7F---7||||FJLJF7LF7FJL--J||FJL--J|LJL7FL7FJ-|JF-L7
|FF|LF-F--J|FJF-7F-7F7F-7LJLJL-JLJLJF7FJF-7F7L-7FLJL----J|L7L-7L--JF-JL7FJ-F---J|F7FJFJ||||L--7||LJLJF7FJL7|||F---7LJ|F7LF7|F--JF7|L-7J|L.LL
F--JF-7L---JL7|FJ|FJ||L7L7F-7F-7F7F7||L-J7LJ|F7L-------7||FJF7L-7F-JF-7||F7L---7|||L7|-|||L7F-JLJF7F7|LJF-J|LJL--7L--J||FJ|||F7FJLJF-J|LL7.|
|F|F-JFJ|LJJLLJL-JL-JL7|7LJF|L7LJLJLJ|F---7JLJL--------JFJ|FJ|F-JL-7L7LJLJL-7F-JLJL-JL-JLJFJL---7|LJLJF7L--JF7F7FJF7F7|||FJ|LJLJF-7L7JJ7FL-|
|L-LJLF7|F|JF7.F-7F---J|F---JFJF----7LJF7FJF---7F7F-77F7L7|L7||F---JFJF7F--7||F7F7F-------JFF-7FJ|F---JL7F--JLJLJFJ||LJLJL7L7F--J.L-J..7-|.L
F-LL-F-7FF7FJ|FJFJL----J|F-7FJFL---7L7FJLJ|L-7FJ|||FJFJL-J|FJ|||F7F-JFJ||F7LJLJLJ||-F7F--7F-JFJL7|L----7LJF7-F7F7L7||F---7L-JL---7F7F777.|7J
F7-J|L7L7||L7|L7|F7F---7LJFJL7F----J-LJ-F7-F-JL7|||L7L---7|L7LJ||||F-J.LJ|L7|F7F-JL7|||F7|L-7|F7LJF----JF-JL7||||FJLJL--7L7F7F7F7LJLJL-7-FJJ
||FJ7FL7LJL-JL-JLJ|L--7L-7L7FJL7F-------JL7L--7LJLJFJLF7FJL7|F-J|LJL7F7F-JFJFJ|L-7FJ||||LJF-JLJL77L7F7F7|F-7LJLJLJF7F-7FJJLJLJLJ|F-----J-||.
J.J-7-FJF--7F7F--7L---JF7|FJ|F7LJF----7F--JF--JF---JF-J|L-7|||F-JF--J||L-7|FJFJF7||FJLJL7-L-7F--JF7LJLJ||L7|F-7F7FJ|L7||JF--7F7JLJF7JF7JF-LF
|FL-77L-J-FJ|||F7|F7F-7|LJL-J||F7L---7LJ-F7L--7|F7F7L-7|F-JLJLJF-JF-7|L7FJ|L7|-||||L--7FJF7FJL7F7||LF7LLJFJ|L7|||L7|FJ|L-JF-J||F7-|L-J|.|LL|
FLJ-L-JL|JL7|LJ|LJ|||FJL7FF7FJ|||F7F-JF-7||F7FJLJLJ|F-J|L-7F--7|F7L7||FJL7|FJL7||||F-7|L-J||F7LJ||L7|L7F7L7L-J||L7||L7L7F7L--JLJ|FJF7FJF|.F7
J.F||LJ..F-LJ|FJF7|||L-7L7||L7LJLJ||F7|FJ||||L-7F--J|F7L--JL-7LJ||FJ||L7FJ|L-7|||||L7LJF7FJLJL-7||FJ|FJ|L-JF7|LJ||||FJFJ|L7F-7F7LJFJLJF77-FJ
FF|FJ---LJF|-FJFJ||LJF7L7LJL-JF7F7LJ||||FJLJ|JFJ|F7FLJL---7F-J7FJ||FJ|FJL7L-7|||LJ|JL7FJLJF--7.|||L-JL7L---JL77F7LJLJLL-J7LJFLJ|F7L--7|L--7.
LJL7J.L77FJ||L-JFLJF7||JL7F--7|||L--JLJ|L-7FJFJFJ||F7F7F-7||F-7L7|||FJL7||F-J||L-7|F-JL--7L-7|FJ|L-7F-JF----7L-JL--------7F7F7-||L7F7LJF7FJ7
F|7L-FJ|F7LF||F7F--JLJ|F-JL-7LJLJF7F---J7FJ|LL7L7|LJ|||L7LJ|L7|FJ|||L-7L7|L7FJ|F-J|L7F---JF7||L7|F7||F7|F7F7L7F7F-----7F7LJLJL7||FJ||F-JLJJL
--7JJ|.FJLF---J|L-7F-7LJF--7|F---JLJ.F7F7L7|F7|FJL7FJ||JL-7|7||L7|||F7|FJ|FJ|FJL-7|-||F7F7||||7||||||||LJLJL7|||L-7F7J||L7F---JLJ|FJ|L-7JJ|.
.L|7F|-L||L---7|F-J|.L-7L-7LJ|F---7F-J|||FJ||||L7FJL7||F-7|L7|L7|LJ|||||FJ|FJL7F7|L7|||||||LJL7|||||LJ|F-7F-JLJ|F7LJL7|L7|L-----7LJ-L-7|-777
FLL7-J7L|F|-F-JLJF-JF7FJF7L-7LJF--J|F-J||L7||||FJL7FJ||L7||FJ|LLJ|FJ||||L7LJJFJ|||7||LJ||||F7FJ||||L-7||FJL7FF7LJL--7||FJ|F-7F--JF-7JLLJL|LL
F|F|7.F-J-J.|F7F7|F-JLJFJL--JF7L--7|L7FJ|FJLJ|||F7|L7||FJ||L7L---7L-J||L7L7F7L7|||FJL-7|||LJ|L7||||F-JLJ|F7L-JL-7F-7LJLJ7||7|L7LFJFJ.LL.F|J7
.|FL--L-J|F-LJLJLJL-7F7|F--7FJL---J|JLJFLJLF-J|||LJ-|||L7LJFJF---J|F-J|-L7LJL7|||||F-7|LJ|F-JL|||||||F--J|L-7F--J|FJ|F--7|L7L7L-JFJ.L7.7-JL7
JL7.L|J77FL7.F------J|LJL-7|L--7F-7L-----7FJF7||L7F-J|L7|F-JFJF7LF7L7FJF-JF7FJ|||||L7||F-JL--7|||||L7L--7|F7|L-7L|||FJF7||FJLL7F7L7-JL.||..F
|.77.LF|7FJ.FL--7F--7|LF--JL---J|FJF7F7F7|L7||||FJL-7L7LJL7FJFJL7||J||J|F7||L7||||L-JLJL7F7F7|||||L7L--7LJ|LJF7L-JL-JFJLJ||F7FJ||FJ-||FLJF-|
-F.-.|LLFLJ.F7-LLJF7|L7L-----7F7|L7||||||||||||||F7FJFJF--JL7L7FJ|L7||FJ||||FJ||||F---7FJ|||LJ||LJFL7F-JF7L-7||F7F---J-F-JLJ|L-J||J-LL--J-JL
||-|FJ..|JLFJ||LF-JLJFJF---7FJ|LJJLJ||||||FJ||||||LJFJ7L---7L-JL-JFJLJL7||||L7||LJ|F-7LJFJ|L7FJL7F7FJL--JL7FJ|LJ|L----7L----JF7F||77JL-FJ7J.
F|JLLJ-FJ|.|FJJ-L----JFJF-7LJFJJF---J|||||L7||||||F7L7F----JF-7F-7|F--7|||||FJ|L-7LJ-L-7L7|FJL7FJ|LJF-7F7FJL7L-7|F7F--JF7F--7|L7LJLF7FFF77FF
FF-L|JJF--F|L7|F7F7LF-JFJ|L-7L-7L7F7FJLJ|L7||||LJLJ|FJ|F-7F7L7|L7|LJF7||||||L7|F-JFF7F7L7||L-7LJLL7FJL||||F-JF-J|||L-7||LJF-J|FJF7F|L-7JLLJ.
|J7|L7L7LFJL7|FJLJL-JF7|F---JF7|FJ||L-7-L-J||LJF---J|FJL7LJL7|L7||F-JLJLJ|||FJ||F--JLJL-J||F7L-7F7||F7||LJ|F7L-7|||F7L-JF-JF7|L-JL-JF-J7F7-7
J|LJL7-|.|-FJLJF-7F--J||L-7F7|LJL-J|F-JF7F7|L7FL7F7FJ|F7L-7FJL7LJ|L-7F7F-J|LJ-LJL-7F7F-7FJ|||F7||LJLJ|||7FJ||F7||||||F7FJF7|LJF7F---JJ-J|L7|
LJJ--F-F.F.L-7FJFJ|F--J|F-J|LJF-7-FJL--JLJ||FJF-J|||FJ||F-JL7FJ|FJF-J|||F7L-7F7LF-J|LJFJL7LJLJLJL-7F-JLJFJFJ||LJLJ|||||L-JLJF-JLJJ-JJ77.|LLL
|LJJ.-.|FF---J|-L-JL-7FJ|F7L77L7L-JF-7F7F7||L7L-7|LJL7||L7F-JL-7L7L--J|LJL-7LJL7L--JF7|F7L-7F7.F--JL--7FJFJFJL7F--J|||L7F7F7L-7||..|FFL-J-J|
J-F7L-7--L---7|7F----J|FJ|L7|F7|F-7L7||||||L7L7FJ|7F7|||FJL7F--J-L-7F7L--7FJF-7L-7F-JLJ||F7||L-JF-7F-7|L7L7L7FJ|F7FJ||LLJ|||F7L-7-FL7|L-L|FF
|F|J.FJJ-J7.FJ|FJF7F7FJ|FJFJ||LJ|JL7|LJLJLJF|FJL7|FJLJ||L-7|L7FF-7FJ|L-7FJ|FJ7L7FJL-7F-J||||L7F7L7|L7||-|FJFJ|7LJ||.|L-7FJ|LJ|F-J-F---|.7L-7
|-JJLLJ||.-7L7|L-J|||L7|L7L-J|F7|F-JL--7F7F7|L7FJ|L-7FJL7FJL7L-JFJL7L7FJL7|L--7|L7F-J|F-J|||FLJL7||FJLJFJL7L7L--7||FJF-JL-JF-JL-7.LF-7L7-7||
|7|7LJ77--7L7LJJLLLJ|FJ|FJF--J|||L-7F-7LJLJ|L7|L7||FJL77LJ|FJF7FJLFL7|L7FJL7F7||FJL-7|L7FJ|L-7F7LJ||-F7L7FJ-L--7|LJL7L-7F-7L-7F7|FFFJ...LLJ.
|J|F7J.F7.7.F|J||LF-J|L|L7|F7FJLJF-JL7L7F-7|FJ|-LJFJF7|F---JFJ|L-7F-JL7||F-J||||L7F7||J|L7L7FJ|L7FJL7|L-JL----7|L-7FJF7LJFJJ.LJLJ7LJ7-7|-7-L
F7|||J-7LFJ-J--J|-|F7L7L7|||LJF--JF-7|7|L7||L-JF7FJFJLJ|F7F7|FJF7||F7FJ||L7FJ||L7||LJL7L-JJ||JL7LJF7|L---7F-7FJL--JL7||F-JFJFJJ7|LF7-.J..|7J
J-J7|F7L7J|7FL|FJ-LJL-J7||||F-JF7FJFJ|FJFJ||F-7|LJFJF--J|||||L7|LJLJ|L7|L7LJFJ|||||F7FJF--7LJF-JF7||L7F--J|FJL-----7|||L7.---7JL|-LFJF-7.L.L
L|.7-J|L|-L|-FFJ..LJJ-|LLJLJ|F7|||7L-J|FJ7||L7LJF7|FJF7FJ||||-|L---7L7||FJLLL7L7||||||7L-7|F-JF7||||FJ|F-7|L7F7F7F7|LJL7|JF77F7|L7L|.|JLJ.J.
F|.L-LJ7L||L--J-FFJFF7F|-F--J|||||F---JL-7||FJF7|LJ|FJ|L7||||FJF---J||||L-7F-JFJ|||||L7F-J|L7FJLJ||LJ.||FJL7||LJ|||L--7LJF|J|-.L-L7FF7..L-|7
J|F|-|F|-JJLLJ-FJ|.|L--.FL7F-JLJ|||F-7F7FJLJL7|||JFJL7|FJ||||L7L----7LJ|F-J|F7||||||L7||F7L-JL-7F||7F-J|L7FJ|L-7|||F-7|-J7--J-7J7-J7|L--J.|-
LL|JJ.-L-J.FL--7-J-7-.J7|LLJ.LL7LJ||FJ|LJ-F7J||||FJF-J||FJ||L7L-7F7FJF7|L-7LJ|L7||LJJLJ||L7F7F7L7||FJF7L7||FJF7|||||JLJJJ||.F-J-7-|LJ.7JJ|J|
|L|7.-7J..|-JF||77LL|7-J7J-|.L|-||LJL7|F7FJL7LJLJL7L-7|||FJL7|F-J||L-J|L7FJ-FJFJ|L7J-F-J|LLJLJ|FJLJL7||FJLJ|FJLJ||||J|..|.|-J|J7.||FJL||FLJF
F7.FF-F77.L|.7L|77-||LFJ|.7|..LFF|FF-JLJLJF-JJ.L|7|F7||||||L||L7FJ|F-7L7LJJ.L7L7|FJ7-L-7L-7J|F|L7|.||||L--7|L7-LLJLJ--7F-FL.LJ.|FJ-F7F77-JFF
.|F7|.LF--F-7L7JL|-F-F-7|FL7F--L|--L-7F-7FJ-L77.F-J||||||L7L||JLJL||J|FJ.|.|F|FJ||FLF--JF-JJF-|FJ7.LLJ|F7FJ|FJ.L|.L|F|LJJF.7.L-7LJ.L77LL.L|J
JFFL|7.||FL--7L7.-.JLLJ.F7-7FF7-LJL|LLJ-|L7-LFJ-L7FJ||||L-J-LJ--JJ|L7LJJ77FJLLJ-LJ-7L--7L7JF-7LJJ77LLFJ||L7||JJ.---F7-||FJ-77|-L|J.|L77.F7L|
|-|7LL-F-J7.L|-LJL-L7L7FLJFFJJJ-|JF7J||.|FJ7LLJFL||JLJ|L-77.LLJ.FFL-J.|.J7|-JL|-L7L|JJL|FJ-L7LJ.L7--LL7|L-JLJJ-F||LFL-77JL7-|77L|7F||7-FF|FF
|-J|JLJJ7L|7.---J|FLF.L7J.-.L||.|FL|7LL.LJF|FLF|JLJ-|.L--J77-LJFLJLJ.L77LFJFFFJ-L7.|J..LJJ.LF|-LFJ||LLLJF|FL-7-F7LFF|FJFF-J.LLL.LJLJF-J.|LFJ
|J-F7FL-77L---7JLJJ.J7.J.FLF---FL7JL-..FL|-77-J.J7.|F-LJ-||-JF7--|JF-J|L7|J7L7J.FJ|77FJJ|J-FL|7.|FFJ.FL.|J|L|.-JJ7FJJL.-J7F|L|-F|FL-|7.F|.L.
J|7L.FLFLF-LLFF7.F|..LF|-.||LJFJF7.LL77F|JJFF-...77F7JL|LL||7F|...FL.-J-.F7|||7FF7L|F--FJ.-7.FJ--LJJF|.JJF|F.|J|FFLJF|7F|L7|FJFF-||F7F-L--.7
|L-.LJFL-F-F.|L-7-|.7FFF.FFLJL--7.|.L|7-|-7|LLL77LL7LF-77|LF||L7-77FJ-|.LL|7J7L7J|J|7F-J|FJJF7FF||.7||.L7FL|-J777JLJ7LJ|7|L||JF|7.LJLJFL|FJ.
FJLLJL---|L7J-LLJ.J.--JJ.7..F7J.J-LF-JJ.J--7JJ|JL7JLF..LJJ-LFJJ.-JL7L-JJ.LLJLL.L-J-LLJJ-JLJ-JJJ-F--LF-J-LL-L7LJ.L-L|7-7JLLJLJLJJJ7JL-L7L|JJJ";

var smallInput =
@".F----7F7F7F7F-7....
.|F--7||||||||FJ....
.||.FJ||||||||L7....
FJL7L7LJLJ||LJ.L-7..
L--J.L7...LJS7F-7L7.
....F-J..F7FJ|L7L7L7
....L7.F7||L7|.L7L7|
.....|FJLJ|FJ|F7|.LJ
....FJL-7.||.||||...
....L---J.LJ.LJLJ...";

smallInput =
@"...........
.S-------7.
.|F-----7|.
.||.....||.
.||.....||.
.|L-7.F-J|.
.|..|.|..|.
.L--J.L--J.
...........";

smallInput =
@".F----7F7F7F7F-7....
.|F--7||||||||FJ....
.||.FJ||||||||L7....
FJL7L7LJLJ||LJ.L-7..
L--J.L7...LJS7F-7L7.
....F-J..F7FJ|L7L7L7
....L7.F7||L7|.L7L7|
.....|FJLJ|FJ|F7|.LJ
....FJL-7.||.||||...
....L---J.LJ.LJLJ...";

smallInput =
@"FF7FSF7F7F7F7F7F---7
L|LJ||||||||||||F--J
FL-7LJLJ||||||LJL-77
F--JF--7||LJLJ7F7FJ-
L---JF-JLJ.||-FJLJJ7
|F|F-JF---7F7-L7L|7|
|FFJF7L7F-JF7|JL---7
7-L-JL7||F7|L7F-7F7|
L.L7LFJ|||||FJL7||LJ
L7JLJL-JLJLJL--JLJ.L";

smallInput =
@"..........
.S------7.
.|F----7|.
.||....||.
.||....||.
.|L-7F-J|.
.|..||..|.
.L--JL--J.
..........";

var smallest = "";

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0;

var grid = input.Split(Environment.NewLine).Select(x => x.ToCharArray()).ToArray();

var nodes = new Dictionary<(short x, short y), Node>();
var borders = new List<Node>();
for (short y = 0; y < grid.Length; y++)
{
    for (short x = 0; x < grid[0].Length; x++)
    {
        var symbol = grid[y][x];
        var isBorder = y == 0 || x == 0 || y == grid.Length - 1 || x == grid[0].Length - 1;
        var node = new Node { Symbol = symbol, X = x, Y = y };
        nodes.Add((x, y), node);
        if (isBorder)
        {
            borders.Add(node);
        }
    }
}


foreach (var node in nodes.Values.Where(x => !x.IsStart))
{
    node.SetTunnelNeighbours(nodes);
}

var startNode = nodes.Single(x => x.Value.IsStart).Value;
if (startNode.North != null && startNode.South != null) { startNode.Symbol = '|'; }
if (startNode.North != null && startNode.East != null) { startNode.Symbol = 'L'; }
if (startNode.North != null && startNode.West != null) { startNode.Symbol = 'J'; }
if (startNode.South != null && startNode.East != null) { startNode.Symbol = 'F'; }
if (startNode.South != null && startNode.West != null) { startNode.Symbol = '7'; }
if (startNode.East != null && startNode.West != null) { startNode.Symbol = '-'; }
startNode.IsInMainLoop = true;
while (true)
{
    var other = startNode.GetNeighbours().Where(x => !x.IsInMainLoop).FirstOrDefault();
    if (other == null) { break; }
    other.IsInMainLoop = true;
    startNode = other;
}

foreach (var node in nodes.Values)
{
    node.SetAllNeighbours(nodes);
    if (!node.IsInMainLoop)
    {
        node.Symbol = '.';
    }
}

foreach (var node in borders)
{
    Flood(node);
}

var tmpGrid = nodes.GroupBy(x => x.Key.y).Select(x => x.Select(y => y.Value)).ToArray();
//PrintGrid(tmpGrid);

var windRose = new List<Func<Node, Node>>()
        {
        x=>x.North, x => x.East, x => x.South, x => x.West
        };

var insideDirection = 3;
var initWallTravel = nodes.Values.First(x => x.East != null && x.East.IsInMainLoop && x.East.Symbol == '|').East;
var hiddemGems = new List<Node>();
Travel(initWallTravel, initWallTravel.South);

foreach (var node in hiddemGems)
{
    Flood(node);
}

void Travel(Node currentNode, Node previousNode)
{
    if (currentNode.Symbol == '|' || currentNode.Symbol == '-')
    {
        var inside = windRose.ElementAt((insideDirection + 4000) % 4);
        var insideNeighbour = inside(currentNode);
        if (insideNeighbour != null && !insideNeighbour.IsFlooded && !insideNeighbour.IsInMainLoop)
        {
            //insideNeighbour.IsFlooded = true;
            hiddemGems.Add(insideNeighbour);
        }
    }
    else if (currentNode.Symbol == 'F') // south east
    {
        if(currentNode.South == previousNode)
        {
            insideDirection++;
        }
        else
        {
            insideDirection--;
        }
    }
    else if (currentNode.Symbol == '7') // south west
    {
        if (currentNode.South == previousNode)
        {
            insideDirection--;
        }
        else
        {
            insideDirection++;
        }
    }
    else if (currentNode.Symbol == 'L') // north east
    {
        if (currentNode.North == previousNode)
        {
            insideDirection--;
        }
        else
        {
            insideDirection++;
        }
    }
    else if (currentNode.Symbol == 'J') // north west
    {
        if (currentNode.North == previousNode)
        {
            insideDirection++;
        }
        else
        {
            insideDirection--;
        }
    }

    var next = currentNode.GetTunnelNeighbours().Single(x => x != previousNode);
    if (next == initWallTravel) { return; }
    Travel(next, currentNode);
}

void Flood(Node node)
{
    if (node.IsInMainLoop)
    {

    }
    //if (node.X == 14 && node.Y == 3)
    //{

    //}
    node.IsFlooded = true;
    foreach (var item in node.GetNeighbours().Where(x => !x.IsInMainLoop && !x.IsFlooded))
    {
        Flood(item);
    }
}

result = nodes.Count(x => !x.Value.IsInMainLoop && !x.Value.IsFlooded);

tmpGrid = nodes.GroupBy(x => x.Key.y).Select(x => x.Select(y => y.Value)).ToArray();
PrintGrid(tmpGrid);

timer.Stop();
Console.WriteLine(result); // 531 too high
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();


void PrintGrid<T>(IEnumerable<IEnumerable<T>> grid)
{
    for (int i = 0; i < grid.Count(); i++)
    {
        for (int j = 0; j < grid.ElementAt(i).Count(); j++)
        {
            Console.Write(grid.ElementAt(i).ElementAt(j));
        }
        Console.WriteLine();
    }
}

class Node
{
    public Node North { get; set; }
    public Node South { get; set; }
    public Node East { get; set; } // right
    public Node West { get; set; } // left

    public bool IsStart => Symbol == 'S';
    public bool IsInMainLoop { get; set; }
    public bool IsFlooded { get; set; }
    public bool WormholeConsidered { get; set; }
    public char Symbol { get; set; }
    public short X { get; set; }
    public short Y { get; set; }

    public int Travel(HashSet<Node> breadCrumbs)
    {
        foreach (var neighbour in GetNeighbours())
        {
            if (!breadCrumbs.Contains(neighbour))
            {
                breadCrumbs.Add(neighbour);
                return neighbour.Travel(breadCrumbs);
            }
        }
        return breadCrumbs.Count;
    }


    public IEnumerable<Node> GetTunnelNeighbours()
    {
        if (Symbol == '|')
        {
            yield return North;
            yield return South;
        }
        else if (Symbol == '-')
        {
            yield return East;
            yield return West;
        }
        else if (Symbol == 'L')
        {
            yield return North;
            yield return East;
        }
        else if (Symbol == 'J')
        {
            yield return North;
            yield return West;
        }
        else if (Symbol == '7')
        {
            yield return South;
            yield return West;
        }
        else if (Symbol == 'F')
        {
            yield return South;
            yield return East;
        }
    }



    public IEnumerable<Node> GetNeighbours()
    {
        if (North != null) { yield return North; }
        if (East != null) { yield return East; }
        if (South != null) { yield return South; }
        if (West != null) { yield return West; }
    }


    public void SetAllNeighbours(Dictionary<(short x, short y), Node> nodes)
    {
        Node Get(int x, int y)
        {
            nodes.TryGetValue(((short)x, (short)y), out var found);
            return found;
        }
        North = Get(X, Y - 1);
        South = Get(X, Y + 1);
        East = Get(X + 1, Y);
        West = Get(X - 1, Y);
    }


    public void SetTunnelNeighbours(Dictionary<(short x, short y), Node> nodes)
    {
        Node Get(int x, int y)
        {
            nodes.TryGetValue(((short)x, (short)y), out var found);
            return found;
        }
        void SetNorth() => North = Get(X, Y - 1);
        void SetSouth() => South = Get(X, Y + 1);
        void SetEast() => East = Get(X + 1, Y);
        void SetWest() => West = Get(X - 1, Y);

        if (Symbol == '|')
        {
            SetNorth();
            SetSouth();
        }
        else if (Symbol == '-')
        {
            SetEast();
            SetWest();
        }
        else if (Symbol == 'L')
        {
            SetNorth();
            SetEast();
        }
        else if (Symbol == 'J')
        {
            SetNorth();
            SetWest();
        }
        else if (Symbol == '7')
        {
            SetSouth();
            SetWest();
        }
        else if (Symbol == 'F')
        {
            SetSouth();
            SetEast();
        }
        else if (Symbol == '.')
        {
        }
        else if (Symbol == 'S')
        {
            throw new Exception(); // seperate setter
        }
        else
        {
            throw new ArgumentException(Symbol.ToString()); // seperate setter
        }

        if (North != null && North.IsStart)
        {
            North.South = this;
        }
        if (South != null && South.IsStart)
        {
            South.North = this;
        }
        if (East != null && East.IsStart)
        {
            East.West = this;
        }
        if (West != null && West.IsStart)
        {
            West.East = this;
        }
    }


    char Better()
    {
        switch (Symbol)
        {
            case '-': return '─';
            case '|': return '│';
            case 'F': return '┌';
            case '7': return '┐';
            case 'L': return '└';
            case 'J': return '┘';
            default:
                return Symbol;
        }
    }

    //public override string ToString() => Symbol.ToString();
    //public override string ToString() => !IsInMainLoop && !IsFlooded ? "." : " ";
    //public override string ToString()
    //{

    //    if (!IsInMainLoop && !IsFlooded)
    //    {
    //        return "I";
    //    }
    //    else
    //    {
    //        return Better().ToString();
    //    }
    //}
    public override string ToString()
    {
        if (IsInMainLoop)
        {
            return Better().ToString();
        }
        if (!IsFlooded)
        {
            return ".";
        }
        return " ";
    }
}