/*
        Problem: https://www.hackerrank.com/challenges/funny-string/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :
         - Here we have to iterate through the string and keep checking the difference between adjacent characters
         - The only trick is that we can check the difference both in forward and reverse direction at the same time and compare them in single go. So, we don't require two iteration.

        Time Complexity:  O(n) //we need to iterate the entire string once.
        Space Complexity: O(n) //we need to store entire string in memory to process both in forward and reverse direction at the same time.

*/
using System;
class Solution
{
    static void Main(string[] args)
    {
        var testCount = int.Parse(Console.ReadLine());
        for (var j = 0; j < testCount; j++)
        {
            var inputString = Console.ReadLine();
            var i = 0;
            for (; i < inputString.Length - 1; i++)
            {
                var diffForwardSeries = Math.Abs(inputString[i] - inputString[i + 1]);
                var diffBackwardSeries = Math.Abs(inputString[inputString.Length - 1 - i] - inputString[inputString.Length - 1 - i - 1]);
                if (diffForwardSeries != diffBackwardSeries)
                    break;
            }

            if (i == inputString.Length - 1)
                Console.WriteLine("Funny");
            else
                Console.WriteLine("Not Funny");
        }
    }
}