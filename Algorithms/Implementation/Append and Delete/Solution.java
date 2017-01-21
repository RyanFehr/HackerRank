//Problem: https://www.hackerrank.com/challenges/append-and-delete
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.lang.Math;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String s = in.next();
        String t = in.next();
        int k = in.nextInt();
        
        String result = "ERROR";
        
        //if s == t then we just run an equation to determine if it can be done
        if(s.equals(t))
        {
            result = (k >= s.length()*2 || k % 2 == 0) ? "Yes" : "No";
        }
        else//count how many characters they share, starting from the front of the string
        {
            int matchingCharacters = 0;
            
            for(int i = 0; i < Math.min(s.length(), t.length()); i++)
            {
                //ado
                //adolol
                if(s.charAt(i) != t.charAt(i))
                {    
                    break;
                }
                matchingCharacters++;
            }
            
            int nonMatchingCharactersInS = s.length() - matchingCharacters;
            int nonMatchingCharactersInT = t.length() - matchingCharacters;
            
            //I reassign here to make the conditions more readable down below
            int nmcS = nonMatchingCharactersInS;
            int nmcT = nonMatchingCharactersInT;
            
            //use the number of non matching characters in an equation to determine if it can be done
            
            //Naming the conditions to increase readability
            boolean conditionA = nmcS + nmcT == k;
            boolean conditionB = (nmcS + nmcT < k && (nmcS + nmcT - k) % 2 == 0 );
            boolean conditionC = s.length() + t.length() <= k;
            
            result = (conditionA || conditionB || conditionC) ? "Yes" : "No";
            
        }
        
        System.out.println(result);
    }
}