//Problem: https://www.hackerrank.com/challenges/tutorial-intro
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        
        Scanner input = new Scanner(System.in);
        int V = input.nextInt();
        int n = input.nextInt();
        
        for(int i = 0; i < n; i++)
        {
            if(input.nextInt() == V)
            {
                System.out.println(i);
                System.exit(0);
            }
        }
    }
}