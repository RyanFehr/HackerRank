//Problem: https://www.hackerrank.com/challenges/ctci-making-anagrams
//Java 8
/*

Initial Thoughts: We can build frequency maps of each string 
                  then compare them. When we compare we just 
                  need to sum the absolute difference between
                  each character' frequency
                  
Time Complexity: O(|A|+|B|) //We must iterate every char in A and B
Space Complexity: O(1) //Our frequency arrays are fixed size
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
public class Solution {
    public static int numberNeeded(String first, String second) {
        int[] freqFirst = new int[26];
        int[] freqSecond = new int[26];
        int deletions = 0;
        
        for(int i = 0; i < first.length(); i++)
            freqFirst[first.charAt(i)-'a'] = freqFirst[first.charAt(i)-'a'] + 1; //Increment frequency of char at i
        for(int i = 0; i < second.length(); i++)
            freqSecond[second.charAt(i)-'a'] = freqSecond[second.charAt(i)-'a'] + 1; //Increment frequency of char at i
        
        for(int i = 0; i < 26; i++)
            deletions += Math.abs(freqFirst[i] - freqSecond[i]); //Track the total deletions needed
        
        return deletions;
    }
  
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String a = in.next();
        String b = in.next();
        System.out.println(numberNeeded(a, b));
    }
}
