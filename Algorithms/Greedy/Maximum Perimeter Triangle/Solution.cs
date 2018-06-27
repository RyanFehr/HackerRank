/*
         Problem: https://www.hackerrank.com/challenges/maximum-perimeter-triangle/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         Brute force approach:
         - In brute force approach, the idea is to move as per the instructions given in the question.
         - create all possible combinations ⁿC₃ to create set of all possible triangles. Check whether any given
            triangle is non-degenerate or not. Track the maximum perimeter across all non-degenerate triangles.
         - All the triangles who are non-degenerate and have maximum perimeter need to be processed as per three conditions
           given in question

         Current approach:
         - Sort all the sticks in descending order. I've used quick sort for n log(n) complexity.
         - Now start creating tringle triplets from the biggest stick and start checking them for being non-degenerate
            triangle. e.g. if sticks are 5,4,3,2,1 then our triplets are (5,4,3),(4,3,2),(3,2,1).
         - The first non-degenerate triangle found in above scan is our answer. We don't need to process it for three conditions
            given in the question. They will be satisfied automatically.


         Gotchas/Caveats:
          <None>

         Time Complexity:  O(n log(n)) //factually it is n log(n) + n ~ n log(n)
         Space Complexity: O(n) //input stick lengths need to be stored in memory to undergo sorting process.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        var stickCount = int.Parse(Console.ReadLine());
        var inputSplits = Console.ReadLine().Split(' ');
        var sticks = Array.ConvertAll(inputSplits, int.Parse);

        sticks = QuickSortInDescendingOrder(sticks);
        var i = 0;
        for (; i < sticks.Length - 2; i++)
        {
            var stick1 = sticks[i];
            var stick2 = sticks[i + 1];
            var stick3 = sticks[i + 2];
            var isNonDegenerateTriangle = IsNonDegenerateTriangle(stick1, stick2, stick3);
            if (isNonDegenerateTriangle)
            {
                //print sticks in non-decreasing order
                Console.WriteLine($"{stick3} {stick2} {stick1}");
                break;
            }
        }

        if (i == sticks.Length - 2)
            Console.WriteLine("-1");
    }

    static int[] QuickSortInDescendingOrder(int[] arr)
    {
        var pivot = arr[0];
        var smallerItems = new List<int>();
        var equalItems = new List<int>();
        var biggerItems = new List<int>();
        var outputArr = new int[arr.Length];

        equalItems.Add(arr[0]);

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
                smallerItems.Add(arr[i]);
            else if (arr[i] > pivot)
            {
                biggerItems.Add(arr[i]);
            }
            else
            {
                equalItems.Add(arr[i]);
            }
        }

        if (smallerItems.Count > 1)
            smallerItems = QuickSortInDescendingOrder(smallerItems.ToArray()).ToList();

        if (biggerItems.Count > 1)
            biggerItems = QuickSortInDescendingOrder(biggerItems.ToArray()).ToList();

        var j = 0;

        foreach (var item in biggerItems)
            outputArr[j++] = item;

        foreach (var item in equalItems)
            outputArr[j++] = item;

        foreach (var item in smallerItems)
            outputArr[j++] = item;

        return outputArr;
    }

    private static bool IsNonDegenerateTriangle(int stick1, int stick2, int stick3)
    {
        if (stick1 + stick2 > stick3
            && stick2 + stick3 > stick1
            && stick3 + stick1 > stick2)
            return true;
        else
            return false;
    }
}