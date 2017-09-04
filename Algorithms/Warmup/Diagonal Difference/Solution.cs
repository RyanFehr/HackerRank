/*
    Problem: https://www.hackerrank.com/challenges/diagonal-difference/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the sum of primary and secondary diagonals be p and s. Initialize p and s to 0.
    2. Let the number of rows in the square matrix be n.
    3. Run a for loop with two counters namely i and j initialized to 0 and n-1 respectively. The loop shall run n times.
    3.1 Scan the next row of the matrix anad store it in a one dimensional array. Let it be arr.
    3.2 Increment p with value of arr[i].
    3.3 Increment s with value of arr[j].
    3.4 In every iteration increment i by 1 but decrement j by 1.
    3.5 Perform the operation of steps 3.1 through 3.4 on each row of the matrix.
    4. print the absolute difference of p and s on console. 

    Time Complexity:  O(n) // there is only one for loop which runs n times.
    Space Complexity: O(n) //Space complexity doesn't  match the optimal O(1) solution as in C# you have to read the entire console line at a time (size n), 
                    as it doesn't have a way to iteratively read in space delimited input. If there had been a Scanner like class which exists in Java 
                    then it would have been possible to accomplish the same algorithm in O(1) space complexity.
*/
using System;
using static System.Console;

class Solution
{

    static void Main(String[] args)
    {
        var sumPrimaryDiagonal = 0;
        var sumSecondaryDiagonal = 0;
        var n = int.Parse(ReadLine());
        for (int i = 0, j = n - 1; i < n; i++, j--)
        {
            var a_temp = ReadLine().Split(' ');
            var newRow = Array.ConvertAll(a_temp, int.Parse);
            sumPrimaryDiagonal += newRow[i];
            sumSecondaryDiagonal += newRow[j];
        }
        WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
    }
}