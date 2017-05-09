//Problem: https://www.hackerrank.com/challenges/sum-vs-xor
//Java 8
/*
Initial Thoughts: Brute force would be to check the condition
                  for all numbers between 0 -> n and keep a 
                  counter of which ones satisfied it. To make
                  this faster, we can simply count the number
                  of zeros after converting n to a binary number.

Time Complexity: O(n log(n)) //It takes n log(n) time to convert to binary using two's division
Space Complexity: O(1) //There is no ddynamically allocated variables
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        long n = in.nextLong();
        long count = 0;
        //This performs a basic conversion from int to binary using divide by two and checking even or odd
        while(n != 0){
            count += (n%2 == 0)?1:0;
            n/=2; 
        }
        count = (long) Math.pow(2,count);
        System.out.println(count);
    }
}
