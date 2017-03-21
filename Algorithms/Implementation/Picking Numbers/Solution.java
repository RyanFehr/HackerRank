//Problem: https://www.hackerrank.com/challenges/picking-numbers
//Java 8
/*
Initial Thoughts:
Use a hashmap to store all of our frequencies
as we read in the values, then iterate over
the map keeping a running max as we compare
the element 1 > and 1 < then the current 
iteration

Time Complexity: O(n)  //We have to look at every input integer
Space Complexity: O(n) //We have to store a map of at most all elements
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        Map<Integer,Integer> frequencies = new HashMap<>();
        for(int i=0; i < n; i++){
            int num = in.nextInt();
            if(frequencies.containsKey(num))
                frequencies.put(num, frequencies.get(num)+1);
            else
                frequencies.put(num, 1);
            
        }
        int maxSet = 0;
        
        for(int i : frequencies.keySet())
        {
            int left = (frequencies.containsKey(i-1)) ? frequencies.get(i) + frequencies.get(i-1) : frequencies.get(i);
            int right = (frequencies.containsKey(i+1)) ? frequencies.get(i) + frequencies.get(i+1) : frequencies.get(i);
            
            if(left > maxSet)
                maxSet = left;
            if(right > maxSet)
                maxSet = right;
        }
        System.out.println(maxSet);
    }
}
