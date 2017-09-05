/*
    Problem: https://www.hackerrank.com/challenges/bon-appetit/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let all the food item bills are stored in an array arr of length n.
    2. Let Anna's allergic food index be k.
    3. Let Brian asked Anna to give m amount after sharing the final bill.
    5. Let total bill which should be shared between Brian and Anna be st. Initialize st with 0.
    6. Iterate through the array of food bills in a loop.
        6.1 Let the loop iteration counter be i.
        6.2 Let the current food bill be b.
        6.3 If i doesn't equal to k then increment st by b.
        6.4 Repeat steps 6.1 through 6.3 for all the food bills in array arr.
    7. If st/2 is equal to m then print "Bon Appetit".
    8. If st/2 is not equal to m then print the differnce of st/2 and m.

    Time Complexity:  O(n)
    Space Complexity: O(n) //Space complexity doesn't  match the optimal O(1) solution as in C# you have to read the entire console line at a time (size n), 
                    as it doesn't have a way to iteratively read in space delimited input. If there had been a Scanner like class which exists in Java 
                    then it would have been possible to accomplish the same algorithm in O(1) space complexity.
                
*/
using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_n = ReadLine().Split(' ');
        var k = int.Parse(tokens_n[1]);
        var ar_temp = ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        var billChargedToAnna = int.Parse(ReadLine());
        WriteLine(BonAppetit(k, billChargedToAnna, ar));
    }

    static string BonAppetit(int allergicFoodIndex, int annasChargedBill, int[] ar)
    {
        var sharedFoodItemsBill = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if (i != allergicFoodIndex)
                sharedFoodItemsBill += ar[i];
        }

        var annasShare = sharedFoodItemsBill / 2;
        return annasChargedBill == annasShare ? "Bon Appetit" : (annasChargedBill - annasShare).ToString();
    }
}