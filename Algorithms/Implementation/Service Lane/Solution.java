//Problem: https://www.hackerrank.com/challenges/service-lane
//Java 8

/*
N = length of the highway
T = test cases
we have N segements in our width array
T instances of
i = entry index
j = exit index

output: largest allowed vehicle


start at point i with a truck and if it doesnt fit
at any point move down in vehicle size
return vehicle size at end point j
*/


import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        int T = input.nextInt();
        int[] widths = new int[N];
        
        for(int i = 0; i < N; i++)
        {
            widths[i] = input.nextInt();
        }
        
        for(int test = 0; test < T; test++)
        {
            int i = input.nextInt();
            int j = input.nextInt();
            int vehicleSize = 3; //Initialize to truck
            
            while(i <= j)
            {
                if(vehicleSize > widths[i])
                {
                    vehicleSize = widths[i];
                }
                i++;
            }
            System.out.println(vehicleSize);
        }
    }
}