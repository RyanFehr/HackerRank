/*
 Problem: https://www.hackerrank.com/challenges/kaprekar-numbers/problem
 C# Language Version: 7.0
 .Net Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts :
 1. Let the input range of numbers be p and q
 2. Start iterating the numbers starting from p until q in a loop
    2.1 Let the current number being iterated is n.
    2.2 Let the number of digits in n is d.
    2.3 Calculate the square of n as n * n. Let the square value be s.
    2.4 Divide s into two numbers s1 and s2 such that s1 gets d right most digits of s and s2 gets remaining digits of s.
    2.5 If sum of s1 and s2 is equal to n then n is a kaprekar number, so print n followed by a space.
 3. If not even a single Kaprekar number was found in step 2 above then print "INVALID RANGE".
 
 Time Complexity:  O(n)
 Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
 
*/

using System;

class Solution
{
    static void Main(String[] args)
    {

        var rangeP = long.Parse(Console.ReadLine());
        var rangeQ = long.Parse(Console.ReadLine());
        var printInvalidRange = true;
        for (var n = rangeP; n <= rangeQ; n++)
        {
            var kaprekarNumberFound = false;
            var square = n * n;
            var digitCount = n.ToString().Length;
            var strVal = square.ToString();

            var rPiece = long.Parse(strVal.Substring(strVal.Length - digitCount));
            long lPiece = 0;
            if (strVal.Length - digitCount > 0)
                lPiece = long.Parse(strVal.Substring(0, strVal.Length - digitCount));

            if (rPiece + lPiece == n)
            {
                Console.Write(n);
                kaprekarNumberFound = true;
                printInvalidRange = false;
            }

            if (kaprekarNumberFound)
                Console.Write(' ');
        }

        if (printInvalidRange)
            Console.WriteLine("INVALID RANGE");
    }
}