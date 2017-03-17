//Problem: https://www.hackerrank.com/challenges/breaking-best-and-worst-records
//Java 8
/*
Initial Thoughts:
We can keep a running min and running max
and update separate variables when either
one is updated

Time Complexity: O(n) //We have to look at every score
Space Complexity: O(1) //We don't have any dynamically sized variables
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt(); //Number of scores
        
        int high = in.nextInt();
        int low = high;
        int highRecordsBroken = 0;
        int lowRecordsBroken = 0;
        
        for(int score=1; score < n; score++){
            int s = in.nextInt();
            
            if(s > high){
                high = s;
                highRecordsBroken++;
            }
            
            if(s < low){
                low = s;
                lowRecordsBroken++;
            }
        }
        System.out.println(highRecordsBroken + " " + lowRecordsBroken);
    }
}
