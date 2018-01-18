/*
         Problem: https://www.hackerrank.com/challenges/insertionsort2/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Let the unsorted array be arr and number of elements in arr be n.
         2. Initialize a counter i with 1.
         3. Start a loop until i < n
             3.1 Let the element to be sorted in current pass is e located at ith index of arr.
             3.2 Initialize a counter j = 0.
             3.3 Start a loop to obtain the position where e actually needs to be inserted.
                 3.3.1 if j < i then continue the loop else break it and go to step 3.4
                 3.3.2 if e <= arr[j] then break the loop and go to step 3.4
                 3.3.3 increment j by 1.
                 3.3.4 Keep repeating steps from 3.3.1 through 3.3.3 untill loop breaking condition isn't met.
             3.4 Now j holds the position where e actually needs to be inserted.
             3.5 Start a loop for shifting elements towards right to create the void at position j for e to fill in:
                 3.5.1 If i <= j break the loop and go to step 3.6
                 3.5.2 set arr[i] = arr[i - 1]
                 3.5.3 decrement i by 1.
                 3.5.4 Keep repeating steps from 3.5.1 through 3.5.3 untill loop breaking condition isn't met.
             3.6 Replace jth element of array with e.
             3.7 Print the entire array elements separated by space character.
             3.8 Keep repeating steps from 3.1 through 3.7 untill loop breaking condition isn't met.

         Time Complexity:  O(n^2) //There is a nested loop.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
                
        */
using System;

class Solution
{
    static void Insert(int[] arr, int i)
    {
        var currElement = arr[i];
        var j = 0;
        for (; j < i; j++)
        {
            if (currElement <= arr[j])
                break;
        }
        //got the position where new element needs to be inserted - j

        // from i to j index shift the elements to right tracking backwards towards left end of the array.
        while (i > j)
        {
            arr[i] = arr[i - 1];
            i--;
        }
        arr[j] = currElement;
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. I use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);
        for (var i = 1; i < arr.Length; i++)
        {
            Insert(arr, i);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
