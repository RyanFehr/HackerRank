//Problem: https://www.hackerrank.com/challenges/cut-the-sticks
//Java 8
import java.io.*;
import java.util.*;

public class Solution {
    
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        int [] sticks = new int[N];
        
        for(int i = 0; i < N; i++)
        {
            sticks[i] = input.nextInt();
        }
        
        //QuickSort sticks in ascending order
        //The built in sort function performs a dual pivot quick sort that rarely degrades to n^2
        Arrays.sort(sticks);
        
        
        int sticksLeft = N;
        
        int curr = sticks[0];
        int currCount = 0;
        System.out.println(N);
        
        //Works by decrementing sticksLeft by the frequency of the smallest stick each time
        for(int i = 0; i < N; i++)
        {
            if(curr == sticks[i])
            {
                currCount++;
            }
            else
            {
                sticksLeft -= currCount;
                currCount = 1;
                curr = sticks[i];
                System.out.println(sticksLeft);
            }
        }
        
        
    }
}