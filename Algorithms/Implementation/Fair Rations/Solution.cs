/*
    Problem: https://www.hackerrank.com/challenges/fair-rations/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :


    - Keep a count of distributed breads. 
    - Iterate the entire array except the last element
      - check if the current bread count is odd then add 1 to it also add 1 to subsequent bread count. increment count of distributed breads by 2.
    - If last element of the array is even then print the count of distributed breads.
    - If last element of the array is odd then print "NO".

    Time Complexity:  O(n) //Single iteration of entire array might be required in worst case.
    Space Complexity: O(1) //optimal solution
                    O(n) //We're storing the initial bread distribution in an array. Space complexity can't  match the optimal O(1) solution as in C# you have to read the entire console line at a time (size n). 
                        There is no way to iteratively read space delimited input. If there had been a Scanner like class which exists in Java then it would have been possible to accomplish the same algorithm in O(1) space complexity.
                                
*/
using System;

class Solution
{
    static void FairRations(int[] B)
    {
        var count = 0;
        for (var i = 0; i < B.Length - 1; i++)
        {
            if (B[i] % 2 == 1)
            {
                B[i] += 1;
                B[i + 1] += 1;
                count += 2;
            }

            //improvisation: Keep skipping the next elements if they are even
            while (i < B.Length - 1 && B[i + 1] % 2 == 0)
                i++;
        }

        if (B[B.Length - 1] % 2 == 1)
            Console.WriteLine("NO");
        else
            Console.WriteLine(count.ToString());
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
