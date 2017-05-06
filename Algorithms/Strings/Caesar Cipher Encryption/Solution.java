//Problem: https://www.hackerrank.com/challenges/linkedin-practice-caesar-cipher
//Java 8
/*
Initial Thoughts: We can just treat the upper and lower
                  case alphabets like circular queues,
                  where we index them by char+k to get
                  the encrypted character
                  
Time Complexity: O(n) //We must convert each character in the input
Space Complexity: O(n) //Since we opt for a stringbuilder to increase IO runtime our SC is n
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();input.nextLine();
        String word = input.nextLine();
        int rotation = input.nextInt();
        StringBuilder encryptedWord = new StringBuilder("");
        for(char c : word.toCharArray())
        {
            if(c >= 'a' && c <= 'z')
                encryptedWord.append((char) ('a'+(((c-'a')+rotation)%26)));
            else if(c >= 'A' && c <= 'Z')
                encryptedWord.append((char) ('A'+(((c-'A')+rotation)%26)));
            else
                encryptedWord.append(c);
                
        }
        System.out.println(encryptedWord);
    }
}