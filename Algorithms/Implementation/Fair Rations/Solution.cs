/*
         Problem: https://www.hackerrank.com/challenges/fair-rations/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :

         - Main deciding factor is whether the sum of all the initial loaf bread counts is even or odd. If it is
           even then it is possible else print NO.
         - Keep a count of distributed breads. While iterating the array, bump up the count of distributed breads by 2 every time you encounter an odd number of bread possessed by a person.

         Time Complexity:  O(n) //single iteratio of entire array is required.
         Space Complexity: O(1) //optimal solution
                           O(n) //We're storing the initial bread distribution in an array. Space complexity can't  match the optimal O(1) solution as in C# you have to read the entire console line at a time (size n). 
                                There is no way to iteratively read space delimited input. If there had been a Scanner like class which exists in Java then it would have been possible to accomplish the same algorithm in O(1) space complexity.
                                
             
         
*/
using System;

class Solution
{
    static void FairRations(int[] B)
    {
        var sum = 0;
        var count = 0;
        for (var i = 0; i < B.Length; i++)
        {
            sum += B[i];
            if (sum % 2 == 1)
                count += 2;
        }
        Console.WriteLine(sum % 2 == 0 ? count.ToString() : "NO");
    }

    static void Main(String[] args)
    {
        //No need to capture the count. We can use array's length property instead.
        Console.ReadLine();
        var tempArray = Console.ReadLine().Split(' ');
        var breadLovesDistribution = Array.ConvertAll(tempArray, int.Parse);
        FairRations(breadLovesDistribution);
    }
}
