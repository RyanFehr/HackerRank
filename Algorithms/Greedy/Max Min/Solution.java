//Problem: https://www.hackerrank.com/challenges/angry-children
//Java 8
/*
Initial Thoughts: We since we only care about finding the smallest diff
                  between the min and the max, we can just compare the
                  start and end point of all reasonable pairs. To limit
                  the number of comparisons we make, we can first sort
                  our list that way, we know that all interior elements
                  of the list are also valid. Then we can do a linear
                  check to see what the min diff subarray is.
                  
                  
Time Complexity: O(n log(n)) //We must sort the array
Space Complexity: O(1) //This is if we consider the input as given
*/

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

// The part of the program involving reading from STDIN and writing to STDOUT has been provided by us.

public class Solution {
    
   public static void main(String[] args) throws NumberFormatException, IOException {
       BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
       int N = Integer.parseInt(in.readLine());
       int K = Integer.parseInt(in.readLine());
       int[] list = new int[N];

       for(int i = 0; i < N; i ++)
           list[i] = Integer.parseInt(in.readLine());
      
       int unfairness = Integer.MAX_VALUE;
       
       Arrays.sort(list);//Sorts the list ascending
       for(int i = 0; i < N-K+1; i++)
           unfairness = Math.min(list[i+K-1] - list[i], unfairness);//Keeps a running min of the beginning and end of subarrays
      
       System.out.println(unfairness);
   }
}
