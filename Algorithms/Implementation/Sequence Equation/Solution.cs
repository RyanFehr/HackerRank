/*
Problem: https://www.hackerrank.com/challenges/permutation-equation/problem
C# Language Version: 6.0
.Net Framework Version: 4.5.2
Thoughts :

1. Put all p(x) values into a dictionary named sequenceCount with key = p(x) and value = x.
2. Iterate through a loop which iterates from x = 1 to n where n is length of sequenceCount dictionary.
    2.1 For each x print sequenceCount[x]

Time Complexity:  O(n) //it is ammortized O(1) as it is a hashmap based seeking.
Space Complexity: O(n) // For each p(x) we are also storing x as value in the dictionary. 

*/

using System;
using System.Collections.Generic;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            var sequenceCount = int.Parse(Console.ReadLine());
            var userInput = Console.ReadLine().Split(' ');

            var sequenceDictionary = new Dictionary<int, int>();
            for (int i = 0; i < sequenceCount; i++)
                sequenceDictionary.Add(int.Parse(userInput[i]), i + 1);

            for (int x = 1; x <= sequenceCount; x++)
            {
                var ppy = sequenceDictionary[sequenceDictionary[x]];
                Console.WriteLine(ppy);
            }
        }
    }
}
