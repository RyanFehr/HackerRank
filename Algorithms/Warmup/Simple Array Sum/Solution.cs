/*
    Problem: https://www.hackerrank.com/challenges/simple-array-sum/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Store all the input numbers in an array. Let there be n elements in the array.
    2. Initialize a number s which represents sum of all the number in the array. Initialize s to 0.
    3. Iterate through all the elements in the array in a loop
        3.1 Let the current number being iterated be c.
        3.2 Increment s by c.
    4. Print s.

    Time Complexity:  O(n)  //A loop is required which iterates through n elements to create their sum.
    Space Complexity: O(n) //Space complexity doesn't  matches optimal O(1) solution as in C# you have to read the entire console line at a time (size n), 
                            because it does not have a way to iteratively read in space delimited input. If there had been a Scanner like class which exists in Java 
                            then it would have been possible to accomplish the same algorithm in O(1) space complexity.
*/

using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        //no need of the element count as I use LINQ to create the sum instead of iterating the array explicitly in my code.
        Console.ReadLine();
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, Int32.Parse);
        Console.WriteLine(ar.Sum()); //LINQ's sum method has O(n) time complexity.
    }
}