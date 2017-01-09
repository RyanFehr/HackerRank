//Problem: https://www.hackerrank.com/challenges/compare-the-triplets
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int a0 = in.nextInt();
        int a1 = in.nextInt();
        int a2 = in.nextInt();
        int b0 = in.nextInt();
        int b1 = in.nextInt();
        int b2 = in.nextInt();
        
        int alice = ((a0 > b0)?1:0) + ((a1 > b1)?1:0) + ((a2 > b2)?1:0);
        int bob = ((b0 > a0)?1:0) + ((b1 > a1)?1:0) + ((b2 > a2)?1:0);
        
        
        System.out.println(alice + " " + bob);
    }
}
