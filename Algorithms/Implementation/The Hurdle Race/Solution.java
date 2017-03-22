//Problem: https://www.hackerrank.com/challenges/the-hurdle-race
//Java 8
/*
Initial Thoughts:
Keep a running max and if it is
greater than our current power
then we drink max - power drinks
else we drink 0

Time Complexity: O(n)  //We have to check all hurdle heights
Space Complexity: O(1) //No dynamically allocated variables
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
        int k = in.nextInt();
        int max = 0;
        for(int i=0; i < n; i++){
            max = Math.max(max,in.nextInt());
        }
        if(k-max < 0)
            System.out.println(Math.abs(k-max));
        else
        System.out.println(0);
    }
}
