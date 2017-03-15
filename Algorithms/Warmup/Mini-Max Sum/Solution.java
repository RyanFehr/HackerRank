//Problem: https://www.hackerrank.com/challenges/mini-max-sum
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        
        long min = Long.MAX_VALUE;
        long max = 0;
        long sum = 0;
        for(int i=0; i<5; i++)
        {
            long curr = in.nextLong();  
            if(max < curr)
            {
                max = curr;
            }
            if(min > curr)
            {
                min = curr;
            }
            
            sum += curr;
        }
        long minSum = sum - max;//Removes the largest of the 5 numbers to get the min sum
        long maxSum = sum - min;//Removes the smallest of the 5 numbers to get the max sum
        System.out.println(minSum + " " + maxSum);
    }
}
