/*
     Problem: https://www.hackerrank.com/challenges/swap-nodes-algo/problem
     C# Language Version: 7.0
     .Net Framework Version: 4.7
     Tool Version : Visual Studio Community 2017
     Thoughts :
     1. Build the tree with n nodes. Each node should maintain the level at which it lies. Let the root node numbered 1 is called r.
     2. Let the number of swap operations be t.
     3. Run the loop to take t inputs:
        3.1 Let the next input number be k.
        3.2 Perform level order traversal of tree starting from r.
        3.3 For each node encountered during level order traversal, if its level is a multiple of k then swap its child nodes.
        3.4 Now perform in-order traversal starting from r and print all number of all the nodes.
        3.5 Repeat steps from 3.1 to 3.4 for each input number obtained in the loop.

     Time Complexity:  O(n) //there is only one for loop.
     Space Complexity: O(n) 
                        //In-order traversal requires n stack frames as it involves recursion.
                        //swapping involves level order traversal which again requires O(n) space for queue.
*/

using System;
using System.Collections.Generic;

class Solution
{

    static string[] nodeData;

    static void Main(String[] args)
    {
        //numberOfNodes
        var n = int.Parse(Console.ReadLine());
        var root = new TreeNode { Data = 1, LeftChild = null, RightChild = null, Depth = 1 };

        nodeData = new string[n];
        for (var i = 0; i < n; i++)
            nodeData[i] = Console.ReadLine();

        BuildTree(root);

        var t = int.Parse(Console.ReadLine());


        for (int i = 0; i < t; i++)
        {
            var k = int.Parse(Console.ReadLine());
            //for k perform swap operations at level k, 2k, 3k...
            PerformSwapDuringLevelOrderTraversal(root, k);

            //after all above swappings 
            PrintInOrderTraversal(root);
            Console.WriteLine();
        }
    }

    private static void PerformSwapDuringLevelOrderTraversal(TreeNode node, int k)
    {
        //use a queue here for level order traversal for swapping children of all the designated nodes at a given level.
        var nextLevelNodes = new Queue<TreeNode>();

        if (node.Depth % k == 0)
            SwapChildNodes(node); //depth of current node is a multiple of k so swapping is needed

        EnqueueChildrenToQueue(nextLevelNodes, node);

        while (nextLevelNodes.Count > 0)
        {
            var nextNode = nextLevelNodes.Dequeue();
            if (nextNode.Depth % k == 0)
                SwapChildNodes(nextNode);

            EnqueueChildrenToQueue(nextLevelNodes, nextNode);
        }

    }

    private static void EnqueueChildrenToQueue(Queue<TreeNode> nextLevelNodes, TreeNode node)
    {
        if (node.LeftChild != null)
            nextLevelNodes.Enqueue(node.LeftChild);

        if (node.RightChild != null)
            nextLevelNodes.Enqueue(node.RightChild);
    }

    private static void SwapChildNodes(TreeNode node)
    {
        var temp = node.LeftChild;
        node.LeftChild = node.RightChild;
        node.RightChild = temp;
    }

    private static void PrintInOrderTraversal(TreeNode root)
    {
        if (root.LeftChild != null)
            PrintInOrderTraversal(root.LeftChild);

        Console.Write(root.Data + " ");

        if (root.RightChild != null)
            PrintInOrderTraversal(root.RightChild);
    }

    private static void BuildTree(TreeNode node)
    {
        var childData = nodeData[node.Data - 1];
        var splitted = childData.Split(' ');
        var leftChildData = int.Parse(splitted[0]);
        var rightChildData = int.Parse(splitted[1]);

        if (leftChildData == -1)
            node.LeftChild = null;
        else
        {
            var leftNode = new TreeNode { Data = leftChildData, Depth = node.Depth + 1 };
            node.LeftChild = leftNode;
            BuildTree(leftNode);
        }

        if (rightChildData == -1)
            node.RightChild = null;
        else
        {
            var rightNode = new TreeNode { Data = rightChildData, Depth = node.Depth + 1 };
            node.RightChild = rightNode;
            BuildTree(rightNode);
        }

    }
}

class TreeNode
{
    public int Data { get; set; }
    public TreeNode LeftChild { get; set; }
    public TreeNode RightChild { get; set; }
    public int Depth { get; set; }
}