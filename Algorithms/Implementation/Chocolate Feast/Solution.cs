/*
     Problem: https://www.hackerrank.com/challenges/chocolate-feast/problem
     C# Language Version: 7.0
     .Net Framework Version: 4.7
     Tool Version : Visual Studio Community 2017
     Thoughts :
     1. Let the number of trips to the shop be t.
     2. Start with a loop which runs t times:
        2.1 Let the dollar amount, cost of choclate and wrapper offer in the current trip be n,c and m respectively.
        2.2 Let the running total count of choclates bought in the current trip be cc. 
        2.3 Let the running count of wrappers obtained from the choclates being bought be wc.
        2.3 Initialize cc and wc both to n/c.
        2.4 Now run a loop until the value of wc >= m
            2.4.1 add  the count of choclates bought from the wrappers i.e. wc/m to cc.
            2.4.2 update the count of wrappers with wrappers obtained from next set of choclates along with wrappers
                  which went unused in step 2.4.1
            2.4.3 Continue iterating the steps from 2.4.1 to 2.4.2 until the loop condition is true.
        2.5 print the value of cc on a new line on console.

     Time Complexity:  O(log(n)) //base of logarithm is m. 
                                 // Base of logarithmic time complexity is m as the number of wrappers obtained 
                                 // in first purchase get reduced to n/m in each iteration while getting processed using a loop
     Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.

*/

using System;

class Solution
{
    static void Main(String[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            var tokens_n = Console.ReadLine().Split(' ');
            var n = int.Parse(tokens_n[0]);
            var c = int.Parse(tokens_n[1]);
            var m = int.Parse(tokens_n[2]);

            var totalChoclates = n / c;
            var wrappersFromChoclates = totalChoclates;
            while (wrappersFromChoclates >= m)
            {
                totalChoclates += wrappersFromChoclates / m;
                wrappersFromChoclates = (wrappersFromChoclates / m) + (wrappersFromChoclates % m);//add unused wrappers.
            }
            Console.WriteLine(totalChoclates);
        }
    }
}
