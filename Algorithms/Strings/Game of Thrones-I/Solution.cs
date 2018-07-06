/*
         Problem: https://www.hackerrank.com/challenges/game-of-thrones/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
         - Main idea is if the string is a palindrome then it falls in two cases:
            - If length of input is odd, then except one character the count of every character appearing in the string should be an even number.
            - If length of input is even, then the count of every character appearing in the string should be an even number.
         Gotchas:
            <None>

         Time Complexity:  O(n) //iterating the entire input is required.
         Space Complexity: O(1) //No additional space required
         
*/
using System.Collections.Generic;
using System;
class Solution
{
    static void Main(string[] args)
    {
        var inputLength = 0;
        var charMap = new Dictionary<int, int>();
        var nextChar = Console.Read();

        while (nextChar != -1)
        {
            inputLength++;
            if (charMap.ContainsKey(nextChar))
            {
                var currentCount = charMap[nextChar];
                if (currentCount == 1)
                    charMap[nextChar] = 0;
                else
                    charMap[nextChar] = 1;
            }
            else
                charMap.Add(nextChar, 1);

            nextChar = Console.Read();
        }

        var total = 0;
        foreach (var item in charMap)
            total += item.Value;

        if (inputLength % 2 == 0 && total == 0)
            Console.WriteLine("YES");
        else if (inputLength % 2 != 0 && total == 1)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}