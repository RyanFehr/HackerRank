//Problem: https://www.hackerrank.com/challenges/electronics-shop
//Java 8
/*
Initial Thoughts: 
We can compare all pairs and if they are > max and <= s
then we set it as the new max and return after checking
all pairs

Optimization:
If we sort 1 in descending and the other in ascending 
order we only have to visit each element once, because 
we can make use of the fact that the sum of the element 
following the current will be greater/less than the 
current sum depending on the direction we iterate from

Time Complexity: O(n+m (log (n+m))) //We sort in n+m (log (n+m)) then iterate in n+m  
Space Complexity: O(1) //We consider the arrays as given
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int s = in.nextInt();
        int n = in.nextInt();
        int m = in.nextInt();
        Integer[] keyboards = new Integer[n];
        for(int keyboards_i=0; keyboards_i < n; keyboards_i++){
            keyboards[keyboards_i] = in.nextInt();
        }
        int[] pendrives = new int[m];
        for(int pendrives_i=0; pendrives_i < m; pendrives_i++){
            pendrives[pendrives_i] = in.nextInt();
        }
        
        Arrays.sort(keyboards, Collections.reverseOrder());//Descending order
        Arrays.sort(pendrives);//Ascending order
        
        int max = -1;
        for(int i = 0, j = 0; i < n; i++){
            for(; j < m; j++){
                if(keyboards[i]+pendrives[j] > s) break; //This prevents j from incrementing
                if(keyboards[i]+pendrives[j] > max)
                    max = keyboards[i]+pendrives[j];
            }
        }
        System.out.println(max);
    }
}
