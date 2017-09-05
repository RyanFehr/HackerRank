//Problem: https://www.hackerrank.com/challenges/bon-appetit
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int k = input.nextInt();
        int totalCost = 0;
        int notEaten = 0;
        
        for(int i = 0; i < n; i++) {
            int item = input.nextInt();
            if(i == k) notEaten = item;
            totalCost += item;
        }
        
        int charged = input.nextInt();
        if(charged == totalCost/2) {
            System.out.println(notEaten/2);
            System.exit(0);
        }
        System.out.println("Bon Appetit");
    }
}