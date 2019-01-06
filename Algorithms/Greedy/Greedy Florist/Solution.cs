/*
         Problem: https://www.hackerrank.com/challenges/greedy-florist/problem
         C# Language Version: 8.0
         .NET Framework Version: 4.7.2
         Tool Version : Visual Studio Preview 2019
         Thoughts (Key points in algorithm):
         1. Key point here is that we've to multiply the large cost flowers with minimum number.
         2. Sort the array of flower costs in descending order.
         3. Keep a track of purchases done by individual friends.
         4. Keep a pointer pointing to 0th index of purchase tracker array.
         5. start from the costliest flower and do the calculation based on the pointer of purchase tracker array.
         6. Keep adding the effective flower cost into a running total.
         7. Keep moving the pointer of purchase tracker array to next element after processing each flower cost.
         8. If the pointer of purchase tracker array has hit the uppper bound of the array then reset it back to 0.
         9. Print the running total.

         Gotchas/Caveats:
          <None>

         Time Complexity:  O(n log(n)) //the flower price array needs to be sorted using quick sort.
         Space Complexity: O(n) //Effectively my space complexity is O(n+k) as I'm using an additional array to track 
                                 the count of purchases done by k individuals. ~O(n)
                
        */
using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {

        var userInputSplits = Console.ReadLine().Split(' ');
        var flowerCount = int.Parse(userInputSplits[0]);
        var friendCount = int.Parse(userInputSplits[1]);
        var purchaseTracker = new int[friendCount];
        userInputSplits = Console.ReadLine().Split(' ');
        var flowerCosts = Array.ConvertAll(userInputSplits, int.Parse);
        flowerCosts = QuickSortInDescendingOrder(flowerCosts);
        var friendIndex = 0;
        var minCost = 0;
        for (var i = 0; i < flowerCosts.Length; i++)
        {
            minCost += (purchaseTracker[friendIndex] + 1) * flowerCosts[i];
            purchaseTracker[friendIndex]++;
            friendIndex++;
            if (friendIndex == friendCount)
                friendIndex = 0;
        }
        Console.WriteLine(minCost);

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
}