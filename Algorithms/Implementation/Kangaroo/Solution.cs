/*
Problem: https://www.hackerrank.com/challenges/kangaroo/problem
C# Language Version: 6.0
.Net Framework Version: 4.7
Tool Version : Visual Studio Community 2017
Thoughts :
1. Let the location of two kangaroos be x1 and x2 on x-axis. Let their respective rates of movement be v1 and v2.
2. Let the final outcome of jumping activity be o.
3. If x1 < x2 and v1 < v2 then set o to "NO". Jump to step 7.
4. If x2 < x1 and v2 < v1 then set o to "NO". Jump to step 7.
5. If x2 < x1 and v2 > v1 then 
    5.1 Calculate the number of jumps it will be required by second kangaroo to be at spot with first kangaroo.
    5.2 Number of jumps can be obtained by using the formula (x1 - x2) / (v2 - v1).
    5.3 If number of jumps obtained in step 5.2 is a whole number then set o to "YES".
    5.4 If number of jumps obtained in step 5.2 has non-zero fractional part then set o to "NO".
    5.5 Jump to step 7.
6. If x1 < x2 and v1 > v2 then 
    6.1 Calculate the number of jumps it will be required by first kangaroo to be at same spot with second kangaroo.
    6.2 Number of jumps can be obtained by using the formula (x2 - x1)) / (v1 - v2).
    6.3 If number of jumps obtained in step 6.2 is a whole number then set o to "YES".
    6.4 If number of jumps obtained in step 6.2 has non-zero fractional part then set o to "NO".
7. Print o.

Time Complexity:  O(1) //there are no loops in the algorithmic steps.
Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/

using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_x1 = Console.ReadLine().Split(' ');
        var x1 = Convert.ToInt32(tokens_x1[0]);
        var v1 = Convert.ToInt32(tokens_x1[1]);
        var x2 = Convert.ToInt32(tokens_x1[2]);
        var v2 = Convert.ToInt32(tokens_x1[3]);
        var result = kangaroo(x1, v1, x2, v2);
        WriteLine(result);
    }

    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        var sameLocationPossible = "";
        if (x1 < x2 && v1 < v2)
            sameLocationPossible = "NO";

        else if (x2 < x1 && v2 < v1)
            sameLocationPossible = "NO";

        else if (x2 < x1)
        {
            //v2 > v1
            var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        else
        {
            //v1 > v2
            var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        return sameLocationPossible;
    }
}