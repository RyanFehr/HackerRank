/*
         Problem: https://www.hackerrank.com/challenges/pairs/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts : Overall main thing to know in this problem is two pointer technique.
         Before applying two pointer technique sort the input data using quick sort. We can use any sorting but
         quick sort is most optimal with n (log (n)) time complexity.

         Now the two pointer technique. Let's say k - 2 and we've already sorted the input in ascending order. 
         We will maintain a counter which will keep a count of desired pairs. Currently our pointers are 1 and 2.
         Initial position of pointers is as below:
         
         ▼  ▼
         1  2  3  4  5

         Currente State - Difference between 2 and 1 is 1. But k is 2. Since k > current difference so we move the second pointer to
         get a larger differrence as shown below:

         ▼     ▼
         1  2  3  4  5

         Currente State - Difference between 3 and 1 is 2. we got the desired pair as k is 2 so we increment the counter. Now we 
         move the first pointer one step further as shown below:

            ▼  ▼
         1  2  3  4  5

        Currente State - Difference between 3 and 2 is 1. But k is 2. Since k > current difference so we move the second pointer to get
        a larger difference as shown below:
    
            ▼     ▼
         1  2  3  4  5

        So we just keep going like this until second pointer hasn't exceeded the bounds of the array. 
        Print the count of desired pairs in the end.
         

         Time Complexity:  O(n log(n)) // There are two operations involved. Sorting using quick sort which has n log(n) complexity
                                        // and then simple iteration. So effectively it is n log(n) + n
         Space Complexity: O(n) 
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        var arr_temp = Console.ReadLine().Split(' ');
        var k = int.Parse(arr_temp[1]);
        var pairCount = 0;
        arr_temp = Console.ReadLine().Split(' ');
        var numberArr = Array.ConvertAll(arr_temp, int.Parse);

        //sort the array: Contributes O(nlog(n))
        numberArr = QuickSort2(numberArr);

        //two pointer technique
        var pointer1 = 0;
        var pointer2 = 1;

        while (pointer2 < numberArr.Length)//pointer1 < pointer2 &&
        {
            if (numberArr[pointer2] - numberArr[pointer1] == k)
            {
                pairCount++;
                pointer1++;
                continue;
            }

            if (numberArr[pointer2] - numberArr[pointer1] < k)
            {
                pointer2++;
                continue;
            }

            if (numberArr[pointer2] - numberArr[pointer1] > k)
            {
                pointer1++;
                continue;
            }
        }
        Console.WriteLine(pairCount);
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