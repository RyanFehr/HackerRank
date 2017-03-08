//Problem: https://www.hackerrank.com/challenges/string-construction
//Java 8
/*
Initial Thoughts:
We want to find the minimum cost, but since there
is no cost for a substring and a single character 
is also a substring, this essentially means that
if our string P already has the next character in p
we just append it to the end at no cost, but if it 
doesn't have it, we don't append it. This will give us
the minimum cost, which is equivalent to the number
of unique characters in the first string.

Algorithm:
Fill a set based on the characters in the input string
Return the size of the set

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
        for(int a0 = 0; a0 < n; a0++){
            String s = in.next();
            
            Set<Character> uniqueChars = new HashSet<>();
            for(char c : s.toCharArray())
            {
                uniqueChars.add(c);
            }
            System.out.println(uniqueChars.size());
        }
    }
}
