/*
     Problem: https://www.hackerrank.com/challenges/minimum-distances/problem
     C# Language Version: 7.0
     .Net Framework Version: 4.7
     Tool Version : Visual Studio Community 2017
     Thoughts :
     1. Let the array be arr containing all input integers.
     2. Let minimum distance value to be found be minDist. Initialize minDist with -1.
     3. Let there be a hash map which can contain integers as key-value pairs. Let its name be hm.
     4. Start iterating arr in a loop:
        4.1 Let the current integer being iterated is n.
        4.2 Let the index of n in the array be i.
        4.3 Check whether n is present as key in hm or not:
            4.3.1 If it is not present then add (n,i) as key value pair into hm.
            4.3.2 If it is present then check if minDist is still set to -1:
                4.3.2.1 If yes then set minDist to difference of i and value corresponding to n key in hm.
                4.3.2.2 If no then check whether difference of i and value corresponding to n key in hm is less than minDist.
                        If it is true then set minDist to difference of i and value corresponding to n key in hm.
        4.4 Keep repeating steps from 4.1 through 4.3 until entire array gets iterated.
    5. Print minDist on console.

     Time Complexity:  O(n) Array of integers has to iterated at least once in entirety.
     Space Complexity: O(n) I'm maintaining an extra hash map having index of unique elements in the array.
        
*/

using System;
using System.Collections.Generic;
class Solution
{
    static int MinimumDistances(int[] arr)
    {
        var minimumDist = -1;
        var numberMap = new Dictionary<int, int>();
        for (var i = 0; i < arr.Length; i++)
        {
            if (numberMap.ContainsKey(arr[i]))
            {
                if (minimumDist == -1)
                {
                    minimumDist = i - numberMap[arr[i]];
                    continue;
                }

                if (i - numberMap[arr[i]] < minimumDist)
                    minimumDist = i - numberMap[arr[i]];
            }
            else
                numberMap.Add(arr[i], i);
        }
        return minimumDist;
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. I use array's length property instead.
        Console.ReadLine();
        var a_temp = Console.ReadLine().Split(' ');
        var a = Array.ConvertAll(a_temp, Int32.Parse);
        var result = MinimumDistances(a);
        Console.WriteLine(result);
    }
}
