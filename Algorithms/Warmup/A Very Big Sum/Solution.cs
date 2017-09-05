/*
    Problem: https://www.hackerrank.com/challenges/a-very-big-sum/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Store all the input numbers in an array of size n.
    2. Let the sum of all the input numbers be s. Initialize s to 0. Ensure that storage width of the data type of s is 64 bit.
    3. Start iterating the elments of an array in a loop
    3.1 Let the current element be c.
    3.2 Increment s by c.
    3.3 Move to next element in the array and repeat steps 3.1 through 3.2.
    4. Print s.

    Time Complexity:  O(n) //A loop is required which iterates through n elements in the array to create their sum.
    Space Complexity: O(n) //Space complexity doesn't  matches optimal O(1) solution as in C# you have to read the entire console line at a time (size n) 
                            because it does not have a way to iteratively read space delimited input. If there had been a Scanner like class which exists in Java 
                            then it would have been possible to accomplish the same algorithm in O(1) space complexity.
*/

using System;
class Solution
{
    static void Main(String[] args)
    {
        var finalSum = 0L;
        var n = int.Parse(Console.ReadLine());
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, long.Parse);

        for (int i = 0; i < n; i++)
            finalSum += ar[i];

        Console.WriteLine(finalSum);
    }
}