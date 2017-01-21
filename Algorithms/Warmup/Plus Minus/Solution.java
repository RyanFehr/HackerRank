//Problem: https://www.hackerrank.com/challenges/plus-minus
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        
        double positive = 0;
        double negative = 0;
        double zero = 0;
        
        for(int i = 0; i<n; i++)
        {
            int value = input.nextInt();
            positive += value>0 ? 1:0;
            negative += value<0 ? 1:0;
            zero     += value==0 ? 1:0;
        }
        System.out.println(positive/n);
        System.out.println(negative/n);
        System.out.println(zero/n);
    }
}