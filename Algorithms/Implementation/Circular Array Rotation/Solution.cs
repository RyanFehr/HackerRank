/*
 Problem: https://www.hackerrank.com/challenges/circular-array-rotation/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.5.2
 Thoughts :
 1. Let there be n numbers in an array a.
 2. Let total number of rotations be k.
 3. Get effective number of rotations using modulus. Let it be effectiveK. Set effectiveK to k % n.
 4. Start iterating each query index one by one
        4.1 Let query index be m
        4.2 Subtract effective k from m to get original position of the element . Let's call it origP.
        4.3 If origP is 0 or positive then print a[origP]
        4.4 If origP is negative the print a[origP + n]

 Time Complexity:  O(m) //m is number of queries
 Space Complexity: O(1) //number of dynamically allocated variables remain constant with increasing number of elements or queries.
        
*/

using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        var numberOfElements = int.Parse(tokens_n[0]);
        var numberOfRotations = int.Parse(tokens_n[1]);
        //after every n rotations every element will come back to its original position which results in no movement.
        //Remainder operator tells the precise movement.
        var effectiveRotations = numberOfRotations % numberOfElements;
        var numberOfQueries = int.Parse(tokens_n[2]);
        var a_temp = Console.ReadLine().Split(' ');
        var inputNumbers = Array.ConvertAll(a_temp, Int32.Parse);

        for (int a0 = 0; a0 < numberOfQueries; a0++)
        {
            var m = int.Parse(Console.ReadLine());
            //get the original position of the element before movement
            var originalPosition = m - effectiveRotations;

            if (originalPosition >= 0)
                Console.WriteLine(inputNumbers[originalPosition]);
            else //this means element must have got wrapped to the other end
                Console.WriteLine(inputNumbers[originalPosition + numberOfElements]);
        }
    }
}
