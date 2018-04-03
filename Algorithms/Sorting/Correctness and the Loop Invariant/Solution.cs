/*
         Problem: https://www.hackerrank.com/challenges/correctness-invariant/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :

         This was the same insertion sort problem present at below url:

         https://www.hackerrank.com/challenges/insertionsort2/problem

         The only difference was that there was a bug left deliberately in the provided code for the students to figure out.
         The bug was in the boolean condition used in nested while loop in InsertionSort method.
         In order to be a correct algorithm, the condition j > 0 && value < A[j] should have been j >= 0 && value < A[j].

         
         From algorithm stand-point the steps remain same as for insertion sort.

         Time Complexity:  O(n^2) //There is a nested loop.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
                
           
        */

using System;
using System.Linq;

class Solution
{
    public static void InsertionSort(int[] A)
    {
        var j = 0;
        for (var i = 1; i < A.Length; i++)
        {
            var value = A[i];
            j = i - 1;
            //below loop condition was buggy which had to be fixed.
            while (j >= 0 && value < A[j])
            {
                A[j + 1] = A[j];
                j = j - 1;
            }
            A[j + 1] = value;
        }
        Console.WriteLine(string.Join(" ", A));
    }

    static void Main(string[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        InsertionSort(arr);
    }
}
