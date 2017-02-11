//Problem: https://www.hackerrank.com/challenges/fair-rations
//Java 8
/*



Examples: 
[1 1 1 2 1 2 1 2 1 1 2 2 1 2]

[2 2 1 2 1 2 1 2 1 1 2 2 1 2] 2

[2 2 2 3 1 2 1 2 1 1 2 2 1 2] 2

[2 2 2 4 2 2 1 2 1 1 2 2 1 2] 2

[2 2 2 4 2 2 2 3 1 1 2 2 1 2] 2

[2 2 2 4 2 2 2 4 2 1 2 2 1 2] 2

[2 2 2 4 2 2 2 4 2 2 3 2 1 2] 2

[2 2 2 4 2 2 2 4 2 2 4 3 1 2] 2

[2 2 2 4 2 2 2 4 2 2 4 4 2 2] 2
                              16

[2 3 4 5 6]

[2 4 5 5 6] 2

[2 4 6 6 6] 2
            4

[1 1 1 1 1 1 1 1 1 1 1 1]  solvable

[1 1 1 1 1 1 1 1 1 1 1 1 1] unsolvable



O(n) inplace or O(n) space


*/



import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int N = in.nextInt();
        int B[] = new int[N];
        for(int B_i=0; B_i < N; B_i++){
            B[B_i] = in.nextInt();
        }
        
        int bread = 0;
        
        for(int i = 0; i < B.length; i++)
        {
            if(i == B.length-1)//We have reached the last person
            {
                if(B[i] % 2 == 1) //If last person ended with odd bread it is not possible
                {
                    System.out.println("NO");
                    System.exit(0);
                }
                else
                {
                    System.out.println(bread);
                    System.exit(0);
                }
            }
            
            
            if(B[i] % 2 == 1) //The current person has odd bread give them and the person behind them bread
            {
                B[i] = B[i] + 1;
                B[i+1] = B[i+1] +1; 
                bread += 2;
            }
        }
        
    }
}
