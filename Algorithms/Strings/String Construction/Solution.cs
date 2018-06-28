/*
         Problem: https://www.hackerrank.com/challenges/string-construction/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Main idea is to check whether a character appearing in the input string has already appeared till that point or not.
         - So, everytime you read a character just store it in a hashset.
         - Then whenever a character is read in input string, check its presence in hashset. If absent then it will increase
         the dollar cost of copy operation by 1 else move to next character.
         - Print the total dollar cost in the end.

         Gotchas:
          <None>

         Time Complexity:  O(n)
         Space Complexity: O(1) //We are creating a hashmap which will have a maximum of 26 (a constant) entries in worst case.
*/

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var numberOfQueries = int.Parse(Console.ReadLine());
        for (var i = 0; i < numberOfQueries; i++)
        {
            var charMap = new HashSet<int>();
            var nextChar = Console.Read();
            //special handling for hacker rank execution environment.
            //for line break hacker rank uses '\n' whose ascii code is 10
            // and for end of file they use -1 which is the end of last test case.
            //on my local box I use 13 which is the ascii code for '\r'
            while (nextChar != 10 && nextChar != -1)
            {
                if (!charMap.Contains(nextChar))
                    charMap.Add(nextChar);
                nextChar = Console.Read();
            }
            Console.WriteLine(charMap.Count);
        }
    }
}
