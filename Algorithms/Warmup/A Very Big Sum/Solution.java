//Problem: https://www.hackerrank.com/challenges/a-very-big-sum
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n  = input.nextInt();
        long sum = 0;
        for(int i = n; i>0; i--)
        {
            sum += input.nextInt();
        }
        System.out.println(sum);
    }
}