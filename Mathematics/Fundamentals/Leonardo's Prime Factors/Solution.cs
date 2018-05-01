/*
         Problem: https://www.hackerrank.com/challenges/leonardo-and-prime/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         - Solution is based on the constraint 1 <= n <= 10^18
         - Initially we create an array containing all prime numbers till when the product of all the numbers in the array crosses 10^18
         - Initial array is { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53 }
         - Then simply start iterating the array and create product of all previous elements till the element being iterated. Print each product during iteration

         Time Complexity:  O(1) There is a while loop (while executing each test case) but under given constraints the loop will always run a maximum of 16 times (i.e. the number of elements
                                in the array) which is a constant.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
         
*/

using System;

class Solution
{
    static void Main(String[] args)
    {
        var numberOfQueries = int.Parse(Console.ReadLine());
        ulong[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53 };
        for (int i = 0; i < numberOfQueries; i++)
        {
            var inputNumber = ulong.Parse(Console.ReadLine());
            var primeMultiplier = 1UL;
            var primeNumberIndex = 0;
            while (true)
            {
                primeMultiplier *= primes[primeNumberIndex++];
                if (primeMultiplier <= inputNumber)
                    continue;
                else
                    break;
            }
            Console.WriteLine(primeNumberIndex - 1);
        }
    }
}