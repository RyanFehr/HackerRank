//Problem: https://www.hackerrank.com/challenges/repeated-string
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String s = in.next();
        long n = in.nextLong();
        
        long countForSubstring = 0;
        long totalCount = 0;
        
        //Determines how many a's are in a substring
        for(int i = 0; i < s.length(); i++)
        {
            if(s.charAt(i) == 'a')
            {
                countForSubstring++;
            }
        }
        
        
        //Determines how many complete substrings we will analyze
        long divisor = n / s.length();
        
        totalCount += divisor * countForSubstring;
        
        
        //Determines how many characters in we will analyze towards the end of our n range
        long remainder = n % s.length();
        
        for(int i = 0; i < remainder; i++)
        {
            if(s.charAt(i) == 'a')
            {
                totalCount++;
            }
        }
        
        System.out.println(totalCount);
    }
}
