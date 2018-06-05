/*
         Problem: https://www.hackerrank.com/challenges/closest-numbers/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Sort the input array using quick sort (average complexity nlogn). Let us call the new sorted array, srtarr. 
         2. Set up a list which will contain the list of numbers having minimum difference. Let's call it MINdiffLIST Add the first two elements of srtarr into the list.
         3. Start tracking min difference between any two adjacent elements of the array. Let's call it MINdiff. Set MINdiff to difference of first two elements in the sorted array.
         4. Start iterating the array from 1st index of the array.
            4.1 if difference of current element and subsequent element in the array is less than MINdiff then
                - clear MINdiffLIST.
                - Add current and subsequent element in srtarr into MINdiffLIST
                - Set MINdiff to the absolute difference of current and subsequent element in srtarr.
            4.2 if difference of current element and subsequent element in the array is equal to MINdiff then
                - Add current and subsequent element in srtarr into MINdiffLIST
          5. Print all the elements of MINdiffLIST on console.

         Time Complexity:  O(n log(n)) //There are two complexities involved here. nlog(n) for quick sort and n for a loop iteration. Jointly they can be called  nlog(n)
         Space Complexity: O(n) //we need to maintain a separate list of each pair of numbers who are having minimum difference in entire set. It can take 2n space in worst case.
                                //also my quick sort implementation isn't in-place. So it can again take n space.
             
        */

using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static int[] ClosestNumbers(int[] arr)
    {
        arr = QuickSortForClosestNumbers(arr);
        var closeNumbers = new List<int> { arr[0], arr[1] };
        var smallestDifference = GetAbsoluteDifference(arr[1], arr[0]);


        for (var i = 1; i < arr.Length - 1; i++)
        {
            var currentDiff = GetAbsoluteDifference(arr[i], arr[i + 1]);
            if (currentDiff < smallestDifference)
            {
                smallestDifference = currentDiff;
                closeNumbers = new List<int>() { arr[i], arr[i + 1] };
            }
            else if (currentDiff == smallestDifference)
            {
                closeNumbers.Add(arr[i]);
                closeNumbers.Add(arr[i + 1]);
            }
        }

        return closeNumbers.ToArray();
    }

    private static int GetAbsoluteDifference(int v1, int v2)
    {
        var absoluteDifference = 0;
        if ((v1 >= 0 && v2 >= 0) || (v1 <= 0 && v2 <= 0))
            absoluteDifference = Math.Abs(Math.Abs(v1) - Math.Abs(v2));
        else
        {
            if (v1 < 0)
                v1 = -v1;
            else
                v2 = -v2;

            absoluteDifference = v1 + v2;
        }
        return absoluteDifference;
    }

    static int[] QuickSortForClosestNumbers(int[] arr)
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
            smallerItems = QuickSortForClosestNumbers(smallerItems.ToArray()).ToList();

        if (biggerItems.Count > 1)
            biggerItems = QuickSortForClosestNumbers(biggerItems.ToArray()).ToList();

        var j = 0;

        foreach (var item in smallerItems)
            outputArr[j++] = item;

        foreach (var item in equalItems)
            outputArr[j++] = item;

        foreach (var item in biggerItems)
            outputArr[j++] = item;

        return outputArr;
    }
    static void Main(String[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var result = ClosestNumbers(arr);
        Console.WriteLine(string.Join(" ", result));
    }
}