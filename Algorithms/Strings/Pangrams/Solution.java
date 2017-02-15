//Problem: https://www.hackerrank.com/challenges/pangrams
//Java 8
/*

Thought process:

We know we only need to see 1 of each letter
We could use something like a hashmap to store all frequencies and check if all are  > 0


We only need 1 of each so instead we can use a set and remove it once one is found
and if it is empty we have found them all and we are done
this prevents a lot of unneeded work if the first 26 are the alphabet
in a long string


*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        String s = input.nextLine();
        
        String[] alphabet = new String[]{"A","B","C","D","E",
                                         "F","G","H","I","J",
                                         "K","L","M","N","O",
                                         "P","Q","R","S","T",
                                         "U","V","W","X","Y","Z"};
        Set<String> pangramTracker = new HashSet<>(Arrays.asList(alphabet));
        
        for(char letter : s.toCharArray())
        {
            if(pangramTracker.contains(Character.toString(letter).toUpperCase()))
            {
                pangramTracker.remove(Character.toString(letter).toUpperCase());       
            }
            
            if(pangramTracker.isEmpty())//Our tracker is empty meaning we have see every letter
            {
                System.out.println("pangram");
                System.exit(0);
            }
        }
        
        //We never saw every letter of the alphabet
        System.out.println("not pangram");
    }
}