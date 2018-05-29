/*
        Problem: https://www.hackerrank.com/challenges/big-sorting/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :

        //I was planning to leverage .Net framework's in-built array sorting (which internally uses stable quick sort algorithm) but one test case was still resulting in time-out
        // possibly because conversion of big strings present into integer numbers and then their integer based comparison is very intensive operation.
        // So I decided to use custom comparer to go for strings based sorting instead.

        1. Call Array.Sort (with custom comparer) on the input array containing all the strings.
        2. Print all the sorted array elements on console separated by space.

        Implementation of Compare method in custom comparer:

        1. Let the input strings to be compared are x and y.
        2. If length of string x is less than length of string y then return -1.
        3. If length of string x is more than length of string y then return 1.
        4. If string x and y are exactly same to same same then return 0.
        5. If string x and y are not same but have equal length then initialize a counter c to 0 and start a loop:
            5.1 if x[c] and y[c] are same then increment c by 1.
            5.2 if x[c] and y[c] are not equal then break the loop.
        6. Let the digit present at index c of x and y string be dx and dy respectively.
            6.1. If digit dx is less than dy then return -1.
            6.2. If digit dx is more than dy then return 1.

        Time Complexity:  O(n Log(n)) // .Net framework class library implementation of Array.Sort method uses stable quick sort 
                                         which has n log(n) efficiency.
        Space Complexity: O(n) 

       */
using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var arr = new string[n];
        for (var arr_i = 0; arr_i < n; arr_i++)
            arr[arr_i] = Console.ReadLine();

        Array.Sort(arr, new CustomComparer());
        Console.WriteLine(String.Join("\n", arr));
    }
}

public class CustomComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (x.Length < y.Length)
            return -1;
        else if (x.Length > y.Length)
        {
            return 1;
        }
        else
        {
            if (x == y)
                return 0;
            else
            {
                var i = 0;
                while (x[i] == y[i]) i++;
                return x[i].CompareTo(y[i]);
            }
        }
    }
}
