//Problem: https://www.hackerrank.com/challenges/strange-code
//Java 8
/*
Brute forces is to keep a counter and wait until it equals t and return our current value

int cycle = 3;
int step = 1;
int value = 3;
while(step != t)
{    
    if(value = 1)
    {
        cycle *= 2;
        value = cycle;
    }
    value--;
    step++;
}
System.out.println(value);


We can optimize by bounding our t then calculating

*/


import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        long t = in.nextLong();
        
        
        long upperBound = 4;
        long lowerBound = 1;
        long upperValue = 6;
        //Find the bounds of t
        while(t > upperBound)
        {
            lowerBound = upperBound;
            upperBound = (upperBound+upperValue);
            upperValue = upperBound + 2;
        }
        
        //When t is on a boundry        
        if(t == upperBound)
        {
            System.out.println(upperValue);
        }
        else
        {
            System.out.println(lowerBound+2 - (t-lowerBound));    
        }
        
        
    }
}
