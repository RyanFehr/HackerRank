//Problem: https://www.hackerrank.com/challenges/countingsort3
//Java 8
/*
Time Complexity: O(n)
Space Complexity: O(n)
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
            input.nextLine();//throw away following string
            frequencies[num] = frequencies[num] + 1;
        }
        int sum = 0;
        for(int i = 0; i < frequencies.length; i++)
        {
            sum += frequencies[i];
            System.out.print(sum+" ");
        }
    }
}