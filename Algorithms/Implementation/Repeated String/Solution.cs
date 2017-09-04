/*
    Problem: https://www.hackerrank.com/challenges/repeated-string/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the input string be s. Let its length be m.
    2. Let the input number be n.
    3. Count the occurence of letter 'a' in string s. Let the count comes out to be c.
    4. Get the possible whole number repeatitions of string s within length n. Let it be r. Increment c by r.
    5. Let there be an offset nuber o. Calculate o as (n mod m).
    6. Now find the occurence of letter 'a' in first o characters in string s. Let this count be ac. Increment c by ac.
    7. Print c.

    Time Complexity:  O(m) //we need to traverse the input string once in entirety and once partially.
    Space Complexity: O(m) //input string of length m has to be saved in memory for later processing.
*/

using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var s = ReadLine();
        var n = long.Parse(Console.ReadLine());

        //find the occurence of a in input string s
        var count = 0L;
        foreach (var letter in s)
        {
            if (letter == 'a')
                count++;
        }

        var possibleStringRepeatitions = n / s.Length;
        count *= possibleStringRepeatitions;
        var offsetStringLength = n % s.Length;

        for (int i = 0; i < offsetStringLength; i++)
        {
            if (s[i] == 'a')
                count++;
        }

        WriteLine(count);
    }
}