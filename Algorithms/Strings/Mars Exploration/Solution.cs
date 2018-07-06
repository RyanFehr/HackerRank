/*
         Problem: https://www.hackerrank.com/challenges/mars-exploration/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
          - Pick 3 characters at a time from the string and check whether they match with SOS string or not.
          - For each unmatched character increment a counter.
          - Print the counter once entire string has been traversed.

         Time Complexity:  O(n) //entire string traversal is required once.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
         
*/

using System;

class Solution
{
    static void Main(string[] args)
    {
        var alteredCharCount = 0;
        var sosSignal = "SOS";
        var index = 0;
        var nextChar = Console.Read();
        //special handling for hacker rank execution environment
        //while running on my own computer I compare it with ascii code of enter key which is 13.
        while (nextChar != -1)
        {
            if ((char)nextChar != sosSignal[index++])
                alteredCharCount++;

            if (index % 3 == 0)
                index = 0;
            nextChar = Console.Read();
        }

        Console.WriteLine(alteredCharCount);
    }
}
