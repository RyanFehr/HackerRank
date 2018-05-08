/*
        Problem: https://www.hackerrank.com/challenges/reduced-string/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :

        We need to iterate the entire string and process it as per below mentioned steps:
         - remove the repeated characters whereever found and then process the remaining string from the point where
           repeated character was found.
         - special handling : Consider the string "abccbee". Here when we remove the pair "cc" then we need to start scanning
           the string from position of first occurence of b else "bb" pair will not be caught.
         - Some special handling required when repeated sequences occur at the beginning of the string

        Time Complexity:  O(n) //we need to iterate the entire string of length n once to remove all the repeated characters.
        Space Complexity: O(n) //we need to store the input string in memory to process it and find repeated characters.

       */

using System;

class Solution
{
    static string SuperReducedString(string sequence)
    {
        while (sequence.Length > 0 && sequence[0] == sequence[1])
            sequence = sequence.Substring(2);

        for (var i = 0; i < sequence.Length - 1;)
        {
            if (sequence[i] == sequence[i + 1])
            {
                var part1 = sequence.Substring(0, i);
                var part2 = sequence.Substring(i + 2);
                sequence = part1 + part2;
                i = i > 0 ? i - 1 : i;
                continue;
            }
            i++;
        }
        return sequence;
    }

    static void Main(String[] args)
    {
        var inputSequence = Console.ReadLine();
        var result = SuperReducedString(inputSequence);
        Console.WriteLine(result == "" ? "Empty String" : result);
    }
}
