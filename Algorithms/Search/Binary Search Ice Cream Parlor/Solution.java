//Problem: https://www.hackerrank.com/challenges/ctci-ice-cream-parlor
//Java 8
/*
Initial thoughts:
Keep track of the index and the complement value
in a hasmap and as we can our input, check if we 
see a complement
    if we do see one then just print out its' index
    and our current index
    
    
Time complexity: O(n)    //The number of flavors we have to look at
Space complexity: O(n)   //The number of flavors we store the complement of
*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int t = input.nextInt();
        for(int a0 = 0; a0 < t; a0++)
        {
            int money = input.nextInt();
            int flavors = input.nextInt();
            Map<Integer, Integer> complements = new HashMap<>();
            
            for(int i = 1; i <= flavors; i++)
            {
                int cost = input.nextInt();
                if(complements.containsKey(cost))
                    System.out.println(complements.get(cost) + " " + i);
                else
                    complements.put(money-cost, i);
            }
        }
    }
}