//Problem: https://www.hackerrank.com/challenges/mars-exploration
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String S = in.next();
        int count = 0;
        int currentPos = 0;
        for(char letter : S.toCharArray())
        {
            
            if(currentPos % 3 == 1)
            {
                count += (letter != 'O') ? 1 : 0;
            }
            else
            {
                count += (letter != 'S') ? 1 : 0;
            }
            currentPos++;
        }
        System.out.println(count);
    }
}
