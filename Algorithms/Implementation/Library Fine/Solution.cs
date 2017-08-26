/*
    Problem: https://www.hackerrank.com/challenges/library-fine/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Initialize fine to 0
    2. Get the user input for year, month and day component of actual return date as ya,ma and da
    3. Get the user input for year, month and day component of expected return date as ye,me and de
    4. if ya > ye then set fine to 10000
    5. if ya == ye and ma > me then set fine to 500 * (ma - me)
    6. if ya == ye and ma == me and da > de then set fine to 15 * (da - de)
    7. print fine

    Time Complexity:  O(1) //There are no loops in algorithm steps.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
                
*/

using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_d1 = Console.ReadLine().Split(' ');
        var actualDay = int.Parse(tokens_d1[0]);
        var actualMonth = int.Parse(tokens_d1[1]);
        var actualYear = int.Parse(tokens_d1[2]);
        var tokens_d2 = Console.ReadLine().Split(' ');
        var expectedDay = int.Parse(tokens_d2[0]);
        var expectedMonth = int.Parse(tokens_d2[1]);
        var expectedYear = int.Parse(tokens_d2[2]);
        var fine = 0;

        if (actualYear > expectedYear)
            fine = 10000;
        else if (actualYear == expectedYear)
        {
            if (actualMonth > expectedMonth)
                fine = 500 * (actualMonth - expectedMonth);
            else
            {
                if (actualMonth == expectedMonth)
                {
                    if (actualDay > expectedDay)
                        fine = 15 * (actualDay - expectedDay);
                }
            }
        }
        WriteLine(fine);
    }
}