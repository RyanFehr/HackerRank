//Problem: https://www.hackerrank.com/challenges/drawing-book
//Java 8
/*
Initial Thoughts:
Choose the minimum turns it takes
to get to page p from the
beginning and the end of the book

page/2 gives us the turns


Example:

6
_1 23 45 6_
0  1   1  0

7
_1 23 45 67
0  1   1  0

8
_1 23 45 67 8_
0  1  2   1  0


We can see from examples that
for odd pages we will need to use
ceil to get the proper # of turns

Time complexity: O(1) 
Space complexity: O(1)
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
        int p = in.nextInt();
        
        int beg = (p/2);
        int end = 0;
        if(n%2==1)
            end = (n-p)/2;
        else
            end = (int) Math.ceil((n-p)/2.0);
        
        System.out.println(Math.min(beg,end));
    }
}
