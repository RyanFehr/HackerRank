/*
         Problem: https://www.hackerrank.com/challenges/find-the-median/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Let the input array be arr.
         2. Let the index of left most element be l, right most element be r and median index to be searched is m.
         3. Take the element at position l as pivot and create left and right partitions using in-place Lomuto Partitioning method.
         4. Check if m will be in left partition index range, right partition index range or is equal to the pivot index itself.
         5. If m is not equal to pivot index then go into appropriate partition and keep repeating the steps 2-4 until pivot index
            matches with m.
         6. Print the element at pivot index.

         Time Complexity:  O(nlogn) //for quickSelect algorithm as we keep ignoring one partition which doesn't contain our index.
         Space Complexity: O(n) //The entire input need to be stored in an array for applying in-place quickSelect algorithm of
                                //kth order statistics
                
*/

using System;

class Solution
{
    static int FindMedian(int[] arr, int leftBound, int rightBound, int medianIndex)
    {
        int index = Partition(arr, leftBound, rightBound);

        if (index - leftBound == medianIndex)
            return arr[index];

        // If position is more, recur 
        // for left subarray
        if (index - leftBound > medianIndex - 1)
            return FindMedian(arr, leftBound, index - 1, medianIndex);

        // Else recur for right subarray
        return FindMedian(arr, index + 1, rightBound, medianIndex - index + leftBound - 1);

    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var k = arr.Length / 2;
        var result = FindMedian(arr, 0, arr.Length - 1, k++);
        Console.WriteLine(result);
    }

    //in-place partitioning using Lomuto Partitioning method used in in-place quick sort
    static int Partition(int[] arr, int leftBound, int rightBound)
    {
        var pivot = arr[rightBound];
        var indexOfPivot = leftBound;
        for (var j = leftBound; j <= rightBound - 1; j++)
        {
            if (arr[j] <= pivot)
            {
                Swap(arr, indexOfPivot, j);
                indexOfPivot++;
            }
        }
        Swap(arr, indexOfPivot, rightBound);
        return indexOfPivot;
    }

    static void Swap(int[] arr, int index1, int index2)
    {
        var temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
}