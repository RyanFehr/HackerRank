//Problem: https://www.hackerrank.com/challenges/two-arrays
//Java 8
/*
Initial Thoughts: We can sort array A ascending and sort
                  array B descending, and then because they
                  are sorted we know that we are matching 
                  the highest possible from B with the lowest 
                  possible from A each time and if 1 of 
                  those fails then we know  it is not 
                  possible. The reason we know this is true 
                  is because they are inversely sorted, so 
                  we have already made the optimal decision 
                  at each stage in terms of the amount of 
                  absolute difference we have 'wasted/extra' 
                  thus leaving us with the tightest bounding
                  number to k for each index.
                  
Optimization: If we want to sort a int array in descending 
              order using the built in libraries, we have to
              change it to an Integer[] which takes up 16 bytes
              per element compared to 4. So instead what we can
              do is sort the int[] ascending and just traverse
              it in reverse when comparing to view the elements
              in descending order
                  
Time Complexity: O(n log(n)) //We must sort the input arrays
Space Complexity: O(n) //We must store the input arrays 

*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int Q = input.nextInt();
        //Store answer to each query
        StringBuilder output = new StringBuilder("");

        queries:
        for(int q = 0; q < Q; q++)
        {
            int n = input.nextInt();
            int k = input.nextInt();
            
            //Initialize Input
            int[] A = new int[n];
            int[] B= new int[n];
            for(int i = 0; i < n; i++)
                A[i] = input.nextInt();
            for(int i = 0; i < n; i++)
                B[i] = input.nextInt();
            
            Arrays.sort(A);//Sort ascending
            Arrays.sort(B);//Sort acending      
          
            for(int i = 0; i < n; i++)
            {
                //Traverse A ascending and B descending
                if(A[i]+B[B.length-1-i] < k) //Failed check
                {
                    output.append("NO\n");
                    continue queries;
                }
            }
            
            //Permutation exist
            output.append("YES\n");
            
        }
        //Print the answers to all queries
        System.out.println(output);
    }
}