//Problem: https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array
//Java 8
/*
Initial Thoughts: We can sort this array and then find the minimum
                  absolute value of the elements to the right of each 
                  element, because they will always be smaller than 
                  something further away, thus reducing the number 
                  of comparisons we need to do
                  
Time Complexity: O(n log n) //We only iterated n times, but it took n log n to sort the array
Space Complexity: O(1) //We can treat the input array as given, and we did our sort in place, so no addition space
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] a = new int[n];
        for(int a_i=0; a_i < n; a_i++){
            a[a_i] = in.nextInt();
        }
        Arrays.sort(a);
        int min = Integer.MAX_VALUE;
        for(int i = 0; i < n-1; i++)
        {
            int currentMin = Math.abs(a[i]-a[i+1]);
            min = Math.min(min, currentMin);
        }
        System.out.println(min);
    }
}
