// Problem: https://www.hackerrank.com/challenges/java-substring/problem
// Java 8
// Time Complexity: O(1)
// Space Complexity: O(1)
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String S = input.next();
        int start = input.nextInt();
        int end = input.nextInt();
        System.out.println(S.substring(start,end));
    }
}
