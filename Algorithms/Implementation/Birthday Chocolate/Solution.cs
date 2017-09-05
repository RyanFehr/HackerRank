/*  Problem: https://www.hackerrank.com/challenges/the-birthday-bar/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the values of choclate bar squares are saved in an array of length n.
    2. Let Ron's birthday be bd and birth month be bm.
    3. Let the total possible ways to break the choclate be t. Initialize t to 0.
    4. If bm > n then jump to step 8.
    5. Get the sum of first bm elements of the choclate bar squares array. Let us call the sum, ps.
    6. If ps is equal to bd then increment t by 1.
    7. Starting from second element of the array in a for loop
    7.1 Get the sum of each set of bm elements of the array as a sliding window. Save it in ps.
    7.2 if ps is equal to bd then increment t by 1.
    8. Print t.

    Time Complexity:  O(n) //there is no nested for loop.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input in the method Solve.

*/

using System;
using static System.Console;

class Solution
{

    static void Main(String[] args)
    {
        //No need to capture number of squares in the choclate bar. I use array's length property instead.
        ReadLine();
        var s_temp = Console.ReadLine().Split(' ');
        var choclateBarValues = Array.ConvertAll(s_temp, Int32.Parse);
        var tokens_d = Console.ReadLine().Split(' ');
        var birthday = Convert.ToInt32(tokens_d[0]);
        var birthMonth = Convert.ToInt32(tokens_d[1]);
        var result = Solve(choclateBarValues, birthday, birthMonth);
        WriteLine(result);
    }

    static int Solve(int[] choclateBarValues, int birthday, int birthMonth)
    {
        var totalWays = 0;

        if (choclateBarValues.Length >= birthMonth)
        {
            var barPartSum = 0;
            for (int i = 0; i < birthMonth; i++)
                barPartSum += choclateBarValues[i];

            if (barPartSum == birthday)
                totalWays++;

            for (int i = 0; i < choclateBarValues.Length - birthMonth; i++)
            {
                barPartSum = barPartSum - choclateBarValues[i] + choclateBarValues[i + birthMonth];

                if (barPartSum == birthday)
                    totalWays++;
            }
        }
        return totalWays;
    }
}