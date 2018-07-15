/*
         Problem: https://www.hackerrank.com/challenges/marcs-cakewalk/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Main idea is that we've two set of numbers. Let's say:
          Set 1 (Increasing powers of 2) = {1,2,4,8,16....}
          Set 2 (Calorie content in cakes) = {3,1,8,7,200....}
         -  We need to create products of numbers present at same index in two sets and then sum them up.
         -  This sum will be minimum only when we multiply biggest number of set 2 with smallest number of set 1.
         -  That is possible only when we sort Set 2 in decreasing order.
         -  So, sort Set 2 and then create sum of products.


         Gotchas:
         Sorting can be done either via Quick sort or Counting sort (as all the cake calorie counts are in the range 1-1000).
            If we use quick sort to sort calorie counts then time complexity will be O(nlog(n) + n)
            If we use counting sort then time complexity comes down to O(n + k)

         Time Complexity:  O(n + k) //used counting sort to sort the input data of cake calorie counts
         Space Complexity: O(n + k) //we need to store the cake calorie counts in memory to perform sorting.
                                   It is not possible to obtain optimal O(k) space complexity solution as C# language doesn't 
                                   have a Scanner like class (which exists in Java) which can obtain integer inputs one by one on the fly from STDIN.
*/
using System;

class Solution
{
    static void Main(string[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var inputSplits = Console.ReadLine().Split(' ');
        var cakeCalories = Array.ConvertAll(inputSplits, int.Parse);
        cakeCalories = CountingSortMarc(cakeCalories);

        var totalMiles = 0D;
        for (var i = 0; i < cakeCalories.Length; i++)
            totalMiles += Math.Pow(2, i) * cakeCalories[cakeCalories.Length - i - 1];

        Console.WriteLine(totalMiles);
    }

    static int[] CountingSortMarc(int[] inputNumbers)
    {
        var numberFrequency = new int[1000];
        for (var i = 0; i < inputNumbers.Length; i++)
            numberFrequency[inputNumbers[i] - 1] += 1;

        //modify frequency array by adding previous counts cumulatively
        for (var i = 1; i < 1000; i++)
            numberFrequency[i] += numberFrequency[i - 1];

        var sortedOutput = new int[inputNumbers.Length];

        for (var i = 0; i < inputNumbers.Length; i++)
        {
            var num = inputNumbers[i];
            var position = numberFrequency[num - 1];
            numberFrequency[num - 1] -= 1;
            sortedOutput[position - 1] = num;
        }
        return sortedOutput;
    }
}