/*
         Problem: https://www.hackerrank.com/challenges/luck-balance/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Main idea is that we can maximize Lena's luck by keep below facts in mind:
            => If any contest is unimportant then she can loose it straight away to increase luck balance.
            => For important contests, if k >= total count of important contests then she can loose all of them as well
                straight away to increase luck balance.
            => For important contests, if k < total count of important contests then, we have to make sure that she looses only 
                those k contests which have got highest luck value.
               e.g. if important contests have got value 1,2,3 and k = 2. Then she must loose the contests having value 3 & 2
               to maximize total luck.
               The remaining important contests will have to be won resulting in reduction of total luck balance.

         Gotchas/Caveats:
          <None>

         Time Complexity:  O(nlog(n)) //we need to iterate the important contests twice. we also need to sort them using quick sort.
         Space Complexity: O(n) //We need to store the imortant contests in memory to sort it using quick sort.
        */

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var inputSplits = Console.ReadLine().Split(' ');
        var n = int.Parse(inputSplits[0]);
        var k = int.Parse(inputSplits[1]);
        var totalLuck = 0;
        var importantContests = new List<int>();
        while (n > 0)
        {
            inputSplits = Console.ReadLine().Split(' ');
            var luck = inputSplits[0];
            var importance = inputSplits[1];
            if (importance == "0")
                totalLuck += int.Parse(luck);
            else
                importantContests.Add(int.Parse(luck));
            n--;
        }

        if (importantContests.Count > k)
        {
            if (importantContests.Count > 1)
                importantContests = QuickSortInDescendingOrder(importantContests);

            var i = 0;
            while (i < importantContests.Count)
            {
                while (k > 0)
                {
                    totalLuck += importantContests[i];
                    k--;
                    i++;
                }

                totalLuck -= importantContests[i];
                i++;
            }
        }
        else
        {
            foreach (var luck in importantContests)
                totalLuck += luck;
        }
        Console.WriteLine(totalLuck);
    }

    static List<int> QuickSortInDescendingOrder(List<int> arr)
    {
        var pivot = arr[0];
        var smallerItems = new List<int>();
        var equalItems = new List<int>();
        var biggerItems = new List<int>();
        var sortedList = new List<int>();

        equalItems.Add(arr[0]);

        for (var i = 1; i < arr.Count; i++)
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
            smallerItems = QuickSortInDescendingOrder(smallerItems);

        if (biggerItems.Count > 1)
            biggerItems = QuickSortInDescendingOrder(biggerItems);

        var j = 0;

        foreach (var item in biggerItems)
            sortedList.Add(item);

        foreach (var item in equalItems)
            sortedList.Add(item);

        foreach (var item in smallerItems)
            sortedList.Add(item);

        return sortedList;
    }
}