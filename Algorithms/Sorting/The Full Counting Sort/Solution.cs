/*
         Problem: https://www.hackerrank.com/challenges/countingsort4
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :

         Overall we've to apply the same algorithm required for counting sort. We did it here also - 
         - https://www.hackerrank.com/challenges/countingsort2/problem

         It requires basic arithmetic to sort keys lying in specific range 0 to k.

         There are few specialities and tweaks here though:

         1. We need to store the input keys in an array. Here key isn't a number directly but a combination of key and associated 
            attributes. Here associated attribute is a string value. So for each input we need to create a custom object 
            containing key and value.
         2. While we create the custom object for each input we need to replace each attribute with "-" for first half of the input.
            This is as per requirement of the question.
         3. Making the algorithm stable is another task in the problem. That can be achieved by simply traversing the array from 
            the end while performing the final traversal to position any give key-value pair at its correct position.

         Time Complexity:  O(n+k) //There are no nested loops. We iterate the input array thrice for
                                    - Creating input array
                                    - Positioning the element
                                    - Traversing the sorted array to create concatenated output string value
                                    AND
                                    We also iterate the array of k keys to create the frequency of each input key

         Space Complexity: O(n+k) //We require an additional array of size n to store the sorted output array.
                                  //and an array for storing frequency of k keys present in input.
*/

using System;
using System.IO;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        var inputKeysCount = int.Parse(Console.ReadLine());
        var keyFrequency = new int[100];
        var inputArray = new Data[inputKeysCount];
        for (var i = 0; i < inputKeysCount; i++)
        {
            var tokens = Console.ReadLine().Split(' ');
            var key = int.Parse(tokens[0]);
            var text = tokens[1];
            if (i + 1 <= inputKeysCount / 2)
                text = "-";
            inputArray[i] = new Data { Key = key, Value = text };
            keyFrequency[key] += 1;
        }

        //modify frequency array by adding previous counts cumulatively
        for (var i = 1; i < 100; i++)
            keyFrequency[i] += keyFrequency[i - 1];

        var sortedOutput = new Data[inputKeysCount];

        for (var i = inputKeysCount - 1; i >= 0; i--)
        {
            var key = inputArray[i].Key;
            var position = keyFrequency[key];
            keyFrequency[key] -= 1;
            sortedOutput[position - 1] = inputArray[i];
        }
        var stringBuilder = new StringBuilder();
        for (var i = 0; i < inputKeysCount; i++)
            stringBuilder.Append(sortedOutput[i].Value + ' ');

        Console.Write(stringBuilder.ToString());
    }
}

public class Data
{
    public int Key { get; set; }
    public string Value { get; set; }
}