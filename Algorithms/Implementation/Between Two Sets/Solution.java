//Problem: https://www.hackerrank.com/challenges/between-two-sets
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
        int m = in.nextInt();
        int maxA = 0;
        int minB = 101;
        
        int[] a = new int[n];
        for(int a_i=0; a_i < n; a_i++){
            int tmp = in.nextInt();
            maxA = tmp > maxA ? tmp:maxA;
            a[a_i] = tmp;
        }
        int[] b = new int[m];
        for(int b_i=0; b_i < m; b_i++){
            int tmp = in.nextInt();
            minB = tmp < minB ? tmp:minB;
            b[b_i] = tmp;
        }        
        
        int integersBetween = 0;
        
        intCheck: 
        for(int i = maxA; i <= minB; i += maxA)
        {
            //Check if all A are a factor of i
            for(int num : a)
            {
                if(i%num != 0)
                {
                    continue intCheck;
                }
            }
            
            //Check if i is a factor of all B
            for(int num : b)
            {
                if(num%i != 0)
                {
                    continue intCheck;
                }
            }
            integersBetween++;
        }
        System.out.println(integersBetween);
    }
}
