/*
 Problem: https://www.hackerrank.com/challenges/the-time-in-words/problem
 C# Language Version: 7.0
 .Net Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts :
 1. Let the input values of hours and minutes be h and m respectively.
 2. Declare an array hw containing string values of numbers from 1 to 11.
 3. Declare an array mw containing string values of numbers from 1 to 29.
 4. Print the appropriate string representation of time using hw and mw arrays based on the values of h and m.

 Time Complexity:  O(1) //there are no loops at all.
 Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/

using System;

class Solution
{
    static void Main(String[] args)
    {
        var h = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var hourWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven" };
        var minuteWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
                                    , "eleven", "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty"
                                    , "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight","twenty nine" };


        if (m == 0)
            Console.Write($"{hourWords[h - 1]} o' clock");

        if ((m > 0 && m < 15) || (m > 15 && m < 30))
            Console.Write($"{minuteWords[m - 1]} minutes past {hourWords[h - 1]}");

        if ((m > 30 && m < 45) || (m > 45 && m < 60))
            Console.Write($"{minuteWords[60 - m - 1]} minutes to {hourWords[h]}");

        if (m == 15)
            Console.Write($"quarter past {hourWords[h - 1]}");

        if (m == 30)
            Console.Write($"half past {hourWords[h - 1]}");

        if (m == 45)
            Console.Write($"quarter to {hourWords[h]}");
    }
}
