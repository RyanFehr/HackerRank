/*
         Problem: https://www.hackerrank.com/challenges/making-anagrams/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Create a frequency of english alphabets appearing in both input strings.
         - subtract the difference of frequency of same alphabet in two input strings. e.g. if 'a' appears 2 times in first string
            and 4 times in second string then the difference is 2.
         - Sumup the differences of all the alphabets obtained in above step.
         - Print the sum.

         Gotchas:
          <None>

         Time Complexity:  O(n) //length of bigger string out of the two input strings.
         Space Complexity: O(m + n) //both input strings need to be stored in memory for processing.
*/
using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var inputText1 = Console.ReadLine();
        var inputText2 = Console.ReadLine();
        var letterMap = new Dictionary<char, int>();
        var maxLength = inputText1.Length > inputText2.Length ? inputText1.Length : inputText2.Length;

        for (var j = 0; j < maxLength; j++)
        {
            if (j < inputText1.Length)
            {
                if (letterMap.ContainsKey(inputText1[j]))
                    letterMap[inputText1[j]]++;
                else
                    letterMap.Add(inputText1[j], 1);
            }

            if (j < inputText2.Length)
            {
                if (letterMap.ContainsKey(inputText2[j]))
                    letterMap[inputText2[j]]--;
                else
                    letterMap.Add(inputText2[j], -1);
            }
        }

        var totalDiffs = 0;
        foreach (var item in letterMap)
            totalDiffs += Math.Abs(item.Value);

        Console.WriteLine(totalDiffs);
    }
}