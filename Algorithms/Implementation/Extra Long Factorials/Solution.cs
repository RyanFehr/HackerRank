/*
    Problem: https://www.hackerrank.com/challenges/extra-long-factorials/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the input number be n.
    2. Initialize a big integer number fact to 1.
    3. Start a for loop which runs from 1 to n
    3.1 Let current loop counter be c.
    3.2 set fact = fact * c.
    4. print fact.

    Time Complexity:  O(n)
    Space Complexity: O(1)
                
        */
using System;
using System.Numerics;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var factorial = BigInteger.One;
        for (int i = 1; i <= n; i++)
            factorial = factorial * i;

        Console.WriteLine(factorial);
    }
}