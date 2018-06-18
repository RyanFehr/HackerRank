/*
     Problem: https://www.hackerrank.com/challenges/quicksort1/problem
     C# Language Version: 6.0
     .Net Framework Version: 4.7
     Tool Version : Visual Studio Community 2017
     Thoughts :
     1. Let the input array be arr with n elements.
     2. Consider a pivot and set it to 0th element of the array.
     3. Take three lists named ll, el and gl.
     4. Iterate through all elements of arr in a loop
        4.1 If current element is less than pivot then add it to ll list.
        4.2 If current element is greater than pivot then add it to gl list.
        4.3 If current element is equal to pivot then add it to el list.
      5. Merge all three lists in the order ll,el and gl to create a new array.
      6. Print all the elements of the new array (separated by space) obtained after merge in step 5 above.

     Time Complexity:  O(n) //There are no nested loops
     Space Complexity: O(n) //an additional array of size n is required to stored the output result. We're not following in-place
                            //sorting here which modifies the input array.
*/
using System;
using System.Collections.Generic;

class Solution
{
    static int[] QuickSort(int[] arr)
    {
        var pivot = arr[0];
        var lessList = new List<int>();
        var equalList = new List<int>();
        var moreList = new List<int>();
        var outputArr = new int[arr.Length];

        equalList.Add(arr[0]);

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
                lessList.Add(arr[i]);
            else if (arr[i] > pivot)
            {
                moreList.Add(arr[i]);
            }
            else
            {
                equalList.Add(arr[i]);
            }
        }

        var j = 0;

        foreach (var item in lessList)
            outputArr[j++] = item;

        foreach (var item in equalList)
            outputArr[j++] = item;

        foreach (var item in moreList)
            outputArr[j++] = item;


        return outputArr;
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var result = QuickSort(arr);
        Console.WriteLine(string.Join(" ", result));
    }
}
