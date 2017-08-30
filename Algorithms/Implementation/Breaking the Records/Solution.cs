/*
Problem: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
C# Language Version: 6.0
.Net Framework Version: 4.7
Tool Version : Visual Studio Community 2017
Thoughts :
1. Let the count of minimum and maximum records broken be cmin and cmax. Initially, set cmin and cmax to 0.
2. If total number of games is 1 then jump to step 4.
3. If total number of games is greater than 1 then a processing is reequired as below:
3.1 Let the mininum and maximum score record be gameMin and gameMax. Set gameMin and gameMax to score of first game.
3.2 Start iterating the scores starting from second game onwards:
    3.2.1 If score of current game is less than gameMin then increment cmin by 1 and set gameMin to current game score.
    3.2.2 If score of current game is greater than gameMax then increment cmax by 1 and set gameMax to current game score.
    3.3.3 Process all the game scores by following steps 3.2.1. through 3.2.2.
4. Print cmin and cmax on same line separated by a space.

Time Complexity:  O(n)
Space Complexity: O(1)
                
        */
using System;

class Solution
{
    static int[] getRecord(int[] gameScores)
    {
        var minRecordBroken = 0;
        var maxRecordBroken = 0;

        if (gameScores.Length > 1)
        {
            var minRecord = gameScores[0];
            var maxRecord = gameScores[0];

            for (int i = 1; i < gameScores.Length; i++)
            {
                if (gameScores[i] < minRecord)
                {
                    minRecord = gameScores[i];
                    minRecordBroken++;
                }

                if (gameScores[i] > maxRecord)
                {
                    maxRecord = gameScores[i];
                    maxRecordBroken++;
                }
            }
        }
        return new int[] { maxRecordBroken, minRecordBroken };
    }

    static void Main(String[] args)
    {
        //No need to capture number of games as I use array's length property to get it.
        Console.ReadLine();
        var s_temp = Console.ReadLine().Split(' ');
        var gameScores = Array.ConvertAll(s_temp, Int32.Parse);
        var result = getRecord(gameScores);
        Console.WriteLine(String.Join(" ", result));
    }
}