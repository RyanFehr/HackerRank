/*
         Problem: https://www.hackerrank.com/challenges/the-love-letter-mystery/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
         - Keep a counter to track the reductions
         - Every time compare a character to its corresponding palindrome position character in the string. e.g. in the string abcd, a's palindrome position character is d. If they are unequal
           then increment the tracking counter by the difference between their ASCII codes.
         - We need to traverse only half of the string to complete the checks.

         Gotchas:
            <None>

         Time Complexity:  O(n) //actually it is O(n/2) ~ O(n)
         Space Complexity: O(n) //we need to store the input string in memory to process it.
             
*/
using System;
class Solution
{
    static void Main(string[] args)
    {
        var queryCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < queryCount; i++)
        {
            var inputText = Console.ReadLine();
            var reductionCount = 0;
            for (var j = 0; j < inputText.Length / 2; j++)
                reductionCount += Math.Abs(inputText[j] - inputText[inputText.Length - j - 1]);

            Console.WriteLine(reductionCount);
        }
    }
}