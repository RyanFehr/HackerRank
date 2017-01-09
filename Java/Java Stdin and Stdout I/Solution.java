
//Most HackerRank challenges require you to read input from stdin (standard input) and write output to stdout (standard output).


//Task 
//In this challenge, you must read  integers from stdin and then print them to stdout. Each integer must be printed on a new line. To make the problem a little easier, a portion of the code is provided for you in the editor below.
//
//Input Format
//
//There are three lines of input, and each line contains a single integer.
//
//Sample Input
//
//42
//100
//125
//Sample Output
//
//42
//100
//125


import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int a = scan.nextInt();
        int b = scan.nextInt();
        int c = scan.nextInt();

        System.out.println(a);
        System.out.println(b);
        System.out.println(c);
    }
}