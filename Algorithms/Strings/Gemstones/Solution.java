//Problem: https://www.hackerrank.com/challenges/gem-stones
//Java 8
/*
We could use two sets one for the past rocks and one for the current rock
and just intersect the past with the current and set that to the past
so when we have moved through all the rocks the set will be
the intersection of all rocks which is the gemstones

*/

import java.io.*;
import java.util.*;

public class Solution {
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        input.nextLine();
        
        Set<Character> gemstones = stringToSet(input.nextLine()); //Set of gemstones
        
        for(int i=1; i<n ;i++){
            gemstones.retainAll(stringToSet(input.nextLine())); //Perform intersection
        }
        System.out.print(gemstones.size());
    }
    
    
    
    
    public static Set<Character> stringToSet(String s) //Converts String to Character set
    {
        Set<Character> set = new HashSet<Character>(26);
        for (char c : s.toCharArray())
            set.add(Character.valueOf(c));
        return set;
    }
}


