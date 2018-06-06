/*
        Problem: https://www.hackerrank.com/challenges/camelcase/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :
        1. Keep a counter initialized at 1.
        2. We need to iterate the entire string chracter by character. Increment the counter by 1 everytime you encounter
        an upper case character in the string.
         
    We're using .NET's built-in method char.IsUpper to check whether the current character is an upper case character or
    not. This is an O(1) operation. We can also keep a dictionary (HashSet in C# is best fit as we need to store only keys)
    to check it in O(1) time.

        Time Complexity:  O(n)
        Space Complexity: O(1) //dynamically allocated variables are fixed for any length of input.
         
*/
using System;

class Solution
{
    private static int CamelCase()
    {
        var wordCount = 1;
        var nextChar = Console.Read();
        //This is a special condition for hacker rank execution environment
        //while running it in Visual Studio I was comparing it with 13 which is the ASCII code of enter key.
        while (nextChar != -1)
        {
            if (char.IsUpper((char)nextChar))
                wordCount++;
            nextChar = Console.Read();
        }
        return wordCount;
    }

    static void Main(string[] args)
    {
        var result = CamelCase();
        Console.WriteLine(result);
    }
}
