//Problem: https://www.hackerrank.com/challenges/apple-and-orange
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int s = in.nextInt();
        int t = in.nextInt();
        int a = in.nextInt();
        int b = in.nextInt();
        int m = in.nextInt();
        int n = in.nextInt();
        int apples = 0;
        int oranges = 0;
        
        for(int i = 0; i < m; i++)
        {
            int landingSpot = in.nextInt() + a;
            if(landingSpot >= s && landingSpot <= t)
            {
                apples++;
            }
            
        }
        
        for(int i = 0; i < n; i++)
        {
            int landingSpot = in.nextInt() + b;
            if(landingSpot >= s && landingSpot <= t)
            {
                oranges++;
            }
        }
        System.out.println(apples);
        System.out.println(oranges);
    }
}
