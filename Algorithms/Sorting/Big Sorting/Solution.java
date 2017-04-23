//Problem: https://www.hackerrank.com/challenges/big-sorting
//Java 8
/*
Intitial Thoughts: Because we are using really big integers 
                   we can use BigIntegers to read in the 
                   large numbers into an array and then just
                   use the built in comparator class to sort
                   them ascending
                   
Optimization 1: Instead of initializing BigIntegers, we can just do
              string compares and run a insertion sort which should
              save us some time doing comparisons during the sort
              and we can use a StringBuilder to print our array to
              reduce inefficient IO
              
Optimization 2: We can define our own comparator for strings and then sort our
                array using it
                   
Space Complexity: O(n log(n)) //It takes n^2 time to run insertion sort on an array 
Time Complexity: O(n) //We dynamically allocate an array to store the input
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
        String[] unsorted = new String[n];
        for(int i = 0; i < n; i++) unsorted[i] = in.next();

        Arrays.sort(unsorted,new Comparator<String>() {
            @Override
            public int compare(String a, String b) 
            {
                return StringAsIntegerCompare(a,b);
            }
        });
        
        StringBuilder output = new StringBuilder("");
        for(String num : unsorted)
            output.append(num+"\n");
        System.out.println(output);
    }
    
    //0 means s1=s2, 1 means s1>s2, -1 means s1<s2 
    static int StringAsIntegerCompare(String s1, String s2)
    {
        if(s1.length() > s2.length()) return 1;
        if(s1.length() < s2.length()) return -1;
        for(int i = 0; i < s1.length(); i++)
        {
            if((int)s1.charAt(i) > (int)s2.charAt(i)) return 1;
            if((int)s1.charAt(i) < (int)s2.charAt(i)) return -1;
        }
        return 0;
    }
}
