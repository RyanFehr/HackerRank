/*
         Problem: https://www.hackerrank.com/challenges/two-arrays/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Sort the two input arrays.
         - Start iterating first sorted array from start and other sorted array from end.
         - Check if sum of each pair of (i)th element of first sorted array and (n-i-1)th element from second sorted array
            is >= k. If all pairs qualify then print "YES" else print "NO".
          

         Gotchas/Caveats:
          <None>

         Time Complexity for each query:  O(n log(n)) //Factually it is - Sorting + Iteration ~ O(n log(n)) + O(n) ~ O(n log(n)). 
         Space Complexity: O(n) //Space is required to store the elements in memory for sorting purpose.
        */

using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    static void Main(string[] args)
    {
        var queryCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < queryCount; i++)
        {
            var userInputSplits = Console.ReadLine().Split(' ');
            var k = int.Parse(userInputSplits[1]);
            userInputSplits = Console.ReadLine().Split(' ');
            var arrayA = Array.ConvertAll(userInputSplits, int.Parse);
            userInputSplits = Console.ReadLine().Split(' ');
            var arrayB = Array.ConvertAll(userInputSplits, int.Parse);

            arrayA = QuickSortAsc(arrayA);
            arrayB = QuickSortAsc(arrayB);

            var permutationExists = "YES";
            for (var j = 0; j < arrayA.Length; j++)
            {
                if (arrayA[j] + arrayB[arrayB.Length - j - 1] < k)
                {
                    permutationExists = "NO";
                    break;
                }
            }
            Console.WriteLine(permutationExists);
        }
    }

    static int[] QuickSortAsc(int[] arr)
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
            smallerItems = QuickSortAsc(smallerItems.ToArray()).ToList();

        if (biggerItems.Count > 1)
            biggerItems = QuickSortAsc(biggerItems.ToArray()).ToList();

        var j = 0;

        foreach (var item in smallerItems)
            outputArr[j++] = item;

        foreach (var item in equalItems)
            outputArr[j++] = item;

        foreach (var item in biggerItems)
            outputArr[j++] = item;

        return outputArr;
    }
}