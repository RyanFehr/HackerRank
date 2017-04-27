//Problem: https://www.hackerrank.com/challenges/day-of-the-programmer
//Java 8
/*
Initial Thoughts:
Create two calendars (Julian pre 1918 and Gregorian post 1917)
then solve for the 256th day, which is the wrong approach. 
Relizing the problem outlined the conditions necessary to 
solve for different years I took those and created conditional 
statements out of them.

Time complexity: O(1) 
Space complexity: O(1)
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static String solve(int year){
        String date = "";
        if(year < 1918) {                                                   //Julian check for leap year
            date += (year % 4 == 0) ? "12.09." + year : "13.09." + year;
        } else if(year == 1918) {                                           //Special case: transition year
            date += "26.09." + year;
        } else {                                                            //Gregorian check for leap year
            date += ((year % 400 == 0) ||                               
            (year % 4 == 0 && year % 100 != 0)) ? "12.09." + year : "13.09." + year;
        }
        return date;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int year = in.nextInt();
        String result = solve(year);
        System.out.println(result);
    }
}
