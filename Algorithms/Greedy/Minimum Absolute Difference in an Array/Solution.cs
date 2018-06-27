/*
         Problem: https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Sort the input
         2. Iterate the sorted input and track the absolute difference between adjacent elements
         3. Print the minimum difference thus found.

         Time Complexity:  O(n log(n)) //actually it is O(n log(n)) + O(n)
         Space Complexity: O(n) //need to store all the elements in  memory for processing as sorting using quick sort is also involved.
         
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var inputNumbers = Array.ConvertAll(arr_temp, int.Parse);
        //contributes O(n log(n)) complexity
        inputNumbers = QuickSort2(inputNumbers);
        var minimumDiff = Math.Abs(inputNumbers[0] - inputNumbers[1]);
        //contributes O(n) complexity
        for (var i = 1; i < inputNumbers.Length - 1; i++)
            minimumDiff = Math.Min(Math.Abs(inputNumbers[i] - inputNumbers[i + 1]), minimumDiff);

        Console.WriteLine(minimumDiff);
    }

    static int[] QuickSort2(int[] arr)
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
                equalItems.Add(arr[i]);
        }

        if (smallerItems.Count > 1)
            smallerItems = QuickSort2(smallerItems.ToArray()).ToList();

        if (biggerItems.Count > 1)
            biggerItems = QuickSort2(biggerItems.ToArray()).ToList();

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
