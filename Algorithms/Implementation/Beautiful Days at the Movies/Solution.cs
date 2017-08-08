/*
 Problem: https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.5.2
 Thoughts :

 1. Get i,j,k
 2. Initialize a counter bDays to 0
 3. Initialize a counter c to i. Start a for loop using counter c until c is less than j. 
    - Get the absolute difference of i and the number formed by reversing the digits of i. Let the absolute difference be d.
    - Get the remainder r when d is divided by k.
    - If k is zero then increment bDays by 1.
    - Increment c by 1.
    - Continue loop until loop termination condition is met.
 4. Print bDays.

 Time Complexity:  O(n) //Absolutely speaking the loop runs i-j times. But O(i-j) is equivalent of O(i)
 Space Complexity: O(1) //dynamically allocated variables will remain same irrespective of input.
        
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        var userInput = Console.ReadLine().Split();
        var i = int.Parse(userInput[0]);
        var j = int.Parse(userInput[1]);
        var k = int.Parse(userInput[2]);
        var bDays = 0;

        for (int c = i; c <= j; c++)
        {
            var reverseString = new string(c.ToString().Reverse().ToArray());
            var reverseNumber = int.Parse(reverseString);
            var d = Math.Abs(c - reverseNumber);
            var r = d % k;

            if (r == 0)
                bDays++;
        }
        Console.WriteLine(bDays);

    }
}