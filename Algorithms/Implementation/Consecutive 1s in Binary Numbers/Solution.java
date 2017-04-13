//Problem: https://www.hackerrank.com/challenges/linkedin-practice-binary-numbers
//Java 8
/*
Initial Thoughts:
We can simply use the decimal to two's complement
conversion which consist of dividing by two while
you are > 0 and adding a bit equal to the modulo
of you decimal each time and then reversing your
binary at the end

Since we don't care about the order of the binary,
but rather just the consecutive ones we don't need
to reverse it

Time Complexity: O(n) //We must iterate through every bit
Space Complexity: O(1) //We consider our string to be fixed length
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int decimal = input.nextInt();
        String binary = "";
        while(decimal > 0)
        {
            binary += (decimal % 2); //0 if it is even and 1 if odd
            decimal /= 2;//Divide by 2 to get next bit
        }
        binary = new StringBuilder(binary).reverse().toString(); //Reverse binary
        int max = 0;
        int curr = 0;
        for(char c : binary.toCharArray())
        {
            if(c == '1') curr++;
            else curr = 0;
            
            max = Math.max(max, curr);
        }
        System.out.println(max);
    }
}