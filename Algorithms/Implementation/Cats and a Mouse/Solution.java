//Problem: https://www.hackerrank.com/challenges/cats-and-a-mouse
//Java 8
/*
Intitial Thoughts:  Find the distance each cat is from
                    the mouse and choose the closer one
                    if the distances are equal then 
                    choose the mouse

Time Complexity: O(1) //We do at max 3 comparisons
Space Complexity: O(1) 
                    
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for(int a0 = 0; a0 < q; a0++){
            int x = in.nextInt();
            int y = in.nextInt();
            int z = in.nextInt();
            int diffA = Math.abs(x-z); //Distance Cat A is from Mouse
            int diffB = Math.abs(y-z); //Distance Cat B is from Mouse
            if(diffA < diffB)
                System.out.println("Cat A");
            else if(diffB < diffA)
                System.out.println("Cat B");
            else //Equivalent
                System.out.println("Mouse C");
        }
    }
}
