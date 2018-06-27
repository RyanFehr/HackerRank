/*
         Problem: https://www.hackerrank.com/challenges/dynamic-array/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
         - Straight-forward question. Just follow the instructions in the problem statement to reach to solution.
         - No optimization possible as such.

        Gotchas:
        <None>
       

         Time Complexity:  O(q) //where q is number of queries.
         Space Complexity: O(n) //Space wise there are two things which are taking up space:
                                    1. seqList which is keeping pointer to n sequences. It contributes O(n) space.
                                    2. Sequences will also take up space of order O(n) in worst case if all q queries are
                                        of type 1.
                                 //So, at very raw level the space complexity is O(2n) ~ O(n)    
*/

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        List<int> seq;
        var userInput = Console.ReadLine();
        var userInputSplits = userInput.Split(' ');
        var numberOfSequences = int.Parse(userInputSplits[0]);
        var numberOfQueries = int.Parse(userInputSplits[1]);
        var seqList = new List<List<int>>(new List<int>[numberOfSequences]);
        var lastAns = 0;
        for (var i = 0; i < numberOfQueries; i++)
        {
            userInput = Console.ReadLine();
            userInputSplits = userInput.Split(' ');
            var queryType = int.Parse(userInputSplits[0]);
            var x = int.Parse(userInputSplits[1]);
            var y = int.Parse(userInputSplits[2]);
            var seqIndex = (x ^ lastAns) % numberOfSequences;
            switch (queryType)
            {
                case 1:
                    if (seqList[seqIndex] != null)
                        seqList[seqIndex].Add(y);
                    else
                    {
                        seq = new List<int>();
                        seq.Add(y);
                        seqList[seqIndex] = seq;
                    }
                    break;
                case 2:
                    seq = seqList[seqIndex];
                    lastAns = seq[y % seq.Count];
                    Console.WriteLine(lastAns);
                    break;
            }
        }
    }
}