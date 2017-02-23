//Problem: https://www.hackerrank.com/challenges/funny-string
//Java 8
/*
Simply use the same string but iterate from
beginning and end
*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        input.nextLine();
        
        tests:
        for(int i = 0; i < T; i++)
        {
            String s = input.nextLine();
            for(int j = 1; j < (s.length()/2)+1; j++)
            {
                int left = Math.abs(s.charAt(j) - s.charAt(j-1));
                int right = Math.abs(s.charAt(s.length()-1-j) - s.charAt(s.length()-j));
                if( left != right)
                {
                    System.out.println("Not Funny");
                    continue tests;
                }
            }
            System.out.println("Funny");
        }
    }
}