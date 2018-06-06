/*
         Problem: https://www.hackerrank.com/challenges/insertionsort2/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Let the unsorted array be arr and number of elements in arr be n.
         2. Initialize a counter c with 1.
         3. Start a loop until c < n
             3.1 Let the element to be sorted in current pass is e located at cth index of arr.
             3.2 Initialize a counter j = c-1.
             3.3 Start a loop 
                 3.3.1 if e < arr[j] then set arr[j + 1] = arr[j].
                 3.3.2 if e >= arr[j] then break the loop.
                 3.3.3 decrement j by 1.
                 3.3.4 Keep repeating steps from 3.3.1 through 3.3.3 untill loop breaking condition isn't met.
             3.4 j+1 is the correct position where e needs to be inserted. Replace (j+1)th element of array with e.
             3.5 Increment c by 1.
             3.6 Keep repeating steps from 3.1 through 3.5 untill loop breaking condition isn't met.

         Time Complexity:  O(n^2) //There is a nested loop.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
                
        */
using System;

class Solution
{

    static void Insert(int[] arr, int i)
    {
        var currElement = arr[i];
        var j = i - 1;
        for (; j >= 0; j--)
        {
            if (currElement < arr[j])
                arr[j + 1] = arr[j];
            else
                break;
        }
        arr[j + 1] = currElement;
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. We use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        for (var i = 1; i < arr.Length; i++)
        {
            Insert(arr, i);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
