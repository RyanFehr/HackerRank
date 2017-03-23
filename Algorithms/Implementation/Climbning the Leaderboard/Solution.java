//Problem: https://www.hackerrank.com/challenges/climbing-the-leaderboard
//Java 8
/*
Initial Thoughts:
We want to build a dense ranking array based on the scores as 
we read them in

Using that and a few pointer variables we can iterate 1 time
over the scores array, advancing  an unknown number of steps
for each score that Alice has. For each score Alice has we 
will update our leaderboard index, which is our regular
ranking and update our rank which is our dense ranking 

Time Complexity: O(n + m) //We only iterate over the scores and alice's scores once
Space Complexity: O(n) //We do not store alice's scores in memory, so our space complexity is just n for storing the scores array
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] scores = new int[n];
        int[] ranks = new int[n]; //The dense ranking of the scores
        
        //Initialize dense ranking and scores
        for(int i=0, rank=1; i < n; i++){
            int s = in.nextInt();
            scores[i] = s;
            if(i > 0 && scores[i-1] != s)
                rank++;
            ranks[i] = rank;    
        }
        
        //Interate over Alice's level scores
        //int level = 0;
        int aliceRank = ranks[ranks.length-1] + 1; //Set it to worst rank+1
        int leaderboardIndex = n-1;
        int m = in.nextInt();
        
        int prevScore = -1; //Last score we saw
        
        for(int aliceScores=0; aliceScores < m; aliceScores++)
        {
            int levelScore = in.nextInt();
        
            //We iterate 1 past the front of the array incase we are greater than the best score
            for(int i = leaderboardIndex; i >= -1; i--)
            {
                if(i < 0 || scores[i] > levelScore)
                {
                    System.out.println(aliceRank);
                    break;
                }
                else if(scores[i] < levelScore)
                {
                    if(scores[i] != prevScore)//We have went up a ranking
                    {
                        aliceRank--;    
                    }
                    leaderboardIndex--;
                }
                else//scores[i] == alice[level]
                {
                    leaderboardIndex--;
                    aliceRank = ranks[i];
                }
                prevScore = scores[i];
            }
        }
    }
}
