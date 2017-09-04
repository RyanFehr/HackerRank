/*
    Problem: https://www.hackerrank.com/challenges/compare-the-triplets/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let Alice's triple score be a0,a1,a2.
    2. Let Bob's triple score be b0,b1,b2.
    3. Let Alice's and Bob's total rating points be ta and tb respectively. Set ta and tb to 0.
    4. If a0 > b0 then ta by 1.
    5. If b0 > a0 then tb by 1.
    6. If a1 > b1 then ta by 1.
    7. If b1 > a1 then tb by 1.
    8. If a2 > b2 then ta by 1.
    9. If b2 > a2 then tb by 1.
    10. Print ta and tb on console separated by space.

    Time Complexity:  O(1) //There are no iteration loops in the algorithm steps.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
                
*/

using System;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_a0 = Console.ReadLine().Split(' ');
        var a0 = int.Parse(tokens_a0[0]);
        var a1 = int.Parse(tokens_a0[1]);
        var a2 = int.Parse(tokens_a0[2]);
        var tokens_b0 = Console.ReadLine().Split(' ');
        var b0 = int.Parse(tokens_b0[0]);
        var b1 = int.Parse(tokens_b0[1]);
        var b2 = int.Parse(tokens_b0[2]);

        int aliceTotalScore = 0;
        int bobTotalScore = 0;
        if (a0 > b0)
            aliceTotalScore++;
        else if (b0 > a0)
            bobTotalScore++;

        if (a1 > b1)
            aliceTotalScore++;
        else if (b1 > a1)
            bobTotalScore++;

        if (a2 > b2)
            aliceTotalScore++;
        else if (b2 > a2)
            bobTotalScore++;

        Console.WriteLine(aliceTotalScore + " " + bobTotalScore);
    }
}