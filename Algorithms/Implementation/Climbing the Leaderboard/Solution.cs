/*
 Problem: https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.5.2
 Thoughts :
 1. Get an array of n player scores. Iterate through all player scores and create a new array 
    which doesn't contain any repeated player scores. Let us call the new array, playerScores.
 2. Let total levels to be played by Alice is m.
 3. Let Alice's score after first round be S.
 4. Let Alice's initial rank R be 0.
 5. Start iterating playerScores array from the rear end untill you get a player score whose score is less than S.
 6. Set R to rank of the player found in step 5.
 7. Reduce m by 1.
 8. Print R.
 9. Now start processing Alice's score in all subsequent levels inside a loop
    9.1 Set S to Alice's next level score.
    9.2 Start iterating playerScores array from the player whose rank is R-1 towards the front end.
    9.3 Continue iteration untill you get a player whose score is less than S.
    9.4 Set R to rank of the player found in above step.
    9.5 Reduce m by 1.
    9.6 Print R.
    9.7 Go to step 9.1 if there are more levels left to be played (i. e m>0).

 Time Complexity:  O(n+m) - One scan required to get non-duplicate scores (n). m iterations required to decide
                        Alice's rank after each level.
 Space Complexity: O(n) - An additional array for entire input set is required to store non-duplicate scores.
        
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
       
        Console.ReadLine();
            var scores_temp = Console.ReadLine().Split(' ');
            var playerScoresWithRepeats = Array.ConvertAll(scores_temp, long.Parse);
            var playerScores = new long[playerScoresWithRepeats.Length];
            playerScores[0] = playerScoresWithRepeats[0];
            int k = 0;
            for (int j = 1; j < playerScoresWithRepeats.Length; j++)
            {
                if (playerScoresWithRepeats[j] < playerScores[k])
                {
                    playerScores[++k] = playerScoresWithRepeats[j];
                }
            }

            var totalLevelsToPlay = int.Parse( Console.ReadLine());
            var alice_temp = Console.ReadLine().Split(' ');
            var aliceScores = Array.ConvertAll(alice_temp, long.Parse);


            var currentRoundRank = 0;
            var aliceScoreIndex = 0;
            var nextAliceScore = aliceScores[aliceScoreIndex];

            if (nextAliceScore < playerScores[playerScores.Length - 1])
            {
                currentRoundRank = playerScores.Length + 1;
            }
            else
            {
                for (int i = 0; i < playerScores.Length; i++)
                {
                    if (nextAliceScore >= playerScores[i])
                    {
                        currentRoundRank++;
                        break;
                    }
                    currentRoundRank++;
                }
            }
            totalLevelsToPlay--;
            Console.WriteLine(currentRoundRank);



            while (totalLevelsToPlay > 0)
            {
                nextAliceScore = aliceScores[++aliceScoreIndex];
                var temp = currentRoundRank - 2;

                while (temp > -1)
                {
                    var nextHigherRankedPlayerScore = playerScores[temp--];
                    if (nextAliceScore >= nextHigherRankedPlayerScore)
                    {
                        currentRoundRank--;
                        continue;
                    }
                    else
                        break;
                }
                Console.WriteLine(currentRoundRank);
                totalLevelsToPlay--;
            }
        
    }
}


