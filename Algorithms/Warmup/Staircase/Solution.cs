/*
    Problem: https://www.hackerrank.com/challenges/staircase/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the number of stairs in the staircase be n.
    2. Start a for loop which runs n times using a counter i which changes its value from 1 to n
    2.1 Create a string s of space character repeated n-i times.
    2.2 Create a string h of # character repeated i times.
    2.3 Append h in s and print the resulting string on console in a new line.
    2.4 Repeat steps 2.1 through 2.3 in the loop to prepare each stair of the staircase.

    Time Complexity:  O(n) there is one for loop.
    Space Complexity: O(n) //size of dynamically allocated variables s (a char array) and h (a char array) is proportional to n.
                
*/

using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(ReadLine());
        for (int i = 1; i <= n; i++)
        {
            var spaces = new String(' ', n - i);
            var hashes = new String('#', i);
            WriteLine(spaces + hashes);
        }
    }
}