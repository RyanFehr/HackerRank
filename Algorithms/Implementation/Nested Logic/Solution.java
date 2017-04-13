//Problem: https://www.hackerrank.com/challenges/linkedin-practice-nested-logic
//Java 8
/*
Initial Thoughts:
We can solve this problem by simply using
a if statement that narrows down our checks
at each step to calculate the proper fine

Time Complexity: O(1); //Add return dates take the same amount of time
Space Complexity: O(1); //No dynamically allocated variables
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int returnDay = input.nextInt();
        int returnMonth = input.nextInt();
        int returnYear = input.nextInt();
        
        int expectedDay = input.nextInt();
        int expectedMonth = input.nextInt();
        int expectedYear = input.nextInt();
        
        int hackosFine = 0;
        
        
        //if statement that checks starting at the years and proceeds based on equivalence
        //Year is off  - 10,000 hackos
        //Month is off - months * 500 hackos
        //Day is off   - days * 15 hackos
        
        if(expectedYear < returnYear)
        {
            hackosFine = 10000;
        }
        else if(expectedYear == returnYear )
        {
            if(expectedMonth < returnMonth)
            {
                hackosFine = (returnMonth-expectedMonth) * 500;
            }
            else if(expectedMonth == returnMonth)
            {
                if(expectedDay < returnDay)
                {
                    hackosFine = (returnDay - expectedDay) * 15;
                }
            } 
        }
        
        System.out.println(hackosFine);
    }
}