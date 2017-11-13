/*
 Problem: https://www.hackerrank.com/challenges/taum-and-bday/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts:
     1. Start nth test case.
     2. Let the count and cost of black gifts be bcount and bcost respectively.
     3. Let the count and cost of white gifts be wcount and wcost respectively.
     4. Let the cost of conversion be ccost.
     5. If bcost + ccost < wcost then set wcost to (bcost + ccost).
     6. If wcost + ccost < bcost then set bcost to (wcost + ccost).
     7. Print the value (bcount * bcost + wcount * wcost) for current test case.
     8. Repeat steps 2-7 for all each case.

 Time Complexity:  O(1) //there are no loops for a single test case.
 Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/


using System;
using static System.Console;
class Solution
{
    static void Main(String[] args)
    {
        int numberOfTestCases = int.Parse(ReadLine());
        for (int a0 = 0; a0 < numberOfTestCases; a0++)
        {
            var tokens_b = ReadLine().Split(' ');
            var blackGiftsCount = Int64.Parse(tokens_b[0]);
            var whiteGiftsCount = Int64.Parse(tokens_b[1]);
            var tokens_x = ReadLine().Split(' ');
            var costBlackGift = Int64.Parse(tokens_x[0]);
            var costWhiteGift = Int64.Parse(tokens_x[1]);
            var conversionCost = Int64.Parse(tokens_x[2]);

            if (costBlackGift + conversionCost < costWhiteGift)
                costWhiteGift = costBlackGift + conversionCost;
            else if (costWhiteGift + conversionCost < costBlackGift)
                costBlackGift = costWhiteGift + conversionCost;
            WriteLine(blackGiftsCount * costBlackGift + whiteGiftsCount * costWhiteGift);
        }
    }
}
