//Problem: https://www.hackerrank.com/challenges/kangaroo
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int x1 = in.nextInt();
        int v1 = in.nextInt();
        int x2 = in.nextInt();
        int v2 = in.nextInt();
        
            
        while(x1 <= x2)//   Once the kangaroos pass their velocitys prevent them from meeting again.
        {              //This works based on the constraint that x1 < x2 but can be easily adjusted to work with x2 < x1
            if(x1 == x2)
            {
                System.out.println("YES");
                System.exit(0);//Once they meet we don't need to continue checking
            }
            x1 += v1;
            x2 += v2;
        }
        System.out.println("NO");
    }
}
