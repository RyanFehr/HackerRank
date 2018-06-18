/*
         Problem: https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
         - first get a frequency map of each letter occuring in the input string.
         - Now there are only 3 possible cases in which after deleting single character from the string it will become a valid string:
            1. aaabbbccc (already a valid string)
                a-3
                b-3
                c-3
            2. aaabbbcccc
                a-3
                b-3
                c-4
              All characters should have same frequency except one. The character ('c') whose frequency is different from the rest should be just one more than others.
            3. aaabbbc
              This case requires special handling when we process the input with a generic hasmap based approach.

         Gotchas:
            <None>

         Time Complexity:  O(n) //we iterate the entire string once to create frequency map.
         Space Complexity: O(1) //we need a hashmap for storing frequency of 26 characters. So it is a constant space requirement irrespective of the length of input string.
             
        */
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        var charFreqency = new Dictionary<int, int>();
        var validString = "YES";
        var nextChar = Console.Read();

        //special handling for hacker rank execution environment.
        //for end of file they use -1 which is the end of the input string as well.
        while (nextChar != -1)
        {
            if (charFreqency.ContainsKey(nextChar))
                charFreqency[nextChar]++;
            else
                charFreqency.Add(nextChar, 1);

            nextChar = Console.Read();
        }

        var frequencyMap = new Dictionary<int, int>();
        //for a valid string there should be at max two types of frequencies.
        //this loop runs fixed 26 times in worst case.
        foreach (var frequency in charFreqency)
        {
            if (frequencyMap.ContainsKey(frequency.Value))
                frequencyMap[frequency.Value]++;
            else
                frequencyMap.Add(frequency.Value, 1);

            if (frequencyMap.Count > 2)
            {
                validString = "NO";
                break;
            }
        }

        if (validString == "YES" & frequencyMap.Count == 2)
        {
            //there are two keys in all in the hasmap. Bigger key should be
            //one greater than smaller key. Also, value of bigger key should be 1.
            var biggerKey = -1;
            var smallerKey = -1;

            if (frequencyMap.Keys.ElementAt(0) > frequencyMap.Keys.ElementAt(1))
            {
                biggerKey = frequencyMap.Keys.ElementAt(0);
                smallerKey = frequencyMap.Keys.ElementAt(1);
            }
            else
            {
                biggerKey = frequencyMap.Keys.ElementAt(1);
                smallerKey = frequencyMap.Keys.ElementAt(0);
            }

            if (smallerKey == 1 && frequencyMap[smallerKey] == 1)
            {
                //this is a valid string case.
                //special handlin for case 3. sample input: aaabbbc

            }
            else if (!(biggerKey - smallerKey == 1 && frequencyMap[biggerKey] == 1))
                validString = "NO";
        }
        Console.WriteLine(validString);
    }
}