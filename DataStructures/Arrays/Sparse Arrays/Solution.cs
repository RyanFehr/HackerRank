/*
         Problem: https://www.hackerrank.com/challenges/sparse-arrays/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
          - Going via sparse matrix route the complexity comes out to be O(n * q * 20) so I solved it with help of hash map which gives better complexity
          - Scan each input string and stores its count in a hash map.
          - For each query string, check its count in the hash map and print it on console.

         Gotchas:
            <None>

         Time Complexity:  O(n + q) //n is number of input strings and q is number of queries.
         Space Complexity: O(n + q) //a hash map (for storing frequency) and an array (for storing output counts) is addtional space requirement.
         
*/

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var inputCount = int.Parse(Console.ReadLine());
        var stringMap = new Dictionary<string, int>();

        for (var i = 0; i < inputCount; i++)
        {
            var input = Console.ReadLine();
            if (stringMap.ContainsKey(input))
                stringMap[input]++;
            else
                stringMap.Add(input, 1);
        }

        var queryCount = int.Parse(Console.ReadLine());
        var output = new int[queryCount];
        for (var i = 0; i < queryCount; i++)
        {
            var queryString = Console.ReadLine();
            if (stringMap.ContainsKey(queryString))
                output[i] = stringMap[queryString];
        }

        foreach (var item in output)
            Console.WriteLine(item);
    }
}