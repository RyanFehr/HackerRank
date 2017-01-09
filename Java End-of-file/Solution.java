//Problem: https://www.hackerrank.com/challenges/java-end-of-file
//Java 7
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
         Scanner input = new Scanner(System.in);
        String line;
        int i = 1;
        while(input.hasNext())
        {
            line = input.nextLine();
            System.out.println(i + " "+ line);
            i++;
        }
    }
}