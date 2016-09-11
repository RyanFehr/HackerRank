package strings;


//A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward.(Wikipedia)
//Given a string , print Yes if it is a palindrome, print No otherwise.
//
//Constraints
// will consist at most  lower case english letters.


//Sample Input
//
//madam
//Sample Output
//
//Yes

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        /* Enter your code here. Print output to STDOUT. */
        
        
        boolean palindrome = true;
        
        for(int i = 0; i<A.length()/2;i++)
        {
            if(!A.substring(i,i+1).equals(A.substring(A.length()-i-1,A.length()-i)))
            {
                palindrome = false;
            }
        }
        if(palindrome){System.out.println("Yes");}
        else{System.out.println("No");}
        
        
    }
}

