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
        int[] bill = new int[n];
        int totalCost = 0;
        
        
        for(int i = 0; i < n; i++)
        {
            int item = input.nextInt();
            totalCost += item;
            bill[i] = item;
        }
        
        
        int charged = input.nextInt();
        if(charged == totalCost/2)
        {
            System.out.println(bill[k]/2);
            System.exit(0);
        }
        System.out.println("Bon Appetit");
        
        
        
    }
}