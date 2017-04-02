//Problem: https://www.hackerrank.com/challenges/countingsort1
//Java 8
/*
Time Complexity: O(n)
Space Complexity: O(1)
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int[] frequencies = new int[100];
        for(int i = 0; i < n; i++)
        {
            int num = input.nextInt();
            frequencies[num] = frequencies[num] + 1;
        }
        
        for(int i = 0; i < frequencies.length; i++)
        {
            System.out.print(frequencies[i]+" ");
        }
    }
}