//Problem: https://www.hackerrank.com/challenges/diagonal-difference
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        
        int leftDiagonal = input.nextInt(); //Handles first edge case of the element at matrix pos 0
        int rightDiagonal = 0;
        
        for(int i = 1; i<n*n; i++) //Uses modulus to only sum diagonal elements
        {
            int value = input.nextInt();
            if(i%(n+1) == 0)
            {

                leftDiagonal += value;
            }
            if(i%(n-1) == 0 && i != (n*n)-1)//Handles the second edge case of the last element in the matrix
            {
                rightDiagonal += value;
            }
        }
        System.out.println(Math.abs(leftDiagonal-rightDiagonal));
        
        
    }
}