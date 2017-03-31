//Problem: https://www.hackerrank.com/challenges/counting-valleys
//Java 8
/*
Initial Thoughts:
Iterate over the ups and downs keeping track of 
your distance from sea level and whenever you make
the transition to below increase a value and repeat
that for each time you make the transition

Time Complexity: O(n) //We need to iterate over the whole hike
Space Complexity: O(1) //We do no use any dynamically sized variables
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt(); input.nextLine();
        String terrain = input.nextLine();
        int level = 0; //Start at sea level
        int valleys = 0;
        boolean belowSea = false;
        
        for(int i = 0; i < n; i++)
        {
            char slope = terrain.charAt(i);
            if(slope == 'U')//Uphill
                level++;
            else//Downhill
                level--;
            
            //Handle transitions
            if(!belowSea && level < 0)
            {
                valleys++;
                belowSea = true;
            }
            
            if(level >= 0)//We are back above sea level
                belowSea = false;
        }
        System.out.println(valleys);
    }
}