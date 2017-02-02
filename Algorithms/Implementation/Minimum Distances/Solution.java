//Problem: https://www.hackerrank.com/challenges/minimum-distances
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
        int A[] = new int[n];
        for(int A_i=0; A_i < n; A_i++){
            A[A_i] = in.nextInt();
        }
        
        
        
        /* 
        First Iteration
        
        [7 1 3 4 1 7]
        
        Set _______       runnningMin
            7 : 5 /            3
            1 : 1 
            3 : 3
            4 : 2
            
        
        -store the shortest so far for a pair
        -store the starting point of possible future pairs
        -update start point to the end point if 
        TC: O(n^2) SC: O(n)
        
        
        
        Second Iteration
        
        instead of incrementing our distance each time we move our starting
        point to the right, we are going to just store the index of each value
        
        This is now TC: O(n) SC: O(n)
        
        */
        
        HashMap<Integer,Integer> distances = new HashMap<>();
        
        int minDistance = -1;
        
        for(int i = 0; i < n; i++)
        {
            if(distances.containsKey(A[i]))
            {
                //Calculate distance between like numbers
                int distance = Math.abs(distances.get(A[i]) - i);
                
                if( distance < minDistance || minDistance == -1)
                {
                    minDistance = distance;
                }
                
                //Set start point to the old end point
                distances.put(A[i], i);
            }
            else
            {
                //Add a new starting point
                distances.put(A[i], i);
            }
        }
        
        System.out.println(minDistance);
        
        
    }
}
