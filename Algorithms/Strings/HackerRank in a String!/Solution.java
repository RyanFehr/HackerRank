//Problem: https://www.hackerrank.com/challenges/hackerrank-in-a-string
//Java 8
/*
Initial Thoughts:
We have an array of chars and
advance our position when we 
find a matching char in S and
if we reach the last index before
our string is done then we print YES
else we print NO

Time Complexity: O(n) //We have to iterate through the whole string
Space Complexity: O(1) //We just store the HackerRank array
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        queries:
        for(int a0 = 0; a0 < q; a0++){
            String s = in.next();
            char[] find = "hackerrank".toCharArray(); 
            int findIndex = 0;
            
            for(char c : s.toCharArray())
            {
                if(find[findIndex] == c)
                    findIndex++;
                
                if(findIndex == find.length){ //We ran out of characters to find
                    System.out.println("YES");
                    continue queries;
                }
                    
            }
            System.out.println("NO"); //We didn't find all characters
        }
    }
}
