//Problem: https://www.hackerrank.com/domains/algorithms/strings
//Java 8
/*
Initial Thoughts:
We could use a greedy approach and starting from the
left everytime we see a 010 replace the last 0 with a 1
and continue

Examples:
01010
01110 -> 1

0100101010
0110101010
0110111010
0110111011 -> 3


*/


import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        input.nextLine();
        String s = input.nextLine();
        int switches = 0;
        
        for(int i = 0; i < s.length()-2; i++)
        {
            if(s.charAt(i) == '0' && s.charAt(i+1) == '1' && s.charAt(i+2) == '0')
            {
                switches++;
                i += 2;
            }
        }
        System.out.println(switches);
    }
}