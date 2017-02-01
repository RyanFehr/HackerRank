//Problem: 
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        
        for(int i = 0; i < T; i++)
        {
            int n = input.nextInt()-1;//Minus 1 to account for 0 starting stone
            int a = input.nextInt();
            int b = input.nextInt();
            
            //Edge case where no iterations are required
            if(a == b)
            {
                System.out.println(a*n + " ");
                continue;
            }
            
            //make sure a is our min
            int tmp = a;
            a = Math.min(a,b);
            //If b was the min then set it to old value of a
            b = (a == b) ? tmp : b;
            
            int min = a*n;
            int max = b*n;
            
            //We only need to increment by difference because there are only two stones to choose from each time
            for(int finalSteps = min; finalSteps <= max; finalSteps += (b-a))
            {
                System.out.print(finalSteps + " ");
            }
            
            System.out.println();
            
        }
    }
}