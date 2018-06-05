/*
        Problem: https://www.hackerrank.com/challenges/anagram/problem
        C# Language Version: 6.0
        .NET Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts (Key points in algorithm) :
        - The basic idea is to get the count of difference chars among two splitted strings.
          e.g. for two splitted strings "abc" & "dca" the difference count is 1. Why? because 'a' and 'c' are present in both so, we'll need to toggle just one mismatching character
          to make it an anagram pair.
        - Next thing is how do you keep a track of differences. For that I kept map of all the alphabet characters and their occurence of count. 
           For any alphabet when it occurs in part 1 of string, I increment the count and for part 2 I decrement the count. In the end just add all the differences and divide it
           by two to get the answer.

        Gotchas:
           <None>

        Time Complexity:  O(n)
        Space Complexity: O(n) //we need to store the entire string input to split it into two parts and then process both parts separately.

*/

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var testcaseCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < testcaseCount; i++)
        {
            var inputText = Console.ReadLine();
            if (inputText.Length % 2 != 0)
                Console.WriteLine("-1");
            else
            {
                var firstPart = inputText.Substring(0, inputText.Length / 2);
                var secondPart = inputText.Substring(firstPart.Length, inputText.Length / 2);

                var letterMap = new Dictionary<char, int>();

                for (var j = 0; j < firstPart.Length; j++)
                {
                    if (letterMap.ContainsKey(firstPart[j]))
                        letterMap[firstPart[j]]++;
                    else
                        letterMap.Add(firstPart[j], 1);

                    if (letterMap.ContainsKey(secondPart[j]))
                        letterMap[secondPart[j]]--;
                    else
                        letterMap.Add(secondPart[j], -1);
                }

                var totalDiffs = 0;
                foreach (var item in letterMap)
                    totalDiffs += Math.Abs(item.Value);

                Console.WriteLine(totalDiffs / 2);
            }
        }
    }
}