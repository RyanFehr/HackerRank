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

         Time Complexity:  O(n) // actually it is O(m+n) i.e. the lengh of sum of two strings. But even in worst case
                                    if both strings are of length n = 10^4 then it will be O(2n) ~ O(n)
         Space Complexity: O(1) //No additional space required.
*/
using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var nextChar = Console.Read();
            var letterMap = new Dictionary<int, int>();

            //special handling for hackerrank execution environment.
            //on my pc I compare it with 13 which is ascii code of carriage return '\r'
            //10 is ascii code of '\n'
            while (nextChar != 10)
            {
                if (letterMap.ContainsKey(nextChar))
                    letterMap[nextChar]++;
                else
                    letterMap.Add(nextChar, 1);
                nextChar = Console.Read();
            }

            nextChar = Console.Read();
            //special handling for hackerrank execution environment.
            //on my pc I compare it with 13 which is ascii code of carriage return '\r'
            //Hacker rank treats -1 as end of file which marks the end of second string.
            while (nextChar != -1)
            {
                if (letterMap.ContainsKey(nextChar))
                    letterMap[nextChar]--;
                else
                    letterMap.Add(nextChar, -1);
                nextChar = Console.Read();
            }

            var totalDiffs = 0;
            foreach (var item in letterMap)
                totalDiffs += Math.Abs(item.Value);

            Console.WriteLine(totalDiffs);
    }
}