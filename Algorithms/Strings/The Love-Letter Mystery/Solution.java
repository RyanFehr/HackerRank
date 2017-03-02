//Problem: https://www.hackerrank.com/challenges/the-love-letter-mystery
//Java 8
/*
Initial Thoughts:

Iterate through the string with pointers at 
the start and end of the string. At each
iteration check which one is greater and
reduce that one by their difference in
ASCII value. Add that difference to the 
operations counter

Time complexity: O(n)
Space complexity: O(1)
*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        input.nextLine();
        
        tests:
        for(int t = 0; t < T; t++)
        {
            String s = input.nextLine();
            int operationsPerformed = 0;
            int i = 0;
            int j = s.length() - 1;
            while(i < j)
            {
                operationsPerformed += Math.abs(s.charAt(i) - s.charAt(j));
                i++;
                j--;
            }
            System.out.println(operationsPerformed);
        }
    }
}