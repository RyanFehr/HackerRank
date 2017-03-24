//Problem: https://www.hackerrank.com/challenges/circular-array-rotation
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
        int k = in.nextInt()%n;//We MOD k here because every n rotations we receive the same array
        int q = in.nextInt();
        int[] a = new int[n];
        for(int a_i=0; a_i < n; a_i++){
            a[a_i] = in.nextInt();
        }
        
        
        //Run each query q
        for(int a0 = 0; a0 < q; a0++){
            int m = in.nextInt();
            if(m-k >=0)//Checks if a array wrap occurs
            {
                System.out.println(a[m-k]);
            }
            else//if and array rap occurs we account for it
            {
                System.out.println(a[n+(m-k)]);
            }
            
        }
    } 
}
