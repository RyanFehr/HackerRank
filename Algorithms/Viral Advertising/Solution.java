//Problem: https://www.hackerrank.com/challenges/strange-advertising
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        
        //We can intialize to day 1 values since 1<= n <= 50
        int peopleReached = 2, peopleSharing = 2;
        for(int i = 1; i < n; i++)
        {
            peopleReached += (peopleSharing * 3) / 2;
            peopleSharing = (peopleSharing * 3) / 2;
        }
        System.out.println(peopleReached);
    }
}