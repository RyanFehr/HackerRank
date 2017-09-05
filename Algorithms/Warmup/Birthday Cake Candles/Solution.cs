/*
    Problem: https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Store all the candle heights in an array of length n.
    2. Let the height of tallest candle be ht. Set ht to the height of first candle.
    3. Let the count of all the candles having height ht be c. Set c to 1.
    4. Start iterating the candles in a loop starting from second candle.
    4.1 Let the height of next candle be hn.
    4.2 If hn is equal to ht then increment c by 1.
    4.3 If hn is greater than ht then set ht to hn and c to 1.
    4.4 Repeat steps 4.1 through 4.4 for all the candles in the array except the first candle.
    5. Print c on console.

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
        //No need to capture the size of array. I use array's length property instead.
        ReadLine();
        var height_temp = ReadLine().Split(' ');
        var height = Array.ConvertAll(height_temp, int.Parse);
        var maxValue = height[0];
        var maxValueOccurence = 1;

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i] == maxValue)
            {
                maxValueOccurence++;
                continue;
            }
            if (height[i] > maxValue)
            {
                maxValue = height[i];
                maxValueOccurence = 1;
            }
        }
        WriteLine(maxValueOccurence);
    }
}