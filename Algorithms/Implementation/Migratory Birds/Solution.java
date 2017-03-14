//Problem: https://www.hackerrank.com/challenges/migratory-birds
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
        int[] types = new int[5];
        for(int types_i=0; types_i < n; types_i++){
            int type = in.nextInt()-1; 
            types[type] = types[type] +1;
        }
        
        int max = 0, index = 0;
        for(int i = 0; i < 5; i++)
        {
            if(types[i] > max)
            {
                max = types[i]; 
                index = i;
            }
        }
            
        
        System.out.println(index+1);
    }
}
