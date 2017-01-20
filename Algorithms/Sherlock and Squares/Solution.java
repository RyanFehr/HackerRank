//Problem: https://www.hackerrank.com/challenges/sherlock-and-squares
//Java 8
import java.io.*;
import java.util.*;
import java.lang.Math;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        
        for(int i = 0; i < T; i++)
        {
            int A = input.nextInt();
            int B = input.nextInt();
                        
            
            int start = (int) Math.sqrt(A); //Finds our starting squareInteger
            int end = (int) Math.sqrt(B);   //Finds our ending squareInteger
            
            int squareIntegers = end-start; //Calculates the squareIntegers between them
            
            squareIntegers += (Math.pow(start,2) >= A) ? 1 : 0; //Checks to make sure we didn't forget one when we floored A
            
            System.out.println(squareIntegers);
        }
    }
}