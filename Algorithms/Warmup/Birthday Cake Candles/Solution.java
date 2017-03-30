//Problem: https://www.hackerrank.com/challenges/birthday-cake-candles
//Java 8
/*
Initial Thoughts: 
We can keep a running max and update it if we
find something larger, if we find something smaller
we just keep looking and if we find something equal
then we increment a counter variable

Time Complexity: O(n) //We must check the height of every candle
Space Complexity: O(1) //We only store a max and a frequency
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
        int tallest = 0;
        int frequency = 0;
        
        
        for(int i=0; i < n; i++){
            int height = in.nextInt();
            
            if(height > tallest){
                tallest = height;
                frequency = 1;
            }
            else if(height == tallest) frequency++;
        }
        System.out.println(frequency);
    }
}