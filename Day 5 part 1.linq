<Query Kind="Program" />

void Main()
{
	var input = @"53|62
43|48
43|99
62|76
62|19
62|85
58|55
58|84
58|43
58|64
98|82
98|47
98|73
98|49
98|66
99|97
99|14
99|58
99|57
99|92
99|49
73|84
73|49
73|57
73|87
73|39
73|59
73|35
92|82
92|39
92|83
92|93
92|84
92|31
92|53
92|46
87|36
87|35
87|38
87|82
87|58
87|83
87|11
87|57
87|53
86|91
86|23
86|19
86|16
86|71
86|62
86|47
86|31
86|76
86|97
83|89
83|86
83|93
83|84
83|77
83|64
83|43
83|36
83|98
83|48
83|45
91|76
91|71
91|69
91|49
91|38
91|16
91|14
91|31
91|35
91|47
91|73
91|59
84|61
84|93
84|99
84|23
84|98
84|62
84|66
84|19
84|11
84|86
84|32
84|48
84|43
47|46
47|31
47|27
47|92
47|59
47|39
47|57
47|36
47|35
47|82
47|64
47|84
47|87
47|71
34|53
34|69
34|36
34|92
34|43
34|58
34|49
34|87
34|31
34|39
34|83
34|84
34|82
34|27
34|47
89|23
89|48
89|77
89|91
89|76
89|98
89|51
89|86
89|97
89|61
89|69
89|73
89|16
89|99
89|32
89|47
71|31
71|32
71|45
71|93
71|53
71|57
71|36
71|48
71|27
71|59
71|17
71|35
71|67
71|89
71|11
71|46
71|39
23|39
23|16
23|91
23|87
23|31
23|35
23|47
23|99
23|71
23|59
23|14
23|66
23|92
23|97
23|38
23|76
23|73
23|34
45|16
45|62
45|66
45|97
45|61
45|77
45|34
45|14
45|91
45|51
45|48
45|99
45|86
45|76
45|93
45|47
45|69
45|23
45|85
51|47
51|99
51|49
51|77
51|92
51|39
51|82
51|76
51|87
51|69
51|34
51|62
51|14
51|97
51|71
51|73
51|19
51|85
51|86
51|91
59|51
59|45
59|48
59|36
59|17
59|32
59|58
59|67
59|89
59|55
59|83
59|43
59|64
59|38
59|57
59|27
59|53
59|11
59|93
59|98
59|84
66|47
66|46
66|58
66|59
66|35
66|38
66|57
66|83
66|76
66|36
66|53
66|39
66|71
66|82
66|55
66|31
66|92
66|16
66|49
66|17
66|34
66|73
14|87
14|57
14|83
14|59
14|71
14|31
14|76
14|16
14|82
14|92
14|49
14|35
14|69
14|47
14|39
14|17
14|34
14|66
14|53
14|55
14|97
14|38
14|73
69|53
69|67
69|16
69|39
69|43
69|71
69|31
69|57
69|36
69|38
69|17
69|27
69|83
69|47
69|87
69|92
69|55
69|58
69|82
69|46
69|59
69|49
69|84
69|35
76|83
76|71
76|34
76|55
76|59
76|16
76|92
76|57
76|35
76|87
76|36
76|53
76|47
76|46
76|17
76|82
76|69
76|58
76|31
76|73
76|39
76|38
76|27
76|49
46|45
46|91
46|98
46|62
46|27
46|93
46|23
46|85
46|32
46|77
46|64
46|43
46|86
46|48
46|51
46|99
46|84
46|89
46|14
46|11
46|67
46|61
46|97
46|19
31|84
31|93
31|27
31|98
31|59
31|45
31|67
31|35
31|55
31|11
31|89
31|17
31|36
31|51
31|46
31|32
31|64
31|83
31|53
31|48
31|57
31|43
31|58
31|38
48|87
48|61
48|82
48|92
48|47
48|98
48|34
48|77
48|14
48|69
48|19
48|49
48|99
48|85
48|76
48|73
48|66
48|23
48|91
48|51
48|16
48|62
48|97
48|86
77|73
77|66
77|69
77|91
77|19
77|49
77|76
77|82
77|34
77|14
77|16
77|71
77|92
77|35
77|99
77|85
77|87
77|39
77|31
77|47
77|23
77|61
77|59
77|97
61|19
61|39
61|91
61|31
61|49
61|99
61|71
61|14
61|16
61|35
61|34
61|38
61|87
61|73
61|58
61|47
61|97
61|17
61|69
61|59
61|82
61|76
61|92
61|66
32|51
32|85
32|69
32|97
32|61
32|19
32|23
32|34
32|49
32|62
32|48
32|16
32|98
32|73
32|14
32|66
32|91
32|76
32|77
32|87
32|92
32|99
32|47
32|86
82|57
82|11
82|43
82|39
82|59
82|58
82|35
82|27
82|64
82|36
82|45
82|46
82|38
82|32
82|31
82|17
82|71
82|67
82|93
82|53
82|83
82|55
82|89
82|84
16|67
16|38
16|84
16|83
16|39
16|55
16|53
16|43
16|92
16|64
16|59
16|49
16|58
16|82
16|35
16|46
16|57
16|36
16|27
16|87
16|11
16|71
16|17
16|31
19|97
19|58
19|39
19|49
19|17
19|38
19|31
19|57
19|35
19|47
19|59
19|69
19|66
19|53
19|73
19|76
19|14
19|99
19|82
19|92
19|87
19|71
19|16
19|34
49|64
49|84
49|55
49|83
49|58
49|11
49|38
49|82
49|27
49|57
49|46
49|36
49|67
49|71
49|59
49|35
49|31
49|43
49|17
49|87
49|89
49|92
49|53
49|39
11|51
11|45
11|32
11|89
11|93
11|99
11|62
11|97
11|19
11|86
11|69
11|91
11|48
11|14
11|61
11|77
11|85
11|98
11|76
11|66
11|34
11|73
11|23
11|47
97|71
97|38
97|49
97|66
97|47
97|17
97|92
97|16
97|58
97|87
97|35
97|57
97|34
97|53
97|36
97|83
97|39
97|59
97|31
97|55
97|73
97|69
97|76
97|82
36|77
36|64
36|43
36|91
36|67
36|46
36|62
36|45
36|93
36|11
36|48
36|98
36|19
36|85
36|89
36|51
36|27
36|99
36|86
36|61
36|84
36|23
36|14
36|32
64|19
64|45
64|69
64|66
64|32
64|76
64|51
64|97
64|86
64|14
64|85
64|91
64|73
64|77
64|93
64|99
64|61
64|48
64|89
64|98
64|23
64|34
64|11
64|62
67|48
67|85
67|32
67|62
67|23
67|76
67|99
67|98
67|86
67|45
67|91
67|64
67|11
67|89
67|14
67|51
67|93
67|66
67|73
67|77
67|34
67|19
67|61
67|97
27|91
27|43
27|11
27|45
27|77
27|86
27|97
27|89
27|51
27|19
27|66
27|85
27|62
27|93
27|98
27|99
27|64
27|23
27|32
27|84
27|67
27|61
27|14
27|48
17|48
17|83
17|55
17|84
17|64
17|46
17|51
17|58
17|27
17|57
17|93
17|86
17|62
17|89
17|67
17|11
17|32
17|45
17|77
17|53
17|38
17|36
17|98
17|43
35|51
35|53
35|89
35|86
35|57
35|67
35|98
35|45
35|46
35|32
35|27
35|55
35|11
35|84
35|83
35|59
35|36
35|48
35|38
35|64
35|43
35|17
35|58
35|93
57|61
57|46
57|89
57|36
57|64
57|85
57|11
57|23
57|55
57|93
57|67
57|84
57|48
57|98
57|27
57|83
57|77
57|32
57|62
57|43
57|86
57|91
57|45
57|51
93|51
93|77
93|73
93|69
93|62
93|97
93|61
93|98
93|19
93|99
93|86
93|32
93|23
93|16
93|85
93|49
93|14
93|66
93|47
93|87
93|91
93|34
93|76
93|48
85|91
85|14
85|49
85|34
85|59
85|23
85|92
85|73
85|16
85|71
85|87
85|97
85|35
85|19
85|82
85|69
85|31
85|17
85|66
85|39
85|61
85|99
85|76
85|47
38|77
38|46
38|58
38|67
38|53
38|32
38|89
38|36
38|93
38|11
38|98
38|48
38|27
38|86
38|85
38|57
38|84
38|45
38|64
38|55
38|43
38|83
38|51
38|62
39|17
39|98
39|45
39|48
39|83
39|67
39|36
39|58
39|38
39|43
39|53
39|59
39|32
39|57
39|46
39|55
39|27
39|64
39|35
39|93
39|84
39|31
39|89
39|11
55|23
55|43
55|19
55|27
55|62
55|61
55|99
55|89
55|91
55|77
55|36
55|84
55|98
55|86
55|11
55|48
55|64
55|85
55|45
55|93
55|46
55|67
55|51
55|32
53|86
53|61
53|55
53|11
53|45
53|85
53|93
53|64
53|89
53|67
53|48
53|57
53|98
53|27
53|46
53|77
53|84
53|23
53|51
53|43
53|36
53|32
53|83
43|73
43|93
43|45
43|14
43|64
43|98
43|89
43|77
43|85
43|11
43|32
43|91
43|62
43|19
43|61
43|67
43|97
43|23
43|51
43|76
43|66
43|86
62|92
62|77
62|87
62|61
62|16
62|23
62|49
62|31
62|35
62|71
62|99
62|39
62|34
62|14
62|82
62|97
62|91
62|47
62|73
62|66
62|69
58|46
58|57
58|53
58|23
58|51
58|45
58|86
58|77
58|32
58|62
58|67
58|89
58|93
58|85
58|48
58|11
58|83
58|36
58|27
58|98
98|85
98|19
98|69
98|76
98|61
98|86
98|92
98|97
98|99
98|71
98|91
98|14
98|77
98|34
98|23
98|16
98|62
98|51
98|87
99|83
99|39
99|34
99|17
99|66
99|16
99|31
99|87
99|69
99|53
99|82
99|71
99|35
99|47
99|59
99|76
99|73
99|38
73|53
73|58
73|46
73|16
73|55
73|27
73|82
73|17
73|47
73|69
73|92
73|31
73|83
73|36
73|34
73|71
73|38
92|58
92|57
92|38
92|67
92|59
92|43
92|36
92|45
92|11
92|35
92|17
92|27
92|55
92|64
92|89
92|71
87|45
87|43
87|89
87|59
87|64
87|39
87|27
87|67
87|71
87|46
87|55
87|84
87|31
87|17
87|92
86|39
86|49
86|92
86|69
86|77
86|66
86|82
86|61
86|34
86|87
86|73
86|14
86|85
86|99
83|27
83|55
83|61
83|23
83|62
83|32
83|51
83|67
83|46
83|11
83|91
83|85
83|19
91|53
91|87
91|82
91|19
91|17
91|66
91|92
91|39
91|99
91|34
91|97
91|58
84|97
84|76
84|85
84|89
84|77
84|91
84|64
84|14
84|51
84|45
84|67
47|83
47|67
47|43
47|16
47|53
47|49
47|38
47|58
47|55
47|17
34|16
34|35
34|57
34|46
34|55
34|71
34|17
34|38
34|59
89|85
89|19
89|62
89|14
89|66
89|45
89|34
89|93
71|58
71|38
71|55
71|84
71|64
71|43
71|83
23|19
23|69
23|17
23|82
23|49
23|61
45|98
45|73
45|19
45|49
45|32
51|66
51|23
51|61
51|16
59|86
59|62
59|46
66|69
66|87
14|58

71,31,35,38,58,83,43,67,11,45,32
32,99,27,62,48,64,46,98,14
53,55,27,11,45,93,32,48,98,51,86
97,76,73,34,69,47,16,49,87,92,71,39,31,35,17,38,53,57,83
59,17,58,55,46,27,84,43,67,64,45,93,32,48,98,51,86
89,91,55,62,98,93,51,45,23,85,83,86,43,32,27,64,67,36,61,46,77
46,67,93,48,51
43,67,64,11,89,32,98,51,86,77,85,23,91,99,97,66,76
83,82,27,59,57,17,92,43,35,71,39,67,31
49,87,92,82,71,31,59,17,57,83,55,46,84,43,11
59,17,58,53,57,83,55,36,84,43,67,11,89,45,93,32,48,51,86
39,31,35,59,38,58,53,57,83,55,36,46,27,84,43,67,64,11,89,45,93,32,48
38,57,83,55,67,32,48,62,77
84,43,67,64,89,45,32,48,51,86,85,61,19,99,66
55,19,98,61,23,32,91
84,43,77,48,86,62,89,53,85,57,98,64,36,93,11,58,55,83,51,27,45,46,67
97,76,73,34,16,49,87,92,71,38,58,83,55
61,32,85,27,19,23,48
19,14,97,76,73,34,69,87,82,71,39,59,38,58,53
61,91,19,14,97,66,76,73,69,47,16,49,87,92,82,71,39,31,35,17,38
69,47,92,82,71,39,31,35,59,17,38,58,53,83,36,46,84
55,98,57,67,38,51,11
31,35,59,17,58,53,83,55,36,46,27,43,67,11,89,45,93,48,98
99,92,73,49,51,91,82,97,71,47,34,76,19,61,77,66,87,86,69
14,97,66,34,16,49,92,82,39,31,35,59,17,38,58,57,83
49,35,59,38,46
59,17,38,93,43,83,89,58,86,11,64,84,32,45,57
19,35,97,85,66,77,49,92,34,91,87
48,47,19,62,97,69,91,85,66,89,76,73,45,61,23
85,23,91,19,99,14,97,66,76,73,34,69,49,92,82,39,31,35,59
73,47,49,87,92,35,17,38,53,83,27
97,14,23,47,49
86,62,85,23,91,76,47,87,71
31,84,87,34,82,35,17,55,46,83,39,58,49,27,47,59,57,16,38,53,71
14,97,73,47,39
48,98,51,86,62,77,85,61,91,99,14,97,76,34,69,47,16,87,92
83,17,16,34,53,82,92,38,76,36,73,58,57,47,71,39,87,59,49,31,55,46,69
66,19,73,92,99,34,47,97,71,87,82,35,49,16,31,53,58,76,59,39,38,14,69
61,91,99,14,76,49,87,92,31,59,38
99,82,19,73,51,16,91,76,97,71,77,86,61,62,66,34,87,23,69
76,69,16,35,17,55,46
83,55,31,93,46,38,36,58,59,89,53,27,43,64,67,84,39,11,57,32,71
34,69,47,92,71,36,46,27,84
45,86,61,43,51,84,89,67,85,64,14,93,27,97,32
38,82,31,58,59,83,14,87,39,35,57,71,16,66,17,47,73
19,84,11,91,64,55,98,61,86
45,93,32,98,51,86,77,23,61,91,99,14,76,73,69,47,16
93,32,48,98,51,62,77,85,23,61,19,99,97,66,76,73,34,16,49
46,43,89,93,32,98,86,85,23
93,48,98,51,62,77,85,91,19,99,97,76,34,69,49
17,38,53,39,59,83,71,34,84,92,35,58,87,36,31,27,47,16,46
62,77,85,69,47
83,86,77,93,67,11,32,64,27,84,36,98,62,23,46,55,45,43,91
55,27,84,64,11,89,45,93,32,98,51,86,62,85,19
84,48,27,64,23,45,51,89,85,86,32,43,98,11,93,67,19,62,99,91,36,77,61
53,57,83,55,46,84,43,67,11,89,93,32,48,98,51,86,62,85,23
47,84,59,82,39,46,16,43,27,69,17,71,38,57,92
82,17,53,57,83,46,84,43,93
47,16,49,87,92,82,39,35,17,38,53,83,55,36,27,43,67
16,49,71,59,38,43,64
55,53,71,38,59,66,83,57,34,16,87,76,82,49,97
45,93,48,98,51,86,62,77,23,61,19,97,66,76,73,34,69,47,16
39,31,35,17,38,58,53,57,55,36,46,43,67,11,93,32,48
87,82,71,39,58,53,57,83,55,36,27,84,67,11,89
38,58,83,36,27,84,43,67,48
32,85,58,51,11,84,48,83,36,64,43,27,46,62,98
16,49,87,92,82,39,35,17,38,58,53,57,83,55,36,46,27,43,64
46,53,57,58,43,83,48,89,77,55,62,64,84
83,58,17,35,36,55,69,71,84,38,43,82,16
11,86,77,23,19
67,64,11,45,93,32,48,51,86,62,77,85,23,61,99,14,66,76,73
58,34,59,76,39,69,19,91,17
39,19,61,47,92,87,76,82,59,23,97,69,35,71,17
55,46,48,89,85,27,11,45,58,57,53
38,58,53,57,83,55,36,46,84,43,67,64,11,89,45,32,48,51,86,62,77
61,19,14,97,76,73,34,69,47,49,87,92,82,71,39,31,59,17,38
97,23,51,99,64,93,76,85,66,77,86,98,45,91,73,48,32,19,67
92,82,71,39,31,35,59,38,53,57,83,55,36,46,27,84,67,64,11,89,45
36,46,27,84,43,67,64,11,89,45,93,32,48,98,51,86,77,85,23,61,91,19,99
76,73,34,69,47,16,49,92,82,71,39,31,35,59,58,53,83,36,46
39,66,53,92,76,82,87,59,38,69,47,31,16,71,19,17,14,49,35,73,99,97,58
11,45,93,48,86,61,91,19,99,14,66,34,69
36,46,84,67,64,11,89,45,32,48,98,51,86,62,85,19,99
98,86,85,19,99,73,34,47,16,49,92
93,32,98,85,19,14,73,47,16
19,99,97,76,69,82,17
17,38,59,92,27,71,36,46,82,84,87,31,39
38,53,27,64,45,93,98
87,84,16,46,35,36,67,57,17,38,71,49,92,31,59,82,55
61,66,76,34,16,39,31,59,38
77,61,91,76,73,34,47,92,82,71,39,31,35
83,55,36,46,27,43,67,64,11,45,93,32,48,98,86,62,77,85,23,61,91
62,23,61,91,19,14,66,16,82,71,31
64,11,89,93,51,86,77,61,19,76,34
32,99,86,62,14
76,66,91,16,49,87,35,58,99,38,92
53,32,27,86,57,45,55,93,11,77,51,48,85,43,36,84,98,64,83,46,67,23,89
71,39,31,35,59,17,38,58,53,57,83,55,46,27,84,43,67,64,11,89,45,93,32
57,55,27,84,64,23,61
99,69,91,71,61,49,97,16,39,73,86,82,62
32,64,43,89,38,58,93,71,11,67,36,27,31,17,39
64,82,49,87,27,38,16
16,49,82,39,59,58,83,55,46,27,84,67,64
17,53,57,84,11,89,32,51,62
39,34,99,87,85,69,61,31,16,49,62,92,71
31,35,59,17,38,58,53,57,83,36,46,27,84,43,67,64,11,89,45,93,32,48,98
16,49,87,92,82,71,39,31,35,59,17,38,58,53,57,83,36,46,27,84,43,67,64
14,97,66,76,73,34,47,49,87,92,39,31,35,59,38,58,53,57,83
89,93,98,86,77,61,91,19,14,97,66,76,34,69,47
84,43,67,64,11,89,32,48,98,51,62,77,85,23,61,91,19,99,14,97,66
85,23,19,97,73,34,69,49,87,92,31,35,59
11,89,93,32,48,23,61,91,19,66,76,73,69
55,27,43,64,11,89,93,32,48,98,62,23,61
51,47,69,45,23,91,77,14,89,66,76,85,99
11,89,93,32,86,23,61,91,19,99,14,97,66,34,69
14,97,66,73,34,69,47,16,49,87,92,82,71,39,31,35,59,17,38,58,57
17,38,58,53,83,55,46,27,84,43,11,93,48,86,62
48,91,77,67,83,32,55,46,61,27,36,45,98,86,89,62,11,43,64
84,43,67,93,48,99,14
66,47,77,49,51,23,99,61,93,19,14,48,62
19,14,97,66,34,69,16,49,87,92,82,71,39,31,35,59,17,58,53
14,69,35,38,61,66,34,91,59,87,47,31,17,82,76,92,97
49,48,62,73,92,69,34
86,77,85,23,61,91,19,14,97,76,73,82,39
91,99,14,66,76,73,34,69,47,16,49,87,92,82,39,31,35,59,17,38,58
45,93,32,48,98,51,86,62,23,99,14,97,66,76,73,34,69,47,16
57,55,87,34,46,39,47,49,69,83,16,31,38,35,92,58,36
43,67,89,93,98,77,85,19,99
32,98,86,23,99,97,66,73,69,49,87
66,76,73,69,47,92,39,35,38,53,57,83,36
46,85,77,64,61,48,98,32,43,45,55,67,51,36,86
23,91,19,14,97,66,73,34,69,47,16,49,87,92,82,71,39,31,35,59,17
58,53,36,46,86
84,49,82,47,16,83,55,27,39,17,69,46,58,38,43,53,59
62,85,61,91,19,99,14,76,34,47,16,92,71
27,84,11,89,93,32,77,91,19
11,82,57,87,64,35,27,92,55,53,89,17,43,71,58,38,83
67,64,11,89,93,32,48,98,51,62,77,85,23,61,19,99,14,97,66,76,73
67,64,11,89,45,93,48,98,51,62,77,85,23,61,91,19,99,14,97,66,76
36,27,84,43,67,11,89,93,32,48,51,77,85,61,91,19,99
39,17,58,53,57,83,55,36,67,93,48
89,45,93,32,48,98,86,62,77,85,23,61,91,19,99,14,97,66,76,73,34,69,47
98,73,91,77,93,32,49
89,93,83,45,36,58,55,46,17
17,38,58,53,57,83,55,36,46,27,84,43,67,11,89,45,93,32,48,98,51,86,62
92,62,14,97,86,51,23,71,76,77,69
89,14,91,86,98,99,93,67,97,43,19,61,76,51,23,32,66
39,31,35,38,58,53,46,27,84,67,64,11,89,45,93,32,48
77,69,97,23,61,51,49,34,91,62,92,16,19,14,98,87,99,76,47,66,86,82,73
84,38,27,17,82,83,49,36,67,71,31,55,46,59,35,53,39
35,59,83,46,84,67,64,11,89,45,32,48,51
69,49,87,92,82,71,39,31,35,59,17,38,58,53,83,55,36,46,27,84,43
17,38,57,87,46,83,67,31,36,53,84,11,27,92,35,59,43,89,55,39,58,82,71
98,62,85,61,97,66,82
17,38,58,46,27,84,64,45,98
23,61,91,99,14,97,66,76,73,34,47,49,87,92,82,71,39,31,35,59,17
64,46,43,53,11,35,98,67,84,32,48,17,27,38,83,59,51,45,57,36,55,58,89
73,76,16,48,49,66,34,86,14,93,91,32,47
58,59,55,82,46,35,93
84,43,67,64,11,89,45,93,32,48,98,51,86,62,85,23,91,19,14
45,93,98,51,86,62,23,61,91,19,99,66,73,34,69,47,16
76,53,39,49,82,31,99,66,73,16,14,58,17,57,97,71,47
89,32,86,77,23,91,19,97,66,76,34
89,45,77,19,99,76,47
76,73,34,47,16,49,87,92,82,71,39,35,17,38,58,53,57,83,55,36,46
61,91,19,99,14,97,66,76,73,34,47,49,87,92,82,71,39,31,35,59,38
36,84,38,67,17,46,11,45,32,93,98,27,59,31,48,89,58,43,83
36,84,43,64,11,89,93,32,98,51,86,62,85,23,61,91,99
89,47,51,86,93,99,48
97,86,98,87,66,34,69,14,48,19,99,23,51,91,92
16,49,87,92,82,71,39,31,35,17,38,58,53,57,83,55,36,46,27,84,43,67,64
59,38,58,53,57,83,55,36,27,84,43,67,64,89,45,93,32,48,98,51,86
53,45,58,36,46,11,59,83,32,43,57,64,38,84,93
92,82,71,39,31,35,17,53,83,55,46,27,84,67,45
85,23,61,91,19,14,97,66,76,73,34,69,16,49,87,82,31,35,59
38,58,36,43,11,93,48
47,49,34,66,14,31,97,62,99
35,17,27,55,49,92,31,87,59,58,47,71,36,84,16,46,34,82,38
11,66,85,14,45,64,98,99,62,91,67,86,48,89,76,97,73,32,77,93,51,61,19
73,71,31,59,57
67,64,11,89,45,32,48,62,91,19,14,97,73
27,67,89,93,48,61,91,99,97
61,97,91,92,35,69,16,47,87,19,66,14,77,71,23,31,34,49,73,99,76,85,82
48,11,53,89,38,35,64,57,39,36,17,45,67
92,87,69,39,99,16,35,58,38,14,71
14,76,34,47,49,82,71,39,31,35,38,53,83
46,49,64,39,38,11,53,55,17,31,59
89,11,27,62,45,67,91,77,99,46,14,86,51
51,87,62,23,49,76,66,77,19,98,14,16,73,61,85,34,91,99,32
49,87,92,82,31,35,59,17,38,57,83,55,27,84,43,67,11
99,91,89,86,76,97,32,19,73,85,64,11,23,98,66,34,77,14,61,51,48,45,62
34,49,69,39,16,23,66,97,77,86,73,87,14,85,62,92,71,47,82
66,76,73,69,47,59,36
27,11,89,32,48,86,77,85,23,19,97
45,93,48,98,51,86,62,77,85,23,61,91,19,99,14,97,66,76,73,34,69,47,16
83,71,39,35,55,59,64,67,93,84,11,45,53,27,58,46,38,36,32,17,43
55,36,27,84,67,64,11,45,93,48,98,51,86,77,23,61,91
14,62,49,97,19
82,83,27,64,84,11,67,93,17,43,31
23,34,86,76,69,61,97
31,17,83,55,36,46,27,67,64,93,32
46,45,48,32,86,67,55,51,59";

	var pageRulesDict = new Dictionary<int, HashSet<int>>();
	var pageUpdates = new List<List<int>>();
	//Parse input
	var rows = input.Split(Environment.NewLine);

	var ruleStrs = new List<string>();
	var updateStrs = new List<string>();
	var currStrList = ruleStrs;
	foreach(var row in rows)
	{
		if(row.Trim().Length == 0)
		{
			currStrList = updateStrs;
			continue;
		}
		
		currStrList.Add(row);
	}
	
	foreach(var rule in ruleStrs)
	{
		var pages = rule.Split('|');
		var page = int.Parse(pages[0]);
		var dependentPage = int.Parse(pages[1]);
		if (!pageRulesDict.ContainsKey(page))
		{
			pageRulesDict.Add(page, new HashSet<int>());
		}
		
		pageRulesDict[page].Add(dependentPage);
	}
	
	foreach(var update in updateStrs)
	{
		var pages = update.Split(',');
		pageUpdates.Add(pages.Select(x => int.Parse(x)).ToList());
	}
	//Finish parse input
	
	var sum = 0;
	foreach(var updateSequence in pageUpdates)
	{
		if (IsCorrectlyOrdered(updateSequence, pageRulesDict))
		{
			sum += updateSequence.ElementAt(updateSequence.Count/2);
		}
	}
	
	Console.Out.WriteLine(sum);
}

private bool IsCorrectlyOrdered(List<int> pageUpdates, Dictionary<int, HashSet<int>> rulesDict)
{
	var scannedPages = new HashSet<int>();
	foreach(var page in pageUpdates)
	{
		var pageRules = new HashSet<int>();
		if (rulesDict.ContainsKey(page))
		{
			pageRules = rulesDict[page];
		}
		
		if (MatchAny(pageRules, scannedPages))
		{
			return false;
		}
		
		scannedPages.Add(page);
	}
	
	return true;
}

private bool MatchAny(HashSet<int> pagesA, HashSet<int> pagesB)
{
	foreach(var page in pagesA)
	{
		if (pagesB.Contains(page))
		{
			return true;
		}
	}
	
	return false;
}