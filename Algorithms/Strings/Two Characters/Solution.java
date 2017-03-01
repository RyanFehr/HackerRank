//Problem: https://www.hackerrank.com/challenges/two-characters
//Java 8
/*
Examples: 
beabeefeab  -> babab -> 5
bbbbbaaaaa  ->       -> 0
a           ->       -> 1
aa          ->       -> 0
abb         ->       -> 1


We test every combination of 2 characters
and we keep a running max of the longest that satisfies

Summation: (1*n-1)...(1*1)
n^2 * n -> n^3

Optimizations:
Remove any char that has a double contiguous 
Start with the largest


Tradeoff:
Use memory to track multiple char combinations at once
beabeefeab
ab
ae
af
be
bf
ef

if you passes then we check against our max

run in O(n) but would use O(n^2)


Since we are limited to the alphabet which we know to 
be constant we can come up with a better solution

We can iterate through every character pair which is 
(26 * 25) / 2 = 325 pairs

for each of those iterations we will run through the string 
checking if it fits the pattern and return the largest


Time Complexity: O(n)
Space Complexity: O(1)


*/

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int len = in.nextInt();
        String s = in.next();
        int maxPattern = 0;
        
        if(s.length() == 1)//Edge case where length is 1
        {
            System.out.println(maxPattern);
            System.exit(0);
        }
        
        //Loop through all letter pairs
        for(int i = 0; i < 26; i++)
        {
            nextLetter:
            for(int j = i + 1; j < 26; j++)
            {
                char one = (char) ('a' + i); //First char in pair
                char two = (char) ('a' + j); //Second char in pair
                char lastSeen = '\u0000';
                int patternLength = 0;
                
                for(char letter : s.toCharArray())
                {
                    if(letter == one || letter == two)
                    {
                        if(letter == lastSeen)//Duplicate found
                        {
                            continue nextLetter;
                        }
                        //Not a duplicate
                        patternLength++;
                        lastSeen = letter;
                    }
                }//for char : s
                
                maxPattern = (patternLength > maxPattern) ? patternLength : maxPattern; //Keep a running max
                
            }//for j
        }//for i
        
        System.out.println(maxPattern);
        
    }
}
