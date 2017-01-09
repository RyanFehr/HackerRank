//Problem: https://www.hackerrank.com/challenges/staircase
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        
        StringBuilder stair = new StringBuilder("");
        
        for(int i = 0; i < n; i++)
        {
            stair.append(" ");
        }//Builds the a basic stair with no hashes
        
        for(int i = 1; i< n+1; i++)
        {
            stair.setCharAt(n-i,'#');
            System.out.println(stair);
        }//Makes a longer step each iteration
    }
}