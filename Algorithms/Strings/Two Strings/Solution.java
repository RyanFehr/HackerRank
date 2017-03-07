//Problem: https://www.hackerrank.com/challenges/two-strings
//Java 8
/*
Initial Thoughts:
Since a substring can be a minimum of size 1
and at max the size of the smallest substring,
then we can derive that if they have a letter in
common they have a substring in common

Algorithm:
Form a set for each string made up of its' characters
Intersect the sets
if size of intersection is > 0
    YES
else
    NO
    
    
Time complexity: O(|a| + |b|)    //We iterate through each input string
Space complexity: O(1)           //Our sets can be at most 2 x character set in size
*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int pairs = input.nextInt(); input.nextLine();
        
        tests:
        for(int t = 0; t < pairs; t++)
        {
            String a = input.nextLine();
            String b = input.nextLine();
            
            Set<Character> aLetterSet = new HashSet<>();
            Set<Character> bLetterSet = new HashSet<>();
            
            //Populate the sets
            for(int i = 0; i < a.length(); i++)
                aLetterSet.add(a.charAt(i));
            
            for(int i = 0; i < b.length(); i++)
                bLetterSet.add(b.charAt(i));
            
            //Perform the intersection of the two sets
            aLetterSet.retainAll(bLetterSet);
                
            if(aLetterSet.size() > 0)
                System.out.println("YES");
            else
                System.out.println("NO");
        }
    }
}