//Problem: https://www.hackerrank.com/challenges/arrays-ds
//Java 8
/*
Initial Thoughts: simply create an array populate it. 
Then return the values in opposite order. I chose to 
populate the table backwords to so that it would make
reading out the table easier.

Time complexity: O(n) 
Space complexity: O(n)
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int[] arr = new int[s.nextInt()];
        
        for (int i = arr.length - 1; i >= 0; i--) {
            arr[i] = s.nextInt();
        }
        
        for (int val : arr) {
            System.out.print(val + " ");
        }
    }
}