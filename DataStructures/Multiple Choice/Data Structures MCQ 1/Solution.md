## Data Structures MCQ 1

If we have a tree of n nodes, how many edges will it have?

[&nbsp;&nbsp;]&nbsp;&nbsp; 1 &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                       [&nbsp;&nbsp;]&nbsp;&nbsp;  (n*(n-1))/2

[&nbsp;&nbsp;]&nbsp;&nbsp;(n*(n-1))&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;[X]&nbsp;&nbsp;  n-1

**Explanation**: Correct answer is **n-1**. 

An undirected tree with n nodes must have exactly n−1 edges. You can prove this by induction on n. Clearly a tree with one node has no edges. Suppose that every tree with n nodes has n−1 edges, and let T be a tree with n+1 nodes. T must have a leaf, i.e., a node v such that deg v=1. (If not, T would contain a circuit: why?) Remove v and the one edge incident at v. What’s left is still a tree (why?), and it has only n vertices, so it has n−1 edges. Thus, T must have had (n−1)+1 = n edges.


Citation: [Math Exchange](https://math.stackexchange.com/a/454646/368759)
