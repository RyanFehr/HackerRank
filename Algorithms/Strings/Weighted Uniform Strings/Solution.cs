/*
         Problem: https://www.hackerrank.com/challenges/weighted-uniform-string/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
          - first create a hash set of sum of all possible uniform strings as we iterate through the string char by char
          - for each query, just check if the uniform sum being queried is present in the hash set or not (contributes O(1) as searching
            in hashset is contant operation)

         Time Complexity:  O(n) //one iteration is required to create set of weights of uniform stings
         Space Complexity: O(n) //space for has set of weights of uniform strings.
                
*/
using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var currentChar = Console.Read();
        var previousChar = -1;
        var uniformStringSum = 0;
        var uniformWeightSet = new HashSet<int>();
        //special handling for hacker rank execution environment
        //while running it on my own Windows based computer, I compare it with ascii code of carriage return ('\r') which is 13.
        while (currentChar != 10)
        {
            if (currentChar != previousChar)
                uniformStringSum = currentChar - 96;
            else
                uniformStringSum += currentChar - 96;

            uniformWeightSet.Add(uniformStringSum);
            previousChar = currentChar;
            currentChar = Console.Read();
        }
        //skipping '\n' character as new line character in windows is combination of \r and \n
        //Commented as it is not required for HackerRank execution environment.
        //Console.Read();
        var queryCount = int.Parse(Console.ReadLine());

        while (queryCount > 0)
        {
            var uniformWeight = int.Parse(Console.ReadLine());
            if (uniformWeightSet.Contains(uniformWeight))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}