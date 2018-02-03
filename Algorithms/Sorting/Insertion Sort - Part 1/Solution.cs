/*
         Problem: https://www.hackerrank.com/challenges/insertionsort1/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Let the array containing all the sorted elements and one new element e at the end of the array be arr.
         2. let the total number of elements in the array be n.
         3. Initialize a value i = n-1.
         4. Initialize a counter j = i-1.
         5. Start a loop 
            5.1 if e < arr[j] then set arr[j + 1] = arr[j] and print the entire array elements separated by space character.
            5.2 if e >= arr[j] then break the loop.
            5.3 Decrement j by 1.
            5.4 Break the loop if j < 0.
            5.3 Keep repeating steps from 5.1 through 5.4 untill loop breaking condition isn't met.
         6. j+1 is the correct position where e needs to be inserted. Replace (j+1)th element of array with e.
         7. Print the entire array elements separated by space character one last time.

         Time Complexity:  O(n) //There is only one loop.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
                
        */

using System;

class Solution
{

    static void InsertionSort(int[] arr)
    {
        var i = arr.Length - 1;
        var currElement = arr[i];
        var j = i - 1;
        for (; j >= 0; j--)
        {
            if (currElement < arr[j])
            {
                arr[j + 1] = arr[j];
                Console.WriteLine(String.Join(" ", arr));
            }
            else
                break;
        }

        arr[j + 1] = currElement;
        Console.WriteLine(String.Join(" ", arr));
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. We use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        InsertionSort(arr);
    }
}