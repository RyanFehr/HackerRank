/*
 Problem: https://www.hackerrank.com/challenges/quicksort2
 C# Language Version: 6.0
 .Net Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts :
 1. Let the input array be arr with n elements.
 2. Consider a pivot and set it to 0th element of the array.
 3. Take three lists named sl, el and bl.
 4. Iterate through all elements of arr in a loop
    4.1 If current element is smaller than pivot then add it to sl list.
    4.2 If current element is bigger than pivot then add it to bl list.
    4.3 If current element is equal to pivot then add it to el list.
  5. If total items in sl is greater than 1 then repeat steps from 1 to 4 for sl.
  6. If total items in bl is greater than 1 then repeat steps from 1 to 4 for bl.
  7. Merge all three lists in the order sl,el and bl to create a new array.
  8. Print all the elements of the new array (separated by space) obtained after merge in step 7 above.

Time Complexity:  O(n^2) //worst case scenario - Eventhough there are no nested for loops but there would be n^2 comparisons 
                         //which happens across recursive calls for partitioned arrays.
Space Complexity: O(n) //an additional array of size n is required to stored the output result. We're NOT following in-place
                    //sorting here which modifies the input array.

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int[] QuickSort(int[] arr)
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
            smallerItems = QuickSort(smallerItems.ToArray()).ToList();

        if (biggerItems.Count > 1)
            biggerItems = QuickSort(biggerItems.ToArray()).ToList();

        var j = 0;

        foreach (var item in smallerItems)
        {
            outputArr[j++] = item;
            Console.Write(item);
            Console.Write(' ');
        }

        foreach (var item in equalItems)
        {
            outputArr[j++] = item;
            Console.Write(item);
            Console.Write(' ');
        }

        foreach (var item in biggerItems)
        {
            outputArr[j++] = item;
            Console.Write(item);
            Console.Write(' ');
        }

        Console.WriteLine();
        return outputArr;

    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        QuickSort(arr);
    }
}
