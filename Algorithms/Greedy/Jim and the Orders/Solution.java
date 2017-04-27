//Problem: https://www.hackerrank.com/challenges/jim-and-the-orders
//Java 8
/*

Initial Thoughts: We can create key value pairs based on the input
                  and then sort them ascending and print the key values

Time Complexity: O(n log(n)) //We sort the input 
Space Complexity: O(n) //We must store all of the input for sorting
*/

import java.io.*;
import java.util.*;
import java.lang.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        List<AbstractMap.SimpleEntry<Integer,Integer>> entryList = new LinkedList<>();
        int n = input.nextInt();
        
        //Builds a list of key value pairs
        for(int i = 0; i < n; i++)
        {
            entryList.add(new AbstractMap.SimpleEntry<Integer,Integer>(i+1,input.nextInt() + input.nextInt()));
        }        
        
        //Sorts the list of entries according to value
        Collections.sort(entryList, (p1,p2) -> (p1.getValue()).compareTo(p2.getValue()));
        
        //Print the sorted list of entries
        StringBuilder output = new StringBuilder("");
        for (AbstractMap.SimpleEntry<Integer,Integer> entry : entryList) {
            output.append(entry.getKey() + " ");
        }
        System.out.println(output);
    }
}