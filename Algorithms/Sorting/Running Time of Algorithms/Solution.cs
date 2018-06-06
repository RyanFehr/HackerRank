/*
          Problem: https://www.hackerrank.com/challenges/runningtime/problem
          C# Language Version: 7.0
          .Net Framework Version: 4.7
          Tool Version : Visual Studio Community 2017
          Thoughts :
 
          This was same as insertion sort problem present at below url:
 
          https://www.hackerrank.com/challenges/insertionsort2/problem
 
          The only additional thing required in here was to maintain a count whenever a shifting took place. I achieved it using a
          counter in the nested loop.
 
          
          From algorithm stand-point the steps remain same as for insertion sort.
 
          Time Complexity:  O(n^2) //There is a nested loop.
          Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
         

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int runningTime(int[] A)
    {
        var shiftCount = 0;
        var j = 0;
        for (var i = 1; i < A.Length; i++)
        {
            var value = A[i];
            j = i - 1;
            while (j >= 0 && value < A[j])
            {
                A[j + 1] = A[j];
                shiftCount++;
                j = j - 1;
            }
            A[j + 1] = value;
        }
        return shiftCount;
    }

    static void Main(String[] args)
    {
        //no need of count of elements as we use array's length property.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var result = runningTime(arr);
        Console.WriteLine(result);
    }
}
