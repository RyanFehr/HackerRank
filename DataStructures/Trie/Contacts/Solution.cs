/*
         Problem: https://www.hackerrank.com/challenges/contacts/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         -  First of all, I tried it with conventional brute force way using Trie data structure but it didn't work out. Most of 
            the test cases result in time-out.
         - Brute-force algorithm: First create a simple Trie structure and keep adding words into it. Then, when you've to search 
            the count of a given string prefix. For that first check whether the prefix exists in the Trie or not. Once the prefix
            is found then start a scan from the last node where the last character of the prefix fragment was found e.g. if prefix
            fragment is "hac" then start from the node containing 'c' letter. From there on count the number of nodes who have 
            endOfWord marker set to true. This scanning has to continue untill all leaf nodes are met.
         - Currently implemented algorithm:
            => Take the input string of length L. Find all the prefix substrings of the input starting from length 1 to L. e.g.
                for string hack we will have 'h','ha','hac','hack'
            => Add each substring into a hashmap. Set the value field of each hashmap entry to 1.
            => While adding a substring if it already exists in the hashmap then increment its count by 1.
            => For finding the count of words having the prefix fragment, make a scan in the hashmap for it and print its count.
            => if prefix fragment is not present in hashmap then print 0.

         Gotchas:
          <None>

         Time Complexity: Add operation -  O(L), find operation - O(1). L is length of string.
         Space Complexity: Add operation -  O(L), find operation - O(1) //We create a hashmap containing L substrings of any input string.
         
         Note: n, the number of queries has no relevance in deciding time or space complexity of this problem. The problem is
                more centered around add and search operations.
        */
using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var substringMap = new Dictionary<string, int>();
        var operationCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < operationCount; i++)
        {
            var operation = Console.ReadLine();
            var splits = operation.Split(' ');
            var operationType = splits[0];
            var word = splits[1];
            if (operationType == "add")
            {
                for (var j = 1; j <= word.Length; j++)
                {
                    var subString = word.Substring(0, j);
                    if (substringMap.ContainsKey(subString))
                        substringMap[subString]++;
                    else
                        substringMap.Add(subString, 1);
                }
            }
            else
            {
                if (substringMap.ContainsKey(word))
                    Console.WriteLine(substringMap[word]);
                else
                    Console.WriteLine(0);
            }
        }
    }
}