//Problem: https://www.hackerrank.com/challenges/closest-numbers
//Java 8
/*
Initial Thoughts: We can sort the numbers then just look
                  at adjacent absolute mins since they will
                  always be smaller than non adjacent sums.
                  In the case of multiple pairs, or for just
                  tracking the min in general, we can use a 
                  stringbuilder kind of like a linked list of
                  sorts.
                  
Time Complexity: O(n log(n)) //We need to sort the array list
Space Complexity: O(n) //We use a dynamically sized array
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
        int minAbs = Integer.MAX_VALUE; //Minimum absolute difference
        StringBuilder pairs = new StringBuilder("");
        
        for(int i = 0; i < n-1; i++)
        {
            int absDiff;
            
            if((array[i]<0 && array[i+1]<0)||(array[i]>0 && array[i+1]>0))//both numbers have matching signs
                absDiff = Math.abs(array[i] - array[i+1]); //Absolute difference
            else
                absDiff = Math.abs(array[i]) + Math.abs(array[i+1]); //Absolute difference
            
            if(absDiff < minAbs)//New minAbs
            {
                minAbs = absDiff;
                pairs = new StringBuilder("");//Empty pairs
                pairs.append(array[i]+ " " +array[i+1]+" ");//Add pair
            }
            else if(absDiff == minAbs)//Multiple minAbs
                pairs.append(array[i]+ " " +array[i+1]+" ");//Add pair
        }
        
        System.out.println(pairs);
    }
}