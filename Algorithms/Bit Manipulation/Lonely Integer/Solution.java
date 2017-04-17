//Problem: https://www.hackerrank.com/challenges/lonely-integer
//Java 8
/*
Initial Thoughts: Basic xor to find non duplicate element

Time Complexity: O(n) //We must check every element
Space Complexity: O(1) //We use xor so everything is in place
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
        int a = 0;
        for (int i = 0; i < n; i++) {
            a ^= in.nextInt();
        }
        System.out.println(a);
    }

}
