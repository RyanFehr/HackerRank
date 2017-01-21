//Problem: https://www.hackerrank.com/challenges/utopian-tree
//Java 8
import java.io.*;
import java.util.*;
import java.lang.Math;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int testCases = input.nextInt();
        
        for(int i = 0; i < testCases; i++)
        {
            int cycles = input.nextInt();
            
            //Calculates according the an equation defined by the arithmetico-geometric sequence
            if(cycles % 2 == 0)
            {
                System.out.println((int) (Math.pow(2, cycles/2)*2) -1);
            }
            else
            {
                System.out.println((int) ((Math.pow(2, (cycles-1)/2)*2) -1)*2);
            }
        }
    }
}