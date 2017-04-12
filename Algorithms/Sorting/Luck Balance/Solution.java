//Problem: https://www.hackerrank.com/challenges/luck-balance
//Java 8
/*
Initial Thoughts:
We should automatically lose all unimportant contest
to increase our rating, and then we should lose the
k highest luck contests. The sum of all these contests
will give us the maximum luck we can achieve before 
the competition

To do this, we would need to sort the important contest
by their luck descending and add the first k and subtract
the rest

Time Complexity: O(n log(n)) //We have to sort the important contest then do n iterations
Space Complexity: O(1) //Considering the inputs as given

*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution { 
    
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        ///////Variables//////
        int n = input.nextInt();
        int k = input.nextInt();
        int maxLuck = 0;
        ArrayList<Integer> importantContests = new ArrayList<>();
        //////////////////////
        
        //Build list of important contests
        for(int i = 0; i < n; i++){
            int luck = input.nextInt();
            int important = input.nextInt();
            
            if(important != 1)
            {
                maxLuck += luck;
            } 
                
            else
                importantContests.add(luck);
        }
        
        //Sort the important contests in descending order
        Collections.sort(importantContests, Collections.reverseOrder());
        
        //Lose the k largest contests and win the rest
        for(int i = 0; i < importantContests.size(); i++){
            if(i < k)
                maxLuck += importantContests.get(i);            
            else
                maxLuck -= importantContests.get(i);                
        }
        
        System.out.println(maxLuck);
    }
}