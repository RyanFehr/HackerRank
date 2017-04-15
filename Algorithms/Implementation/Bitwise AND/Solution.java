//Problem: https://www.hackerrank.com/challenges/linkedin-practice-bitwise-and
//Java 8
/*
Initial Thoughts: We can simple iterate over each element and
                  all the elements to the right of it and check 
                  if it satisfies our condition. 
                  
Optimization: There is a pattern to the highest potential &, so we
              can use this to determine the ma in O(1) time
              
Time Complexity: O(1)
Space Complexity: O(1)
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        for(int t = 0; t < T; t++)
        {
            int max = 0;
            int n = input.nextInt();
            int k = input.nextInt();
            if (((k-1)|k) <= n) System.out.println(k-1);
            else System.out.println(k-2);
            
        }
    }
}