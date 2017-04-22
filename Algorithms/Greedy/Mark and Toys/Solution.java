//Problem: https://www.hackerrank.com/challenges/mark-and-toys
//Java 8
/*
Initial Thoughts: We can sort the toy  prices ascending then
                  substract their prices from our total money
                  until we can no longer buy any more toys, 
                  and since they are sorted in ascending order
                  we know that if we can't buy the current toy
                  then we can't buy any others either

Time Complexity: O(n log(n)) //It takes n log n time to run quicksort on the input array
Space Complexity: O(n) //We dynamically allocate and array to store the input
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int k = input.nextInt();
        int[] toys = new int[n];
        for(int i = 0; i < n; i++)
        {
            toys[i] = input.nextInt();
        }
        Arrays.sort(toys);
        int totalToys = 0;
        
        for(int i = 0; i < n; i++)
        {
            k -= toys[i];
            if(k > 0) totalToys++;
            if(k <= 0) break;
        }
        System.out.println(totalToys);
    }
}