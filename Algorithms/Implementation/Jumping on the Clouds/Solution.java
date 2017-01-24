//Problem: https://www.hackerrank.com/challenges/jumping-on-the-clouds
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int c[] = new int[n];
        for(int c_i=0; c_i < n; c_i++){
            c[c_i] = in.nextInt();
        }
        
        int jumps = 0;
        
        int i = 0;
        while(i < n-3) //goes through all clouds up until the last jump
        {
            i += (c[i+2] == 0) ? 2 : 1;
            jumps++;                
        }
        
        jumps++;//This is the last jump that will be either a 1 or 2
        
        System.out.println(jumps);
    }
}
