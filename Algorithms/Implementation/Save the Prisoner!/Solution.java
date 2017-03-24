//Problem: https://www.hackerrank.com/challenges/save-the-prisoner
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        
        for(int i = 0; i < T; i++)
        {
            int N = input.nextInt();//Number of prisoners
            int M = input.nextInt();//Number of sweets
            int S = input.nextInt();//First prisoner to be served
            
            int poisonedPrisoner = (S + M - 1) % N;
            if(poisonedPrisoner == 0){poisonedPrisoner=N;}
            System.out.println(poisonedPrisoner);
        }
    }
}