//Problem: https://www.hackerrank.com/challenges/sock-merchant
//Java 8
/*
Thoughts: Since we only care about the number of pairs, we can iterate over the
		  input and check if we have already seen a matching sock. To do this, 
		  once we see a new sock we store it in a hash map with the value 1 and
		  if we see that sock a again we simply set its' value to 0 and increase
		  our pair count by 1. After iterating all the socks we will have a total
		  number of pairs.


Time Complexity: O(n) //We iterate over the input
Space Complexity: O(n) //At most every input is unique in our hashmap
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.util.HashMap;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        
        HashMap inventory = new HashMap<Integer,Integer>();
        
        int matchingPairs = 0;
        
        for(int i=0; i < n; i++)
        {
            int color = in.nextInt();
            
            //This checks if we already have 1 sock of that color and if we do then we increment matchingPairs and set unmatched               //socks of that color back to 0
            if(inventory.containsKey(color) && inventory.get(color).equals(new Integer(1)))
            {
                inventory.put(color,0);
                matchingPairs++;
                continue;
            }
            inventory.put(color,1);
        }
        System.out.println(matchingPairs);
    }
}
