/*
 Problem: https://www.hackerrank.com/challenges/strange-code/problem
 C# Language Version: 6.0
 .NET Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts (Key points in algorithm) :
 - If looked careful this then this question involves a G.P. series.
 - let's try to solve it for t = 10 as all other cases are simple.

 It is a G.P. series as shown below:
 3,6,12,24....

 At first we need to know that in which range t (=10) will lie. We employ sum of first n terms of a G.P. series to get
 the desired range.

 Sum of first 1 term = 3 [t won't lie here]
 Sum of first 2 terms = 9 [t won't lie here]
 Sum of first 3 terms = 21 [t lies here]

 So get the second term for G.P. series which is 6. 
 Get the start of next cycle which is 2*6 = 12. 
 Get the value of strange counter at the end of range starting at 6 which is 9.
 Desired value of strange counter at t (= 10) is (12 - (t- 9) + 1)

 Gotchas:
    - t should taken as long data type (64 bit wide). Given range of t in the question is beyond the allowed range of int data type in C#.

 Time Complexity:  O(n)
 Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.

*/

using System;
class Solution
{
    static void Main(string[] args)
    {
        var t = long.Parse(Console.ReadLine());
        var n = 1;
        while (true)
        {
            var sumOfFirstNTerms = 3 * (Math.Pow(2, n) - 1);
            if (sumOfFirstNTerms < t)
            {
                n++;
                continue;
            }
            else if (sumOfFirstNTerms == t)
            {
                Console.WriteLine(1);
                break;
            }
            else
            {
                var termBeforeNthTerm = 3 * Math.Pow(2, n - 2);
                var startOfNextCycle = 2 * termBeforeNthTerm;
                var strangeCounterInEndOfLastCycle = 3 * (Math.Pow(2, n - 1) - 1);
                Console.WriteLine(startOfNextCycle - (t - strangeCounterInEndOfLastCycle) + 1);
                break;
            }
        }
    }
}
