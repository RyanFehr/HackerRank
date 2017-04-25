//Problem: https://www.hackerrank.com/challenges/maximum-perimeter-triangle
//Java 8
/*
Initial Thoughts: We can sort the perimeters from largest to smallest
                  then iterate over them checking if adjacent triplets
                  are non-dengerate and if they are we print them, if
                  we check all adjacent triplets and don't find a 
                  triangle we assume there is no such triangle since
                  degeneracy only grows as you check triplets that are
                  not adjacent because the perimeters are sorted and 
                  perimeters futher from the middle perimeter of the
                  triplet will always have a larger absolute value.

Time Complexity: O(n log(n)) //We have to sort the input
Space Complexity: O(n) //We allocate an array to store the input
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        Integer[] perimeters = new Integer[n];
        
        //Store input in perimeters
        for(int i = 0; i < n; i++)
            perimeters[i] = input.nextInt();
        
        //Sort array descending
        Arrays.sort(perimeters, Collections.reverseOrder());
        
        //Check if adjacent triplets are degenerate
        for(int i = 0; i < n-2; i++)
        {
            if(!degenerateTriangle(perimeters[i],perimeters[i+1],perimeters[i+2]))
            {
                System.out.println(perimeters[i+2]+" "+perimeters[i+1]+" "+perimeters[i]);
                System.exit(0);
            }    
        }
        
        //All triangles were degenerative
        System.out.println(-1);
    }
    
    static boolean degenerateTriangle(int a, int b, int c)
    {
        
        if(a+b <= c) return true;
        if(a+c <= b) return true;
        if(b+c <= a) return true;
        return false;
    }
}