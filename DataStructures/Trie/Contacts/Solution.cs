/*
         Problem: https://www.hackerrank.com/challenges/contacts/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Create the conventional Trie structure . 
         - Add every word into the Trie with letters of the word being a node.
         - Addtionally for this problem , we also have to maintain a count at each node. Everytime a character node is getting
           added or repeated then increment its count by 1. e.g.
            => add 'hack'. Then four nodes will get added with count set to 1 at each node.
            => now, add 'hacker'. Then for first four nodes 'hack', the same existing nodes will be used with their counts bumped
                to 2. Two new nodes for 'er' will be added with count set to 1.
         - During find operation, just find the word in the Trie and print the count in the node of the last character.
            

        Gotchas/Caveats:
          - This is a conventional Trie structure but given the demand of the question it will work even if we don't have
            endOfWord marker flag in a Trie node.
          - Initially I had taken a Trie node as a struct. It gets messed up later when you've to increment the count
            on any Trie node. The concept to know is that structs are immutable in C#. Then I had to convert struct 
            into class and then everything worked like a charm.

         Time Complexity: Add operation -  O(L), find operation - O(L). L is length of string.
         Space Complexity: Add operation -  O(L), find operation - O(1) //We need to create a new Trie Node for each letter in the input string during Add operation.
         
         Note: n, the number of queries has no relevance in deciding time or space complexity of this problem. The problem is
                more centered around add and search operations in a Trie structure.
        */

using System;

class Solution {
    static void Main(string[] args) {
        var operationCount = int.Parse(Console.ReadLine());
            var root = new TrieNode(char.MinValue, 0);
            for (var i = 0; i < operationCount; i++)
            {
                var operation = Console.ReadLine();
                var splits = operation.Split(' ');
                var operationType = splits[0];
                var word = splits[1];
                if (operationType == "add")
                    AddTrieNode(root, word);
                else
                {
                    var count = GetWordCountFromTrie(root, word);
                    Console.WriteLine(count);
                }
            }
    }
    
    private static void AddTrieNode(TrieNode root, string word)
    {
            var currentPointer = root;
            //insert word into Trie
            for (int i = 0; i < word.Length; i++)
            {
                if (currentPointer.Children[word[i] - 97] != null)
                {
                    currentPointer = currentPointer.Children[word[i] - 97];
                    currentPointer.Count++;
                }
                else
                {
                    TrieNode newNode;
                    if (i == word.Length - 1)
                        newNode = new TrieNode(word[i],1);
                    else
                        newNode = new TrieNode(word[i],1);

                    //make the new node a child of currentPointer
                    currentPointer.Children[word[i] - 97] = newNode;

                    //set currentPointer to new node.
                    currentPointer = newNode;
                }
            }
        }
    
    private static int GetWordCountFromTrie(TrieNode trieRoot, string word)
    {
            var wordCount = 0;
            var i = 0;
            var lastNode = trieRoot;
            for (; i < word.Length; i++)
            {
                if (lastNode.Children[word[i] - 97] != null)
                {
                    lastNode = lastNode.Children[word[i] - 97];
                    continue;
                }
                else
                    break;
            }

            if (i == word.Length)
                //I've the track of last node where the desired word fragment was found.
                wordCount = lastNode.Count;
            else
                wordCount = 0;

            return wordCount;
        }
    
    
}

public class TrieNode
{
        public char NodeChar { get; }
        public int  Count { get; set; }
        public TrieNode[] Children { get; }

        public TrieNode(char nodeChar,int count)
        {
            Count = count;
            NodeChar = nodeChar;
            Children = new TrieNode[26];
        }
}