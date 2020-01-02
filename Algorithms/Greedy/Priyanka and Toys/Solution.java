//Problem: https://www.hackerrank.com/challenges/priyanka-and-toys

import java.io.*;
import java.util.*;

public class Solution {
    static int count = 0;
    static int t = 0;
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();       
        int k = 4;
       //Initialize the array of toys
        int[] toys = new int[n];
        for(int i = 0; i < n; i++)
            toys[i] = input.nextInt();
        
        Arrays.sort(toys); //Sort the toys ascending by weight
         IntStream.rangeClosed(0,toys.length-1).boxed().map(x->{
           if(!(toys[t]+k>=toys[x])){
               count++;
               t=x;
           }
           return  count;
        }).collect(Collectors.toList());
        
        System.out.println(count+1);
    }
}
