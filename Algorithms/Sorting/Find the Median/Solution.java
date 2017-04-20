//Problem: https://www.hackerrank.com/challenges/find-the-median
//Java 8
/*
Initial Thoughts: We can sort the array and then pull 
                  out the middle element. This will take
                  n log n time.
                  
Optimization: We can do a counting/bucket sort and simply
              read our inputs into an array then just iterate
              over the array looking for values. While this offers
              a slight average case improvement, if you fail to 
              implement a dual pivot quicksort, you will simply 
              be making a tradeoff and there will be no average
              runtime increase


Time Complexity: O(n log (n)) //We sort the entire array using dual pivot quicksort
Space Complexity: O(n) //We store the array in memory
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int[] array = new int[n];
        for(int i = 0; i < n; i++)
            array[i] = input.nextInt();
        
        Arrays.sort(array);
        
        System.out.println(array[(n/2)]);
    }
}