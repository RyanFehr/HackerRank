/*
         Problem: https://www.hackerrank.com/challenges/halloween-sale/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
         - If you look at sample input 0 : p=20,d=3,m=6,s=80

                                            Until this point it is an A.P. series with negative value of interval
                                                                ↓
          The games being bought are as follows - 20,17,14,11,8,6,6,6,6,6,6

         So the series of game costs when till the point when it hits the minimum possible cost of game (6), it actually forms an arithmetic progression series.
         Once the A.P. series ends we need to check the possibility of buying more games of equal cost by division.

         Gotchas:
            <None>

         Time Complexity:  O(1) //There are no loops.
         Space Complexity: O(1) //Constant space requirement.
         
        */
using System;

class Solution
{

    static void Main(string[] args)
    {
        var totalGamesBought = 0;
        var inputSplits = Console.ReadLine().Split(' ');
        var priceOfGame = int.Parse(inputSplits[0]);
        var discount = int.Parse(inputSplits[1]);
        var minimumCost = int.Parse(inputSplits[2]);
        var sumOfMoney = int.Parse(inputSplits[3]);

        if (sumOfMoney < priceOfGame)
            Console.WriteLine(0);
        else
        {
            totalGamesBought = 1 + (priceOfGame - minimumCost) / discount;
            var t = totalGamesBought * (2 * priceOfGame - (totalGamesBought - 1) * discount) / 2;
            if (sumOfMoney >= t)
                totalGamesBought += (sumOfMoney - t) / minimumCost;
            else
            {
                var b = 2 * priceOfGame + discount;
                totalGamesBought = (int)((b - Math.Sqrt(b * b - 8 * discount * sumOfMoney)) / (2 * discount));
            }
            Console.WriteLine(totalGamesBought);
        }
    }
}
