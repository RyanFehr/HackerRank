//Problem: https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited
//Java 8
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
        int c[] = new int[n];
        for(int c_i=0; c_i < n; c_i++){
            c[c_i] = in.nextInt();
        }
        
        int energy = 100;
        int cloud = 0;
        do
        {
            energy--; //You performed a jump
            
            cloud = (cloud + k) % n;
            
            if(c[cloud] == 1)
            {
                energy -= 2;//You landed on a thundercloud
            }
        }
        while(cloud != 0);
        
        System.out.println(energy);
    }
}
