/*
         Problem: https://www.hackerrank.com/challenges/countingsort1/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Let the input array be arr with n elements.
         2. Initialize a new array arroutput with 100 elements. Set each element of arroutput to 0.
         3. Iterate through all elements of arr in a loop:
            3.1 Let the current element be e.
            3.2 Increase the value at eth index of arroutput by 1.
         4. Print all the elements of the arroutput (separated by space).
            

         Time Complexity:  O(n) // there is one for loop which runs n times. 
                                // The second loop used for printing the elements of arroutput always runs 100 times irrespective of input size
                                // so it can be ignored.
         
         Space Complexity: O(1) //Space complexity doesn't  match the optimal O(1) solution as in C# you have to read the entire console line at a time (size n), 
                            as it doesn't have a way to iteratively read in space delimited input. If there had been a Scanner like class which exists in Java 
                            then it would have been possible to accomplish the same algorithm in O(1) space complexity.

                            //the additional array of size 100 is required to store the frequency of each number from 0-99. But it is constant
                              w.r.t. changing input so it can be ignored.
        */

using System;
class Solution
{
    static int[] CountingSort(int[] arr)
    {
        var output = new int[100];
        for (int i = 0; i < arr.Length; i++)
            output[arr[i]] += 1;

        return output;
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var result = CountingSort(arr);
        Console.WriteLine(string.Join(" ", result));
    }
}
