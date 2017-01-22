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
        while(sticks[N-1] > 0)
        {
            System.out.println(sticksLeft);
            
            int cut = sticks[N-sticksLeft];
            
            for(int i = sticksLeft; i > 0; i--)
            {
                //Performs the cut
                int postCut = sticks[N-i] - cut;
                sticks[N-i] = postCut;
                
                //If the stick is gone as a result of the cut we decrement sticksLeft
                if(postCut == 0)
                {
                    sticksLeft--;
                }
            }
        }
        
        
    }
}