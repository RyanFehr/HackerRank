/*
         Problem: https://www.hackerrank.com/challenges/two-characters/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         - Get all unique characters present in the input string and their all possible combinations. e.g. for input string abdcab we need to find ab,ac,ad,bc,bd,cd combinations.
         - Now for each character pair found above iterate the entire string once and check if alternating pattern is possible or not.
            e.g. Let's say input string is "abdcab" and character pair is 'a','b'.
                Iteration need to be done carefully
                    - Track the alternating pattern by keeping a track about the last character. If 'a' had come last time then next time you should encounter b.
                    - Ignore any other character which is not part of pair being tracked e.g. d and c in the input string during the iteration.
                    - Track the pattern length every time you encounter any character from  the pair being tracked.
         - Print the longest altenating pattern length found.

         Time Complexity:  O(n)
         Space Complexity: O(n) //input string need to be stored in memory for repeatitive iteration to check character pair pattern
         
*/

using System.Collections.Generic;
using System;

class Solution
{
    static void Main(string[] args)
    {
        //No need to capture the size of string. We will use string's length property instead.
        Console.ReadLine();
        var inputString = Console.ReadLine();

        //first obtain all the possible combination of possible characters in the string
        //e.g. for input string abdcab we need to find ab,ac,ad,bc,bd,cd combinations
        var characterSet = new HashSet<char>();
        var combinationList = new List<Tuple<char, char>>();
        //This loop runs fixed 25! times in worst case when the string is abcdefghijkl.....xyz. 
        //So it'll contribute O(1) for time efficiency of the algo.
        for (var i = 0; i < inputString.Length; i++)
        {
            if (!characterSet.Contains(inputString[i]))
            {
                //create all tuple combinations
                foreach (var character in characterSet)
                    combinationList.Add(new Tuple<char, char>(inputString[i], character));
            }

            characterSet.Add(inputString[i]);
        }

        var maxPatternLength = 0;
        //In worst case we iterate the input string (of length n) n * 25! times in worst case
        //So overall efficiency will remain of order n.
        foreach (var alternatingCharPair in combinationList)
        {
            //process the entire input string once for each combination if it gives max length of alternating characters
            var nextExpectedChar = alternatingCharPair.Item2;
            var currentPatternLength = 1;
            var i = 0;
            while (inputString[i] != alternatingCharPair.Item1 && inputString[i] != alternatingCharPair.Item2)
                i++;

            if (inputString[i] == alternatingCharPair.Item2)
                nextExpectedChar = alternatingCharPair.Item1;

            i++;
            for (; i < inputString.Length; i++)
            {
                if (inputString[i] != alternatingCharPair.Item1 && inputString[i] != alternatingCharPair.Item2)
                    continue;

                if (inputString[i] == nextExpectedChar)
                {
                    currentPatternLength++;
                    nextExpectedChar = inputString[i] == alternatingCharPair.Item1 ? alternatingCharPair.Item2 : alternatingCharPair.Item1;
                }
                else
                    break;
            }

            if (i == inputString.Length && currentPatternLength > maxPatternLength)
                //it has valid alternating pattern
                maxPatternLength = currentPatternLength;

        }
        Console.WriteLine(maxPatternLength);
    }
}
