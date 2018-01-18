/*
         Problem: https://www.hackerrank.com/challenges/insertionsort1/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Let the array containing all the sorted elements and one new element e at the end of the array be arr.
         2. let the total number of elements in the array be n.
         3. Initialize a value i = n-1.
         4. Initialize a counter j = 0.
         5. Start a loop to obtain the position where e actually needs to be inserted.
            5.1 if j < i then continue the loop else break it and go to step 6.
            5.2 if e <= arr[j] then break the loop and go to step 6.
            5.3 increment j by 1.
            5.4 Keep repeating steps from 5.1 through 5.3 untill loop breaking condition isn't met.
         6. Now j holds the position where e actually needs to be inserted.
         7. Start a loop for shifting elements towards right to create the void at position j for e to fill in:
            7.1 If i <= j break the loop and go to step 8.
            7.2 set arr[i] = arr[i - 1]
            7.3 decrement i by 1.
            7.4 Print the entire array elements separated by space character.
            7.5 Keep repeating steps from 7.1 through 7.4 untill loop breaking condition isn't met.
         8. Replace jth element of array with e.
         9. Print the entire array elements separated by space character one last time.

         Time Complexity:  O(n) //There are two loops but they aren't nested so complexity will be of order n.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
                
        */

using System;

class Solution
{
    static void InsertionSort(int[] arr)
    {
        var i = arr.Length - 1;
        int currElement = arr[i];
        int j = 0;
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
            Console.WriteLine(String.Join(" ", arr));
        }
        arr[j] = currElement;
        Console.WriteLine(String.Join(" ", arr));
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. I use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);
        InsertionSort(arr);
    }
}
