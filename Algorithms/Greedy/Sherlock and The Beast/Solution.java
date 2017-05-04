//Problem: https://www.hackerrank.com/challenges/sherlock-and-the-beast
//Java 8
/*
Initial Thoughts: We can iterate over the input substracting 5
                  and 3 each time, because that is what it takes
                  to keep the number decent. When we subtract, if
                  the number is divisible by 3, we add 5's and are
                  done. If the number is divisible by 5, we subtract
                  5  threes and keep iterating. If it is not divisible
                  by three or five, we subtract 3 and continue
                  
Time Complexity: O(n) //We must iterate over every every input number
Space Complexity: O(n) //We store our output as we go to prevent unecessary I/O
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        StringBuilder output = new StringBuilder("");
        
        tests: 
        for(int t = 0; t < T; t++)
        {
            int n = input.nextInt();
            StringBuilder decentNumber = new StringBuilder("");
            int fives = 0;
            int threes = 0;
            
            while(n > 0)
            {
                if(n % 3 == 0) //n is divisible by 3
                {
                    while(n > 0)
                    {
                        fives++;
                        n -= 3;
                    }
                }
                
                else if(n % 5 == 0) //n is divisible by 5
                {
                    threes++;
                    n -= 5;
                }
                else //n is not divisible by 3 or 5 
                {
                    fives++;
                    n -= 3;
                }
                
            }
            
            if(n < 0) //No decent number exist
                output.append("-1");
            else //Build the decent number
            {
                for(int i = 0; i < fives; i++)
                    output.append("555");
                for(int i = 0; i < threes; i++)
                    output.append("33333");
            }
            output.append("\n"); //Move to the next line of output
        }
        System.out.println(output);
    }
}