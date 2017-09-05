/*
    Problem: https://www.hackerrank.com/challenges/solve-me-first/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the two input nmbers be x and y.
    2. Print the sum of the numbers (x + y) on console.

    Time Complexity:  O(1) //thre are no loops in the algorithm steps.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/
using System;

class Solution
{
    static void Main(String[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(num1 + num2);
    }
}