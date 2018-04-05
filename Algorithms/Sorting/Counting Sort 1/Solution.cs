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
            

         Time Complexity:  O(n+k) // there is one for loop which runs n times. 
                                // The second loop used for printing the elements of arroutput runs 100 (= k) times irrespective of input size.
         
         Space Complexity: O(k) //the additional array of size 100 (= k) is required to store the frequency of each number (from 0-99) in the input list. 
        
                  
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
