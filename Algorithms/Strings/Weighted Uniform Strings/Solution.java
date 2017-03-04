//Problem: https://www.hackerrank.com/challenges/weighted-uniform-string
//Java 8
/*
Initial Thoughts:

Build a HashSet of the weights by iterating through
the string keeping track of weight  O(s) time and space

Then iterate through our queries checking if they 
are in the HashSet O(n) time and O(1) space

Time Complexity: O(s + n) 
Space Complexity: O(n)


*/


import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String s = in.next();
        int n = in.nextInt();
        
        //Build a set of weights
        Set<Integer> weights = new HashSet<>();
        
        int currentWeight = 0;
        char prevLetter = ' ';
        for(char letter : s.toCharArray())
        {
            if(letter != prevLetter)
                currentWeight = letter - 'a' + 1;
            else
                currentWeight += letter - 'a' + 1;
            
            prevLetter = letter;
            weights.add(currentWeight);
        }
        
        for(int a0 = 0; a0 < n; a0++){
            int x = in.nextInt();
            
            if(weights.contains(x))
                System.out.println("Yes");
            else
                System.out.println("No");
        }
    }
}
