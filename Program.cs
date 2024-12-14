﻿using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

var fullInput =
@"????.??.??. 1,1
????#???..?.?? 5,1,1
????????#????#?.# 1,2,3,2,1
?#???#?#?????.?# 11,2
?????.?#??.? 1,1,2
?.???#????????? 1,8,2
?###?.?????????? 5,2,1,1,1
??.???#????????? 2,1,1,7
??#???.????.?# 5,4,1
.?#?.??.????.#??? 2,1,3,3
??#???????##???#.##? 4,1,6,3
?.?#?????#???????? 10,4
.?.??.???.???? 2,3
?#?.?????.???#???? 1,3,3,3
??##????.??#??#. 2,3,1,1,2
?????.????.# 4,1,1
???.??##?????.????? 1,4,1,1,1,1
.??.??.?#?##?#? 1,1,6
???..????.#?#? 2,1,4
#???#?#?#?#?????#.?# 1,2,7,1,1,1
?????...?.???#???? 3,1,6
?????###?.#??#? 1,1,4,2,1
??#??.#??#?.#.#??##? 2,1,1,1,6
.?...#.??. 1,1,1
??..??????????. 1,9
????????#.?#???. 1,3,1,2,2
?#?.???.??????????# 3,1,3,4
?????##?.?#?? 2,2,2,1
???..#?#????? 1,3
.???#???##???##??#?# 10,2,3
??.?.?#??? 1,1,4
##??#??#????????#?.# 10,1,2,1,1
#???#????????#???? 1,1,10
.#?..?????. 2,2,1
?#?#.??#?????? 3,2,3
?????#??#?.#??? 1,7,4
#??.???.?#?????..? 1,7
##?#.?#.?? 2,1,1
.??..??.?????#?? 2,1,8
??##??.??##???#??... 2,8
?#???#.?.????#??? 3,1,1,4,1
???#.?????.??? 1,1,2,2
.??????????? 5,1
????.?#?#????.???. 3,6,3
????????##???? 1,1,7,1
???.??.???? 1,2,2
??#?#..??#?#??.? 4,5,1
.???#?.?????????? 4,7
????????#???#???### 3,1,8
????###?#?? 3,1,1
?.?..#?????##??##?#. 1,2,11
???.????????###???# 1,1,1,12
?.#?#???#...###? 7,3
???.?#??#? 1,5
??#????#.?.#? 5,1,1
..###.??#? 3,1
??.#?????????? 1,2,4
?.???????????.#.?? 7,1,1,1
#??##??.?? 5,1
??#?#????#??? 4,2,1,1
?#??##???#.???#.#? 6,3,3,2
??.?.???#? 1,1,1
?.??.???????. 2,2,1,1
??#????#.# 4,1,1
??.??????#.???#????. 1,1,3,2,2,1
#???.??.###? 1,2,1,4
.?????#?#?? 4,3
.?#?????#.?##??? 2,4,3,1
#???#???#????#. 2,7,1
##??#???#?????.??#?# 9,1,2,1
#?#?.?#.????#???? 1,1,1,2,4
??????#?.?????#?#? 2,1,2,2,5
??#..????#.?? 1,1,1,2
??..#?????#?#??.# 2,1,6,1,1
#?????????# 3,1,3
###??????#???.????? 5,1,4,1,1
?##.??#??.? 2,5,1
.#??#???????.??# 2,4,2,3
.#??????#?????. 2,6,2
??.?###.?#?????.?? 1,4,2,3,1
?????##???? 1,2,1
????????#??##? 1,2,2,2
????????.??? 1,1,3
?????.?????#????##?? 1,1,2,8
.?????.????# 2,4
??##??#?..#..?#?. 6,1,3
???.???.#?#?..#?.# 1,3,1,1,1,1
.?.#####.?.??? 5,1
??##??#.????#?.# 1,3,1,4,1
?#?##???.??. 7,1
.????#?#??????.? 1,7,2,1
.#??#?????? 4,1
?#???????.?##?? 4,1,5
?#???????#?.??##???? 11,4
??#..#...??##? 1,1,1,3
?.?????.?#?.??#?#.? 1,1,1,2,5,1
?????#??????? 6,1,1,1
.??#??????.?##?##?#. 4,8
????.?#??????#??#. 1,1,1,5,2
?#..?.##?? 1,3
?##??????#???.#. 10,2,1
?.#?.???#??.? 2,4
??.??.???? 1,1,3
#?#??#?###?.?.? 1,1,6,1
??#?????#?.?. 3,1,2,1
??????#?.???#.? 7,1,1,1
.????.???? 2,1
..#???.####????#??? 1,5,3,1
?????#..???? 3,1,1,1
.##?#??##? 2,2,2
???????##?#????.?? 11,1
?????#??#.?????? 1,6,1,1
???.#.??#. 1,1,2
#?#??#???####?.?? 13,1
???????..#??#??.?. 1,1,2,5,1
..?#???.??. 3,1,1
??#?#???.? 2,1,2
#?.???.??? 1,3,2
?##...????.?#?. 2,4,2
?.??????????? 1,1,6
#??#????????. 4,3
?.?##?.?#?#?.?.??.?? 1,3,4,1,1,1
??#?????????? 1,1,3,4
??.??.?.##. 1,2
#?.???...??? 2,2,1,1
????#?#???#?##??##?? 1,17
?###???#?????.??.??. 13,1,1
?.??#?#????.##??? 1,7,2,2
..#???#?????#?#????. 6,6
??.?#?.???#??? 1,1,4,1
??#.???#?#?. 1,4
??.???...?????##? 2,7
??#??????.???.?.?? 1,3,1,1,1,1
??#?#?????#??????# 6,3,5
?#???????????? 2,6,1,1
???#???#.??#?.??. 6,1,3,2
??#?##.????.#.???.? 5,1,1,1,2,1
.?#?.??#??.? 1,3
???.????#? 2,2,1
?#???#.#?#?.???#..?? 6,1,1,1,1,2
.??#??.?#. 4,2
?????????.??#???. 1,3,1,2,1
#??.???.?#.?#..?. 3,2,1,1,1
##.??????#??###????. 2,9
?.??#??#?#??...??. 1,8,2
?..???#????#????#? 5,4,3
????#???##???#? 1,2,8
????????#????#??.#? 6,1,1,1,1,2
??#?###?.#?.?? 7,1,1
??..?#?#?? 1,2,1
????????#??#. 4,3,1
.?#.???##..??#?? 2,5,3
????.?.#?.?.?##??? 1,4
????#???#?.?####. 7,4
?.???????#??#? 3,5
#??????.?#.??? 1,2,2,1
???.??.?#. 1,1,1
##?##??????????.? 5,1,1,1,1
?????????##???.#??. 5,3,2
????????#.#??.# 4,1,1,3,1
??.??#??.??# 5,1
?#.???.??.? 2,2,1
?.#??????.#???# 1,4,2,2,1
?##??#??.??..?.? 2,3,1,1,1
????.#??.?#???#?.?. 1,1,2,2,4
????.????#??.????# 2,2,3,1,1
??.??.??.? 1,1
.??.?##??...?#???. 3,3
.?????????#?##..?. 3,1,5,1
?.???#..????? 1,3,3
?.#?.?#.#???? 2,1,2,1
??#??#?#?.??.#.??? 1,7,1,1,2
?#.??#?##?#.?##??#? 1,1,6,2,2
?#????????.?????..?? 9,1,1,1
.????#??#?? 2,5
#?#?.????? 3,1
.???.????? 1,3
????#.???.?#????#??? 4,1,8
???#??????? 1,5
???..?.??.. 1,1,1
.??.?#..??#?.???? 2,2,3,1,1
????.?????? 2,1,1
#.?...?????? 1,1,1,1
##???.#.#?#.##..? 4,1,3,2,1
???.#.#???#.#?? 1,1,5,1,1
?????#?.??#?. 4,2
???#??#.????#?.??..# 1,5,4,1,1
????##????##? 3,8
?##???####?#????..?? 12,1,1
???.?????.. 1,4
?#?????#????##?. 3,5,3
???.?????#.?? 1,4,1
??.#?.???#?.??.? 2,2,4,1,1
?.???????#????##???. 1,1,7
??????#?#???##?.? 8,3,1
.??????#???.? 1,5,1
?????#??...?#??? 5,1,4
.?????.???? 4,2,1
????.#??.???????? 3,3,1,1
#????????##????? 1,8,1
??.##???#? 3,2
?#???..???????? 3,1,2,1,2
?.???????? 1,2,2
??#?.##??????#.?#??? 1,1,9,4
?#?#?##?.#?. 6,1
???#????????#?#?.?? 2,1,3,1,2,1
??#??#?????#??? 4,4
?#?.?##??#..?##? 1,6,3
????##?..?.#? 6,1,2
??##??.?#?.?. 1,4,2
???##????????? 1,4,3
##?#??.????#?###???. 2,2,3,4
???##???#.??? 5,2
?..?#?#?##?#????#??? 10,1
??.???##?#??????? 1,7,1,1
?..#????##?. 1,4
?????.??#? 1,1,3
?????.?#?#?##??.??#. 3,8,3
.??#?????.##????##. 7,2,1,3
.?????#?.?.??.? 1,2,1,1
?#???????????.?#?#? 4,7,4
??.????#?#.#??. 1,1,3,1,1
???#????.?? 6,1
?????.???? 2,2,3
?.#????????.?.? 4,2
??????#?#???##??#?? 1,16
??#???????# 5,1,1
?..#?.?#??#.??????? 1,2,1,3,3
?.??#??#?.??##?? 1,1,5,5
?..?????##??????#??? 1,1,8,1,1
?.#?????##??#.?? 2,5,1,1
.?#?#.?.##????#?? 4,1,5,1
#???????#??#.?#??. 4,7,1,1
#????.#???##.? 5,2,3
?????????#?##??????? 2,1,11,2
#?.#??????????#? 1,4,4,1
??#?#?.#???.?##????? 5,4,4,2
???????##??.? 2,4,1
?.#????????..?? 1,1,1,2,1
??..???#??#??#?#??. 1,8,5
?#?#??.#?#?? 1,1,4
?.?.#???.???. 1,2,3
???..?.?????.? 1,5,1
???#??##?#?? 8,1
.???#?.?.? 4,1
#.#???.??????#?# 1,3,3,4
????????#.??? 1,7,1
??#???##??? 1,5
#????????#? 2,3
.????.???#?.??#? 3,2,3
?.?#.??#?.##???? 2,2,6
??#???.???.????. 2,1,2,1,1
.???.??.???####?? 2,2,1,7
.?????#??#???? 2,3,5
??????#??##? 2,1,2
..?.##??.??#?.# 1,2,1,3,1
.??#?.??.??#??. 2,1,4
?.??????#?#???#?? 10,2
??????#??????????#?# 1,1,15
?????#?###??..?? 3,7,1
???#??????#?.# 5,2,2,1
??#??????##??#??.??# 6,7,3
#????.???#.????# 1,3,2,2,1
.#?.?.?.?. 2,1
#?????#..??# 4,1,1,1
?#??.???#?????#?# 1,1,10
?.#???#?##? 2,6
...?.#????#???# 1,1,2,1,3
??.??????#???.?.? 1,1,1,6,1
?#???#??.??? 3,4
.?#..???#??? 2,3
.?#??????.???##? 2,2,1,3
?#?#..??????.#?#??? 4,1,2,1,4
?.??.????. 1,1,3
???.?.??????#?#??# 2,1,9,2
??..??#..?#????##??. 1,2,9
??#?..??.? 1,1
???.???.??. 1,3,2
.?###????? 5,1
??##??#???# 7,2
.?###??#?#?#?#?#?? 8,1,1,1,1
???###???##?????#?. 12,2
.?#??.???###?.? 3,6
?..?#.???#???.. 1,7
???.?????#?#?###? 2,12
????????#??? 1,3,1,2
????????##...?.?? 1,3,3,1
..#??..#???? 2,4
?.??#???????#? 1,3,4
???????#??.?# 9,2
????..????##??# 3,9
????.??#??#?#??????? 2,15
?????#??#??.## 1,2,1,2
??????#.??#..?.# 1,3,1,1,1
#??????.??#?#?? 5,1,1,4
???##?????#?#?..?#? 9,1,1
?####???????#? 4,1,3
????#?#?.??##???? 8,1,5
.????#?.?.? 4,1
????##???.??#?.?. 6,3
.?#??#?????......??? 10,2
???.?#.#?##????.#?? 3,1,1,4,1,1
?.?#??.??.??#? 4,1,1,1
??##????#?? 4,4
.??.?#?#???##?? 2,4,3
??#??#?????# 7,3
?#?#?.???????#.???# 4,1,1,1,1,4
?.???????##??? 5,3,1
#?.?##?.?. 1,2,1
????????##???##????. 2,1,10
#.#?###????????? 1,13
???#??#??#???#.?.?.# 5,5,1,1,1,1
????##.?#???#?????## 5,1,4,2
#??????????#. 1,1,6,1
#?#.??????????#? 3,1,2,5
.?.?????.??.? 3,1
###???.####???#??# 4,1,4,1,1
?###????.?????.?#? 7,1,1,1,3
?#.#??#??.?.?????? 2,5,1,3,1
#??.????..?##?.? 1,4,4
.??.????#. 1,1,1
..?.#?#????#. 1,1,4,1
..#??????#?????? 2,2
?????.#???.???.#?#? 1,1,4,1,1,2
?#??.#.????.#??????? 2,1,1,2,3,3
?????.##?##???? 1,1,6,1
???????#?#######??# 3,14
#.#??#?##??##??#?? 1,12,1
.?#???.??.????#.???? 5,1,1,2,1,1
??.?#??#??? 1,5
.??????#??#????? 1,10
?#????????????? 4,9
??##?????.?#? 6,1,2
??..??#?#? 1,1,1
?.?..#????. 1,3
?.?.??????#??#?#???? 1,1,1,2,1,8
?#.?.?.???#?#.#?? 2,1,1,5,1
????#???#?#?.?? 11,1
#???????????#????# 14,2
?.??#?..#? 3,2
#?.??##?????#???###. 2,4,3,4
???.?#?.#??? 1,1,3
??#.???#??##???#?#?? 1,13
?#.?#????? 1,2,2
?.??????????#?#?? 3,6
?#?.??.???#..?????? 2,2,1,1,1,3
?#?????.???? 1,2,1,1
??#??.?.?##???? 1,7
?###???#??? 5,1,1
???#???#?.#???. 8,1
??.?#..??#?#.?. 2,2,1,1
??????????? 3,1
.????#??##?????##? 7,4
.???????##???????#? 1,7,8
????.?#????.??. 1,1,1
??#???#?.?.?.????# 7,5
???.??#??. 3,3
#??..?#.???????????? 3,2,6,2,1
???#????????? 4,1,2,1
???#???##????????.. 1,13,1
?????????? 1,3
?#?.??#???. 2,5
??.???#??### 2,4,3
.????#????#??#? 4,1,5
?.?.???##???#?#?. 1,5,6
.##??.?#??? 3,4
????????#???.? 4,4,1
?##??????.??. 4,1,1,1
##????????###?#.. 2,12
????#???????.?? 6,2,1
.??####???#..???? 10,1
?.#???#?#??#??#??.. 1,2,3,2,3
????.??#?#??????? 1,12
?#?#?????? 1,1,1
?#?.?..#?.??#.? 1,1,1,2,1
???????..?.? 1,1,2,1
?#??????#?#.????..?. 1,7,3,1
?#?????????.???? 1,6,1,1
.???#????..#? 1,1,3,1
???????????##????? 2,12,1
????????#.? 5,1,1
????#??#?.?#. 4,1,1
.??#?#???.. 2,4
.?????????#.??.?#? 4,1,1,1,1
????#???#??.?#.?#? 9,2,2
??##???????#???. 3,5,2
????.??.?. 1,2
??#???#?#???? 1,8,1
.???##?????#.?.#? 5,3,1,1
#??????##.??#?? 2,5,5
#?##?????????.. 10,1
???#?##??#???#?#??? 1,14
???#?##????? 1,1,7
#?#?#.????? 3,1,3
??????.???????? 1,4,1,2
?#????#?????#??? 8,3
.?#?#?#??#? 1,6
.??#?#.???#?????? 1,1,1,2,4
.??#?.#??????##?? 3,1,1,3
????.????.???.???.?? 3,4,1,1,2
????#??????.? 1,5,1,1
??#??#??????#?#???? 3,1,10
.#???###?#???..? 1,5,1,1
#???#???????#?# 2,2,5,1
??????????? 1,2,1
????##?#???.#????.#? 1,6,3,1,1
?##??.#??. 2,1,3
?.???##??#?#??#??.?. 10,1
???#??????#?#??????? 2,1,8,1
?#????#?#??????.?. 8,3
??.????#???# 1,1,1,2
.#?????.????..#? 6,1,1,1
.#?????##?# 2,6
?#?????????. 2,5
??#??????????#.?#??? 5,2,1,2,2,1
.??.#.###.#?. 2,1,3,2
#?????????????#???? 1,7,1,1,1
???#?#?#?#??????#??? 8,1,5
???.?????.????????? 1,1,1,1,4,3
???..?.???????#? 1,1,1,4
??#???#?.? 2,2
.?#?????#????? 1,1,4,2
..????#???#? 1,1,3
????#?##????#. 2,6,2
?##??????##?.##? 3,6,3
???.?????#?#???? 2,10
??.???????? 1,4
?.?????#?? 1,3,3
#???#???#?? 1,7
??##???##?.. 4,3
??#??????#? 2,1,1
?#.?#??#??.#??.??# 1,3,1,2,1,1
?.###?.#?.??## 1,3,2,2
????#?.?..???#? 1,1,1,2,1
?#.???#??????#??#??? 1,1,5,1,3,1
#..???##????? 1,5
.???#??#?##????###?? 12,3
.#???.?#?????#? 1,1,3,1,2
#.??????#?.??#? 1,8,3
???????.???.. 1,1,3
??????????????#? 1,3,1,3
??.?#??#?##?.?? 1,1,5,1
##?###?#???? 2,7
??????#..##??#.?# 3,5,1
.?.#???#???#??#?#. 1,7,1,1,1
.#??#???..?????# 1,5,4
?.???.??##?#??#?#? 2,10
???#?.??#???#???..? 4,9
???##?#??#???#???. 2,9,1,2
???.????.?.???##???? 3,1,7
..???????. 3,1
?????#?.?????. 6,4
.?#???#???##??.#?... 11,2
?.????##????? 5,3
.#??.??#?#??#? 1,1,4,2
??#?##????????????? 6,1,4
?.?????#?? 1,2,4
???.#.????#?#?? 1,1,6,1
??.?#??????.????? 4,2
?#??#??????#? 7,4
????????#?? 1,1,3
...??????..?#????. 5,5
???..?#??. 1,2
##..?..#.#???. 2,1,1,4
??###????.? 8,1
?..???#??.????..? 5,4,1
???#??..#?# 1,2,3
????#??#???.#.#?. 9,1,1
##?#??#???#.??? 11,1
???..????##.#..?#.?? 3,1,4,1,2,1
????.??#?? 1,3
???#?????? 5,3
?#??#??????#?.??.#?? 1,4,3,1
???##???..??? 6,1,1
??#??#?????#?? 8,2
???.#??.?# 1,1,1
?#?.??.????. 3,2,1,1
.???#??#??? 1,5
?#????###??#?.# 3,7,1
??#?#?#?.??????#? 7,1,2,2
?###??#?#?? 3,3
#?????#???.???? 1,5,1
?#??.?#???? 1,4
?#????#?..#? 6,1
????#.??#?? 4,3
#?????#?????.???.#. 2,8,1,1
.??#??????#?#??? 3,7
??##??#?.????# 1,6,2,1
????#??????##??#?? 1,1,13
.?.??????????#??..# 11,1
????#???.??? 3,1
#??#.?.?.? 1,1,1
?.#???.???????#..? 4,5,2
?#????#?..?#????#? 3,3,2,2,1
?????.#?????#???# 4,7,3
.#.????.??. 1,1,1
????.##?.?? 1,2
???????##?#?? 1,8
???.?#???#??##????. 1,2,1,1,3,1
.??????#???#?##?##?? 1,13
.??????#??###?.????? 11,2
??.???.???. 1,3,1
???##??#..##? 5,1,2
??#.##????#?##????? 1,1,3,6,1,1
??##???#?.#??##??.?? 7,6
?##??.???.??.???# 4,1,1,1,1
???.???.?#?##???#.?# 1,1,8,2
.?.??#?#?.#??. 1,5,1,1
?#???????? 3,2
?.?#?#???? 1,2
??..#???#.?.?#? 1,2,1,1,2
?.???#????...?#?? 4,3
?#?#???.????? 4,4
??#??#.???? 5,1
.?#??#.?.? 1,2,1
????????#??#???# 4,1,4,1
#?#????#?#?. 3,3
.?????.??#.?#? 5,1,1
#?.??#??#?.?.???. 1,6,1,3
?##??????# 5,1,1
.?#??#???.????#.?# 7,1,1,1
???#???????# 3,1,2,1
???#?#?????#?#.?? 7,3
???.??#??? 2,1
#????????##?????? 1,2,10
??#???.??. 6,1
?#?#.??#???? 3,4,1
???#?##???.??? 8,2
?#???.#??????? 2,2,4
?????#???. 1,4
?#???????#???#.?. 1,5,3,1
?#?.?#?#?????. 1,3,1
?.??.?#?#??##???? 1,1,10
???????????#? 1,4,1
##?????#..??#?#?#.?? 2,3,1,7,1
.#??.?#????? 2,1,3
.????#?.?.##???.? 4,5
?#.???#??#?#??#? 2,11
????????.?#?????#??? 7,3,4
?.??##????.??. 3,3,1
?#???#?#?#????? 2,8,2
???.#??.???#.?#. 3,1,2,1
.???.#.?.?. 2,1,1
?#???#???.??.. 5,1,2
?##?????#?##????#?. 9,2,1,1
?????#.?????. 2,2
.???##??#????#?#?.?# 2,13,1
??##.???.??.#.????? 4,2,1,1,1,1
#?????.?#???#??????. 3,1,1,1,3,1
???#?????.???? 4,1
###?###????#?.?#?# 9,2,2,1
????#??#????#.?? 11,1,1
??#????#?? 1,1,1
??.???#??.?????? 3,1
???#?????.#?#??..?# 7,4,2
?.##.??#?? 2,4
#.?.#?#??????.#??. 1,4,1,1,1,1
?##???#?#.?#?. 9,1
?????????????? 1,7
###?.##??#???? 4,8
??.#?#???#?#??????? 2,7,2,1,1
?????????? 1,1,2
??#??#?#??##?? 6,3
?#???#?.##?#??? 6,4,1
???????#?.???? 9,1
???##?????##?#.?.. 1,11
#????#?.????.?#????? 1,3,2,1,2,2
???.#???#????#??#?? 1,1,1,1,1,5
??#????#??#. 1,3,3,1
?#?##???#?. 1,3,1
#??#??##?#???????? 12,3
.???..??.##??? 2,1,4
?#??##?#?? 1,2,2
?????.?.#? 2,1,1
?#???????.????## 1,1,3,6
????#?#.???#?#?.?# 1,3,6,1
.??#?.??#? 2,2
?#??#?????.??? 1,4,1,1
?.????#?????#???? 1,1,1,9
??#?????.? 2,4,1
??.???#?#????.##??? 1,7,4
.?#?#????#?#???????. 4,11
.???.??.#.###????? 1,1,1,6,1
?#????????.???#????? 1,4,5
..#???.???????# 4,3,2
??????#????..#?.??. 4,2,2
????#??#???? 2,1,2
??..#??###?.?###???? 1,7,7
??#???.?????? 2,1,1
?.???.???..?. 2,2
..##???.?????.. 3,1
?.??.?.?????#???? 2,8
??.#??###?#??????#?? 1,8,1,1,1,1
?#####?#???????? 6,1,1,1
?.?.?????#?????? 1,2,3,4
?#??###?.?.? 3,4
.????##??? 1,5,1
?????#?.#?.#?#?? 4,1,1,2
.????#???#??#?#?.?# 4,7,1
????#?.???.?#? 1,1,1,3
?????.??????## 1,1,1,3
?.?##?????#????#?? 2,10
.??#????#??.?????.? 1,6,1,3
????#???.?.??#.. 2,3
??#??#??.?????????? 6,1,7,1
.#??#????????#??? 2,8,3
???????####???.#???? 1,7,1,3,1
????.?.?.#???#?? 2,1,1,2,3
??.?#?#.##??.#???.? 4,2,4
??##?????????? 2,3,3
??????##?????#??..? 3,2,2,4
????.??####?#???? 1,9
#?#????###?#??.?? 5,3,2,1
?#?#.??#??.?.#?. 3,3,1,1
?????.##?. 1,2
.????????.?#??#. 2,1,1,1,4
???#??.?#????? 1,3,1,3
????????.?#####???.? 3,8
????#???.??#??##?#? 1,2,9
.?#???#??.#? 6,2
??#????#?? 1,7
??#?..???.? 1,1
#???.??#.?#???.# 1,1,3,2,1
???..????#? 1,5
?????#????? 2,1,1
??.????#????? 2,2,1,1
????#?##?#??#?.. 8,1,3
.???????.#?..? 2,3,1,1
?????#????#??#?.??? 6,5
.????#?#?.? 1,5
?..?#???#?????.???? 1,7,2,1,1
??#???##?.?#?.???? 8,2,1
?????..??##?.?.? 1,3
#?????#?..??..?? 8,1
?.???#?#??#??????? 1,7,1,3
#??#.??#??? 4,4
???.?.??..?#??????.? 2,1,7,1
????.?#?#????##??.? 1,12
??????###?.??.??# 3,6,1,2
??.??##.???? 2,1,2,2
??#?????????###??#? 3,6,3
.#??.?#????? 3,1,1
#??????????. 1,1,4
??????.?#?? 5,2
???#?.#?.? 1,2,1
#??????#???????#?.? 1,12,2
???????#??.? 2,1,2
..?##..?.??.? 2,2
..?.??#????#?????.#? 12,2
?.#??#???.#.??# 2,1,1,1,2
?#..???#???????. 2,9
?#???#???????.#.. 1,8,1
??.??#????? 3,2
.??????#????#? 2,8
?.????.?.#?#?#?#??.. 4,7
.....??#???????## 7,3
?.##???#.#????...?? 6,1,2,1
??..?#???????.# 2,1,1,1,1
.????????.???#?????? 1,2,1,9
?.??.?#???????.#?## 1,1,3,1,1,4
#?.??????#???????#?? 2,1,3,8
.????.?.#? 3,1
.??.?.??#?##?#????.? 1,11
??#?#.?.????#??????? 3,1,1,5,2
..##????.? 2,3
????#??#???? 2,1,1,1
?????.?##? 1,1,3
???.#???.?#???# 1,2,3,1
?##.?..?#??? 2,1,2
??.?????#??#??.? 2,3,1,3,1
#?##?#??##?.???.?? 1,9,1,2
??.??????????#.?# 1,1,5,1,1
..?####??.#?#?#??#?? 4,1,8
?#?.??????##???? 1,4,3,1
?.????##.???#?? 1,2,5
???#????????#??# 2,4,1,1
????#.??#.?? 5,2,1
?.???#?#???#?.?#?#.. 1,1,1,6,4
.?????#?.#?????????# 3,2,1,9
????..?????...#?? 3,3,2
.??.?.?#??. 1,2
??.#???#?????#??#??? 1,7,1,1,1,1
??..#??#?#?##???#?#? 2,2,1,1,9
????#?????????.?.? 1,2,4,2,1
???#???.#??#???#?## 1,1,1,6,4
#??##??#??.#??????? 9,2,3
??.##?##??#??####?.? 8,5
???#?.#.#?????? 1,1,1,1,4
????????????#????? 2,3,1,2,1,2
??#.?##??#?#???? 3,5,2,2
#?.??????#????????? 2,1,2,2,3,1
??.??#?#??.?#.#. 2,2,3,2,1
.??#?????? 3,1,1
???.??.?#????#?? 1,2,2
##???????#?#.??. 4,7
????#.#?##?#????# 1,2,11
???..???#..? 1,3
???#????#?##? 2,7
#??????#??# 1,2,4
.???#?.???#?#? 1,1,1,4
??????????#?##? 1,10
..??????#.##? 1,1,1,2
?#.??#?#.??#?#?##? 1,1,1,7
.??#.?..?? 1,1
???????????#??..#?## 8,1,1,4
??#.????.? 2,1,1
????#??????.???? 8,1,1
.???#??.##? 1,1,2
#????????#?? 1,1,1,4
...#????????. 4,2,1
.??????#?#?.? 4,4
#.??#.?#?. 1,2,2
.?????#?#????#?##? 1,5,5
??..???#?????? 1,4,3
.???????.?????#...?? 6,2,1,1
???#??.???#??###?? 4,8
??.??.#??????#????? 2,10,1
?#????.##?.##???.?? 1,1,2,3,1,1
##??###??##??#?.? 12,1,1
???.?##?##???????#.? 1,7,3,1,1
.????..#.. 2,1
?#?#??#.#?#?????.?? 7,3,3,2
..??#?#????.? 6,2
?#?#??.##???.???? 2,2,5,1
###.?#???? 3,1,1
.?#?????????#.?.# 5,3,1
?.?#####?##.??????? 9,3
.????.#????#?.?. 3,7,1
??.???.????#?? 1,3,6
?????????. 1,1,3
?#.?????.??# 1,3,1,1
#?.????##??????#? 1,1,9
??#????.?##??.?? 6,4,1
.#???#.#??.#???. 5,1,1,1
..#????##???#?? 2,9
?.???.???#???#.???# 1,1,4,1,1,1
#??#?###?#?. 1,7
#.?#?.?#??#?#?? 1,1,1,4
??#?#????.?????? 5,1
.???#?????#??#? 1,3,5
##?.#?#?#? 2,3,1
.?#????.?????#? 2,1,1,4
?#??##??#.????.? 2,3,1,1,1
???#??.??# 5,2
????#?????#??? 3,1,4
.?????.?#?#?.???? 4,5,1
.??#??.??????# 2,5
???#?#??#??#?#??#?. 3,9
.?##??.?.????##???.? 4,4
?##?.#.???? 2,1,2
???.?.?????#.#?.#? 1,1,1,3,1,1
??.#?????#? 1,8
#??.#??..??? 2,1,2
#???????##????? 3,6,2
##?.????## 2,1,4
?.#.?.#??#?? 1,1,1,2
????.?.??#?..? 4,1,3,1
??.?#?#????#? 1,5,1
#?????#.???#???#?? 1,1,1,1,1,7
??#?.#??.?..??? 2,3,1,1
???#????#?##???..? 3,7
?????..?????? 4,4
?##?.????????????# 3,2,1,1,2
.????#?.#? 1,1,1
#??????.?.####????? 1,1,3,4,1,2
????.###?.? 3,4
..?.#?#???????#???? 1,10,1
???.?#.?????? 3,2,1,1
???#?#???..?.#? 8,1
.??.?????#?????#??? 1,1,10
?????????#.?#???? 2,2,2,1,1
??.???????#??????? 1,4
?.#?.??#??# 1,4
??????.??#????#?. 6,4,1
?..?.?????#. 1,1,5
?????##??#?.????..?? 7,2
?..###.??#?#???##?#? 3,11
?.#?????.?#??#?????? 1,6,7,2
??#.?.????#??#??#?# 1,1,1,8,1,1
?.??#????#??..#? 1,1,1,5,1
???#??????#?.????.?? 1,3,6,1,1,1
??#.#.#??#???#?? 2,1,9
??#?????#?? 6,2
#?#?##?#?#.#?#?????? 8,1,1,1,2
???.????#??#?#?? 1,4,6
.??????#???#??? 3,8
??.??#?#?????? 1,1,6,1
??.??#?.????.??. 1,3,1,1,1
..????#??#??. 1,8
?#?#....?# 3,1
#??#??#???? 7,2
?????????#???.??#?. 1,1,5,1,1,2
#?.??#??##?#???? 2,7,1,2
.?#.??#??#???? 1,9
???#???#?#?#?#.????? 2,1,7,1,1,2
???#???#??????#?.# 1,2,2,1,1,1
??#???.???.?????? 3,2
???#?#??????? 7,1
#??????????? 5,2,1
#???.#?#?#? 2,6
??.?.?????#? 1,6
????#????? 4,2
#.?#????##???.???? 1,9,1,1,1
.??????#??#??# 1,10
.??#?....???? 2,2
??#??#?????#????? 1,1,8,1,1
???##.??#? 3,1
?..???.##?##?###?..? 2,9
#??#??????????.?? 1,6,4
.??#???#??????????? 7,4
???#????##?#?#??.#? 1,3,5,1,1,2
#.??##??????##?#??? 1,5,6
?#??#???.??#???##. 7,1,1,3
????.??#?.? 3,2,1
????????.#.# 7,1,1
?#??###.?#??#? 6,4
?#??#?#?#??????.? 1,6,2
?????.???#?#.? 1,1,5
???##?..?#. 4,2
.???.??#???. 1,5
.#??#.?????#. 4,2,1
#????.#?.?#??????### 1,1,1,3,1,3
????????#?#?. 4,1,1,2
#.?.??.????? 1,1,1,1
#????#??.????#??? 1,3,5
?#?.??????? 1,3,1
?.?????.?#???.?? 3,5,1
???????#??...#.? 7,1
?.#?#??.???.?? 1,3,2,1
??#????????#???.? 2,8
##???#???..?????.?#? 9,2,2
?##.??????? 2,1,4
???#??#??##.?? 1,2,2,1
#??.#?.#..?.???#?? 1,1,1,1,3,1
.?#?#??#?.?#??#????# 4,3,7,2
????????#??????... 1,1,6,1,1
.????#?#?##. 2,6
???##???.????. 5,1,3
.????????????? 1,3,2,1
?#???.#?????????#. 2,1,1,2,2,1
?#??????.????? 8,1,2
.?##???????#?? 9,3
.???????#?##??#??. 2,11
???#.?????#?#?#??? 1,1,9,2
#???..??.?????.?? 3,1,2,1,1
.????.?#?????####? 4,11
????.????.?????.. 3,2,1,1
???#?#?#??#???#??#?. 1,5,9
.??##???#?#?????. 9,1
?#.???..#????#??? 2,1,1,3,1
?.?.??#????##? 1,3,3
.#.????????.?.#? 1,7,1
??????#??????? 1,5,2
?#??###???#? 1,4,2
?.....?##.? 1,2
.##.###??##?#????. 2,10,1
???.???????##?? 2,1,1,3,1
??.?????????.?#.??? 1,7,1,1,2
?####.??.##????##. 5,2,3
?.??#?????? 2,3
?????.???##?#??.? 1,5
??#?.?.???###. 3,1,3
.?##?#?.???#???#?? 5,6
?.?.#.#??#?????? 1,1,1,1,7
#?????.????#?#??? 5,6
???#.???#?#.? 3,4
#???##.##????.??? 3,2,6,1
?.??????..??????? 1,1,3,2,3
?????????## 1,1,3
????#????#.?##??#??? 5,1,2,6,1
???????##?#?.?. 1,1,6
??##?????.??? 6,1,1,1
??#?.#????????#?. 1,1,1,2,3
??.?#??#??????.? 1,4,5,1
.?.#???????##?? 3,1,3
?????#??.?.??#.??# 1,4,1,1,1,2
?..?#?????#??#?#. 1,2,1,6
..#.????#?????? 1,2,6
????..?????# 3,6
??#?????#??.? 9,1
#.??.##??.##.? 1,1,3,2
##?????.???? 3,1,1
?.?????#?#??.???#?? 1,2,5,1,1
??##?.???.??? 5,1,1
?.????#???.? 1,3,2,1
??#????.#?. 5,1,2
????..??????.?#??? 1,1,4
??#?.??#?.. 3,2
?#?.????????? 1,5
#??.?#??#?.?? 2,6,1
??.?#??????? 1,3,1,1
???#?#??#??#?????? 11,3
.###???..???#??? 3,2,6
??##????.. 3,1
#..?????????#??###?? 1,1,1,2,1,4
#.????#?##? 1,2,5
????.##???????#??. 2,2,2,4
?.?????##?. 1,4
???..?..?..???# 2,1,1,1,1
??..##??#?#??. 3,5
?..#???#?.?????#? 1,6,1,1,2
???.?.????##?#??#?#. 1,1,1,2,4,1
??..#??.?##?? 2,1,1,3
?.?.???...?.??#??? 3,4
.??#???##? 2,3
???.????#?? 1,3
??#??..?#?..? 5,2,1
???#.???.????..?## 1,1,1,4,2
?.?.#.???#??##?????. 1,1,11
#.??.#.????? 1,1,1,1
????#?#?.??. 7,2
#??????????#?.??? 4,4,1,1
??.??#?.???#?.?.? 2,3,2,1,1
.?.#??????#?. 1,3,2
????????##??.???#? 1,8,3
.????..?.???????? 1,5
????#?##???? 2,4
?##.#.???#..??#?.?# 2,1,2,1,3,2
.??#.?????..#?? 1,1,3
.?.?#??.#??? 1,1
??##????????.?.??? 9,1,1
??##..#..??? 3,1,2
.???????????? 2,2,1,1
.????#????#??#??#### 1,1,1,11
#??##?.??.???.???#?# 1,4,1,2,3,1
??#??????. 1,1
.?#?.?.???????????? 3,1,4,5
???#..#???.?# 3,3,1
???????????? 3,1,1,1
.#????.?###.?.?????? 1,2,4,3,1
????#.###?#??? 4,3,1,1
?????#?????#?..???? 1,1,2,1,3,4
?...#??##?#?.? 1,4
???????????????#??? 1,1,6,4,1
.??????#??#??????. 3,8
..???????? 1,1
#?#??#.????.?? 4,1,1,2
#.#.?????#?#??????? 1,1,1,9
.?..#?#?#????.?? 1,9,1
##?#??#??#??#.???? 11,1,1
???.???#??#.##??#?? 1,7,3,2
??..?#.??#?????#??? 2,1,4,2,1,1
?#?.???.#??? 2,1,3
????#?.?..#?.??#??? 1,2,2,5
.?????.?#?? 1,3
???.?.??##? 3,5
?#?.?????.???? 3,1,1,3
?.???#?.#??## 1,1,1,5
????.?.??? 4,1,1
????????.. 2,1
???????##?.?.??. 3,1,2,1,1
?#????#.????.#. 2,2,1,4,1
??.#??#??#???#?#?? 1,1,5,5,1
.????.?????#? 2,3
???.??#?#????.?#??#? 1,4,1,1,6
??.???#???#????.?. 1,2,1,2,1,1
???????##???##? 3,2,5
??.?#.???????. 1,7
..??...#????.?? 2,4
?#??##??.?#?? 5,3
???..#???. 2,1
?.?#?#?#?#??.???.#?# 1,9,1,1,1,1
????#??#?#??? 3,6,1
.???..????# 1,2,1
????#??..??????? 1,1,1,1,7
??????????#?# 1,2,3
.???#??????#??????? 1,12,2
??#?????#..#?? 2,1,2,3
?.?#???#?##????#. 1,1,1,6,2
??.?#??.??#.??##?? 1,4,3,2
.??#?????????#? 9,2
???????#??..#?..?. 5,2
#??.??.?#?#??#?? 1,1,2,8
?????.????#????# 2,9
??????#??.. 2,3
??????..?#??#? 1,5
????????#??##??? 1,1,1,1,3
???#???#???.?# 1,8,1
??????.?#.??.?. 1,1,1,2,1
??.###?#?????????.?? 1,5,3,2,1
.?????#???#????? 11,1
?###??##?#???#.??.? 12,1,1
????#?#???#?#???? 4,8,1
???.?#?#.?? 1,3,1
#?#??#.??.?#.????? 1,1,1,1,2,4
#?##?..#?## 5,4
????#?#..???#???##. 4,4,3
##?.?##???????? 3,2,5,1
.??#?####.## 1,4,2
???#?#??.??????? 1,3,2,1
?#?#??????.? 2,1,1,2
#?????#????#? 1,6,1
??#?????##..??.#???. 9,1,1,1
#??#?????????.?? 1,6,1,1,1
??.???????#???? 1,1,1,2,1
???#.??#??#?? 2,1,7
??????????????#??#? 3,1,2,1,1,1
???##??##???#??#?? 1,3,10
??????#??#? 1,1,5
?????.?#??.????.?. 3,4,1,1";

var smallInput =
@"???.### 1,1,3
.??..??...?##. 1,1,3
?#?#?#?#?#?#?#? 1,3,1,6
????.#...#... 4,1,1
????.######..#####. 1,6,5
?###???????? 3,2,1";

var smallest = "?#?#.?# 3,1";

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0;
var result2 = 0;

while (input.Contains(".."))
{
    input = input.Replace("..", ".");
}

var lines = input.Split(Environment.NewLine).OrderBy(x => x.Length).Select(x => x.Split(" ")).Select(x => (condition: x[0], groups: x[1].Split(",").Select(short.Parse).ToList())).ToList();
var maxGroup = lines.SelectMany(x => x.groups).Max();

var cacheWithUnknowns = new Dictionary<string, int>();
var cachePrecise = new Dictionary<string, bool>();
var cacheReduce = new Dictionary<string, (string, List<short>)>();
var cacheGroupCounts = new Dictionary<string, List<short>>();

//var xx = GetGroups("###..##.###").ToList();

bool trim = true;
foreach (var (condition, groups) in lines)
{
    Console.WriteLine(Hash(condition, groups));
    trim = true;
    var algo1 = SolveCached(condition, groups.ToList());
    result += algo1;
    //trim = false;
    //var algo2 = SolveCached(condition, groups.ToList());
    //result2 += algo2;
    //if (algo1 != algo2)
    //{

    //}
}

string Hash(string condition, List<short> groups) => condition + " " + string.Join(",", groups);

int SolveCached(string condition, List<short> groups)
{
    if (!trim)
    {
        return Solve(condition, groups);
    }
    var hash = Hash(condition, groups);
    if (!cacheWithUnknowns.ContainsKey(hash))
    {
        cacheWithUnknowns[hash] = Solve(condition, groups);
    }
    return cacheWithUnknowns[hash];
}
int Solve(string condition, List<short> groups)
{
    var count = 1;
    if (trim)
    {
        condition = condition.Trim('.');
        var result = RemoveCertainties(condition, groups).ToList();
        if (result.Count == 1)
        {
            (condition, groups) = result.Single();
        }
        else
        {
            foreach (var item in result)
            {
                count *= Solve(item.condition, item.groups);
            }
            return count;
        }
    }
    if (groups.Count == 0) { return 1; }
    var bucketCount = groups.Count + 1;
    var leftToFill = condition.Length - (groups.Sum(x => x) + groups.Count - 1);

    var buckets = new List<List<int>>() { Enumerable.Repeat(0, bucketCount).ToList() };
    for (int i = 0; i < leftToFill; i++)
    {
        var copies = new List<List<int>>();
        foreach (var item in buckets)
        {
            for (int j = 0; j < item.Count; j++)
            {
                var cpy = item.ToList();
                cpy[j]++;
                copies.Add(cpy);
            }
        }
        buckets = copies;
    }

    var possibleStrings = new HashSet<string>();

    foreach (var bucket in buckets)
    {
        var i = 0;
        var str = new StringBuilder();
        str.Append('.', bucket.ElementAtOrDefault(i));
        foreach (var item in groups)
        {
            if (i != 0)
            {
                str.Append('.');
            }
            str.Append('#', item);
            i++;
            str.Append('.', bucket.ElementAtOrDefault(i));
        }
        possibleStrings.Add(str.ToString());
    }

    possibleStrings = possibleStrings.Where(x => ValidCached(condition, x)).ToHashSet();
    return possibleStrings.Count;
}

//(string condition, List<short> groups) RemoveCertaintiesXXX(string condition, List<short> groups)
//{
//    var key = Hash(condition, groups);
//    if (!cacheReduce.ContainsKey(key))
//    {
//        var result = RemoveCertainties(condition, groups);
//        cacheReduce.Add(key, (result.condition, result.groups.ToList()));
//    }
//    return cacheReduce[key];
//}

IEnumerable<(string condition, List<short> groups)> RemoveCertainties(string condition, List<short> groups)
{
    if (!groups.Any())
    {
        yield return (condition, groups);
        yield break;
    }
    condition = condition.Trim('.');
    var cpy = condition.ToString();//.Replace("?", "#");
    var cpyGroup = groups.ToList();
    var firstGroupLength = cpy.TakeWhile(x => x == '#').Count();
    if (firstGroupLength == cpyGroup.First())
    {
        cpyGroup.RemoveAt(0);
        var startGroup = cpy.IndexOf('#');
        condition = condition[(startGroup + firstGroupLength + 1)..]; // also remove a trailing space, to make sure numbers are not right next to each other
        foreach (var item in RemoveCertainties(condition, cpyGroup))
        {
            yield return (item.condition, item.groups);
        }
        yield break;

    }

    cpy = new string(cpy.Reverse().ToArray());
    var lastGroupLength = cpy.TakeWhile(x => x == '#').Count();
    if (lastGroupLength == cpyGroup.Last())
    {
        cpyGroup.RemoveAt(cpyGroup.Count - 1);
        var startGroup = cpy.IndexOf('#');
        condition = condition[..(condition.Length - startGroup - lastGroupLength - 1)];// also remove a leading space, to make sure numbers are not right next to each other
        foreach (var item in RemoveCertainties(condition, cpyGroup))
        {
            yield return (item.condition, item.groups);
        }
        yield break;
    }

    //middle
    var groupsThatOccurOnce = cpyGroup.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToList();
    if (!groupsThatOccurOnce.Any())
    {
        yield return (condition, cpyGroup);
        yield break;
    }
    cpy = condition/*.Replace("?", "#")*/.ToString();
    var stringGroupsThatOccurOnce = GetAbsoluteGroups(cpy).GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToList();
    var match = groupsThatOccurOnce.Intersect(stringGroupsThatOccurOnce).FirstOrDefault();
    if (match != default)
    {
        var index = cpy.IndexOf($".{new string('#', match)}.");
        var left = cpyGroup.TakeWhile(x => x != match).ToList();
        var leftCondition = condition[..(index + 1)];

        var right = cpyGroup.SkipWhile(x => x != match).Skip(1).ToList();
        var rightCondition = condition[(match + index + 1)..];

        if (right.Count > 0)
        {
            yield return (rightCondition, right);
        }
        if (left.Count > 0)
        {
            yield return (leftCondition, left);
        }
        yield break;
    }


    yield return (condition, cpyGroup);
}


List<short> GetGroupsCached(string input)
{
    if (!cacheGroupCounts.ContainsKey(input))
    {
        cacheGroupCounts[input] = GetAbsoluteGroups(input);
    }
    return cacheGroupCounts[input];
}

List<short> GetAbsoluteGroups(string input)
{
    return input.Split('.', StringSplitOptions.RemoveEmptyEntries).Where(x => !x.Contains('?')).Select(x => (short)x.Count()).ToList();
}

bool ValidCached(string mask, string attempt)
{
    var key = $"{mask}|{attempt}";
    if (!cachePrecise.ContainsKey(key))
    {
        cachePrecise[key] = Valid(mask, attempt);
    }
    return cachePrecise[key];
}

bool Valid(string mask, string attempt)
{
    if (mask.Length != attempt.Length)
    {
        Debugger.Break();
    }
    if (attempt.Contains('?'))
    {
        Debugger.Break();
    }


    for (int i = 0; i < mask.Length; i++)
    {
        if (mask[i] == attempt[i] || mask[i] == '?')
        {

        }
        else
        {
            return false;
        }
    }
    return true;
}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();