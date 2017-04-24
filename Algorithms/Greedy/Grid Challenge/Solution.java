//Problem: https://www.hackerrank.com/challenges/grid-challenge
//Java 8
/*
Initial Thoughts: If we sort each of the rows to be lexico.
                  order then we just need to check if the 
                  columns are sorted. This works because 
                  the position of the letters in each row 
                  are fixed because they can only be swapped 
                  within their row, so there is only 1 solution
                  to each row which in turn gives us only one
                  solution to the grid, which we can then check
                  
Time Complexity: O(n*(n log (n))) 
Space Complexity: O(n^2) //We build a n*n grid to store the input
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        StringBuilder  output = new StringBuilder("");
        for(int t = 0; t < T; t++){
            
            int n = input.nextInt();input.nextLine();
            char[][] grid = new char[n][n];
            
            //Read in rows of grid and sort
            for(int i = 0; i < n; i++){
                grid[i] = input.nextLine().toCharArray();
                Arrays.sort(grid[i]);
            }
            
            if(checkColumns(grid))
                output.append("YES\n");
            else
                output.append("NO\n");
            
        } 
        System.out.print(output);
    }
    
    //Checks if grid columns are lexicographically ordered
    static boolean checkColumns(char[][] grid){
        for(int i = 0; i < grid.length; i++){//column
            for(int j = 1; j < grid.length; j++){//row
                if(grid[j][i] < grid[j-1][i])
                    return false;
            }
        }
        return true;
    }
}