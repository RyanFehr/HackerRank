//Problem: https://www.hackerrank.com/challenges/reduced-string
//Java 8
/*
We can simply compress by iterating left to right removing duplicates
then repeat the process until we can no longer compress

To accomplish this we just need to loop until we see no change
in our input and output after running the compression algorithm
*/


import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        String inputString = input.nextLine();
        StringBuilder lastOutput = new StringBuilder(inputString);
        
        
        while(true)
        {
            StringBuilder currentOutput = new StringBuilder("");
            String s = lastOutput.toString();
            char past = s.charAt(0);
            int count = 0;
            for(int i = 0; i < s.length(); i++)
            {
                char current = s.charAt(i);

                if(past == current)
                    count += 1;
                else if (count == 1)
                {
                    currentOutput.append(past);
                    count = 1;
                }
                else
                    count = 1;

                if(count == 2)
                    count = 0;

                past = current;
            }
            
            if(count == 1)
                currentOutput.append(s.charAt(s.length()-1));
            
            
            if(currentOutput.toString().equals(""))
            {
                System.out.println("Empty String");
                System.exit(0);
            }
            
            
            if(currentOutput.toString().equals(lastOutput.toString()))
                break;
            else
                lastOutput = new StringBuilder(currentOutput.toString());
        }
        
        System.out.println(lastOutput);
    }
}