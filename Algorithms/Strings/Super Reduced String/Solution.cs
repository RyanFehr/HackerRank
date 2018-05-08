/*
         Problem: https://www.hackerrank.com/challenges/reduced-string/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         
         We need to iterate the entire string and process it as per below mentioned steps:
          - Append every character coming in the input sequence into a string builder if it is not matching with the
            last character in the string builder.
          - If the character in input sequence matches with last character in the string builder then remove the last character
            from the string builder.

         Time Complexity:  O(n) //we need to iterate the entire string of length n once to remove all the repeated characters.
         Space Complexity: O(n) //we need to store the input string in memory to process it and find repeated characters.
         
        */

using System;
using System.Text;

class Solution
{
    static string SuperReducedString(string sequence)
    {
        var sb = new StringBuilder();
        sb.Append(sequence[0]);

        for (var i = 1; i < sequence.Length; i++)
        {
            if (sb.Length > 0 && sequence[i] == sb[sb.Length - 1])
                sb = sb.Remove(sb.Length - 1, 1);
            else
                sb.Append(sequence[i]);

        }
        return sb.ToString();
    }

    static void Main(String[] args)
    {
        var inputSequence = Console.ReadLine();
        var result = SuperReducedString(inputSequence);
        Console.WriteLine(result == "" ? "Empty String" : result);
    }
}
