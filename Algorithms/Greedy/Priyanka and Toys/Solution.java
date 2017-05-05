//Problem: https://www.hackerrank.com/challenges/priyanka-and-toys
//Java 8
/*
Initial Thoughts: We can sort the toys ascending by weight,
                  then we just iterate over it not counting 
                  when we get the next 4 consecutive weight
                  toys for free
                 
Time Complexity: O(n log(n)) //We have to sort the toys by weight
Space Complexity: O(n) //We store the input in a dynamically allocated array
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int units = 1;
        
        //Initialize the array of toys
        int[] toys = new int[n];
        for(int i = 0; i < n; i++)
            toys[i] = input.nextInt();
        
        Arrays.sort(toys); //Sort the toys ascending by weight
        
        int currentWeight = toys[0];
        for(int weight : toys)
        {
            if(!(weight <= currentWeight+4))
            {
                units++;
                currentWeight = weight;
            }
        }
        
        System.out.println(units);
    }
}