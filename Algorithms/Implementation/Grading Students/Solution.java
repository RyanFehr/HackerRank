//Problem: https://www.hackerrank.com/challenges/grading
//Java 8
/*
Initial Thoughts:
We can use division and multiplication
to find the next factor of 5 then
just check our conditions and
return the proper grade

Time Complexity: O(n) //In the number of grades
Space Complexity: O(1)  //We only ever store two integers in memory

*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        for(int a0 = 0; a0 < n; a0++){
            int grade = in.nextInt();

            
            int newGrade = ((grade / 5) + 1) * 5;
            
            if(newGrade < 40) 
            {
                System.out.println(grade);
                continue;
            }
            
            if(newGrade - grade < 3) System.out.println(newGrade);
            else
                System.out.println(grade);
        }
    }
}
