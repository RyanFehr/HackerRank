//Problem: https://www.hackerrank.com/challenges/divisible-sum-pairs
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int k = in.nextInt();
        int a[] = new int[n];
        for(int a_i=0; a_i < n; a_i++){
            a[a_i] = in.nextInt();
        }
        
        int validPairs = 0;
        
        int[] modSort = new int[k];
        
        for(int num : a)
        {
            int modIndex = num % k;
            modSort[modIndex] += 1;
        }
        
        validPairs += (modSort[0]*(modSort[0]-1)/2);//Determines valid pairs of the values that had mod 0        
        
        for(int i = 1; i < k/2.0; i++)
        {
                //Determines two mod indices that when summed have a mod 0 index
                int x = modSort[i];
                int y = modSort[k-i];
                
                //Determine valid pairs of x + y integers
                validPairs += x*y;
        }
        
        if(k % 2 == 0)//Handles the edge case of calculating valid pairs for when the two mod indices are the same
        {
            validPairs += (modSort[k/2]*(modSort[k/2]-1)/2);
        }
        
        System.out.println(validPairs);
    }
}

