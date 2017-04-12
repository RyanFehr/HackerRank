//Problem: https://www.hackerrank.com/challenges/the-birthday-bar
//Java 8
/*
Initial Thoughts:
We can use a sliding window off size m and 
track its' sum and when it is equal to d we
increment a counter

Time Complexity: O(n) //We must visit every element of the array if m==1
Space Complexity: O(1)//We don't allocate any dynamic space
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static int getWays(int[] squares, int d, int m){
        int ways = 0;
        int sum = 0;
        //Find if there is a way to break the chocolate at all
        if(m <= squares.length) 
            for(int i = 0; i < m; i++)
                sum += squares[i];
        if(sum == d) ways++;
        ///////////////////////////////////////////////////////
            
        //Check other possible ways to break it by using a sliding window
        for(int i = 0; i < squares.length-m; i++)
        {
            sum = sum - squares[i] + squares[i+m];
            if(sum == d) ways++;
        }
        return ways;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] s = new int[n];
        for(int s_i=0; s_i < n; s_i++){
            s[s_i] = in.nextInt();
        }
        int d = in.nextInt();
        int m = in.nextInt();
        int result = getWays(s, d, m);
        System.out.println(result);
    }
}
