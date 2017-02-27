//Problem: https://www.hackerrank.com/challenges/flipping-the-matrix
//Java 8
/*
Example:

112  42  83  119
56  125  56  49
15   78  101 43
62   98  114 108


We can abstract the matrix to 
be labeled based on what indices can swap where

0 1 1 0
3 2 2 3
3 2 2 3
0 1 1 0

so for 0 1 3 2
we need the greatest of each of those subsets


0 1 3 3 1 0
4 6 7 7 6 4
5 8 2 2 8 5
5 8 2 2 8 5 
4 6 7 7 6 4
0 1 3 3 1 0

0 : (0,0), (0,n-1), (n-1, 0), (n-1, n-1)
1 : (0+1)

0 1 3
4 6 7
5 8 2
is just repeated in different orientations so we can use that to find positions


Build a set for each number and then choose the max of each set
There is a pattern to sets and matrix index so group accordingly

There are n^2 groups


0 1 2 2 1 0
3 4 5 5 4 3
6 7 8 8 7 6
6 7 8 8 7 6
3 4 5 5 4 3
0 1 2 2 1 0 

0,0
0, (2n - 0 - 1)

0,1
0,(2n - 1 - 1)

0,2
0,(2n - 2 - 1)

r,c
r,(2n - c - 1)
(2n - r - 1),c
(2n - r - 1),(2n - c - 1)


*/






import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int q = input.nextInt();
        
        
        tests:
        for(int t = 0; t < q; t ++)
        {
            int n = input.nextInt();
            
            //Build the input matrix
            int[][] matrix = new int[2*n][2*n];
            int sum = 0;
            
            for(int i = 0; i < matrix.length; i++)
            {
                for(int j = 0; j < matrix[0].length; j++)
                {
                    matrix[i][j] = input.nextInt();
                }
            }
            
            //Find the 4 swaps for each index in the n*n matrix and add the max
            for(int i = 0; i < n; i++)
            {
              for(int j = 0; j < n; j++)
              {
                  int num1 = matrix[i][(2*n) - j - 1];
                  int num2 = matrix[i][j];
                  int num3 = matrix[(2*n) - i - 1][j];
                  int num4 = matrix[(2*n) - i - 1][(2*n) - j - 1];
                  //System.out.println(num1 + " " + num2 + " " + num3 + " " + num4);
                  sum += Math.max(num1, Math.max(num2, Math.max(num3, num4)));
              }
            }
            System.out.println(sum);
        }
    }
}