//Problem: https://www.hackerrank.com/challenges/caesar-cipher-1
//Java 8
/*
Simply update the ascii values by k and cast to char
if it is a symbol dont change it
*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        input.nextLine();
        String s = input.nextLine();
        int k = input.nextInt() % 26;
        StringBuilder output = new StringBuilder("");
        
        for(char letter : s.toCharArray())
        {
            if(letter > 64 && letter < 91)//Capital letter
            {
                char encrypted = (char) (letter+k);
                if(encrypted > 90)
                {
                    encrypted = (char) ((encrypted % 90) + 64);
                }
                output.append(encrypted);
            }
            else if(letter > 96 && letter < 123)//Lower case letter
            {
                char encrypted = (char) (letter+k);
                if(encrypted > 122)
                {
                    encrypted = (char) ((encrypted % 122) + 96);
                }
                output.append(encrypted);
            }
            else//Symbol
            {
                output.append(letter);
            }
        }
        System.out.println(output);
    }
}