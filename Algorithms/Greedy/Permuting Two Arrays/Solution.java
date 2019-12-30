//Problem: https://www.hackerrank.com/challenges/two-arrays
//Java 8
/*
Initial Thoughts: We can sort array A ascending and sort
                  array B descending, and then because they
                  are sorted we know that we are matching 
                  the highest possible from B with the lowest 
                  possible from A each time and if 1 of 
                  those fails then we know  it is not 
                  possible. The reason we know this is true 
                  is because they are inversely sorted, so 
                  we have already made the optimal decision 
                  at each stage in terms of the amount of 
                  absolute difference we have 'wasted/extra' 
                  thus leaving us with the tightest bounding
                  number to k for each index.
                  
Optimization: If we want to sort a int array in descending 
              order using the built in libraries, we have to
              change it to an Integer[] which takes up 16 bytes
              per element compared to 4. So instead what we can
              do is sort the int[] ascending and just traverse
              it in reverse when comparing to view the elements
              in descending order
                  
Time Complexity: O(n log(n)) //We must sort the input arrays
Space Complexity: O(n) //We must store the input arrays 

*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
      //Take input Dynamically
      //I have taken inputs staticlally.
      
        int [] A = {2,1,3};
        int [] B = {7,8,9};
        int k =10;
        int[] ints = Arrays.stream(A).boxed().sorted(Comparator.reverseOrder()).mapToInt(i -> i).toArray();
        int[] ints1 = Arrays.stream(B).boxed().sorted(Comparator.naturalOrder()).mapToInt(i -> i).toArray();
        final long count = IntStream.rangeClosed(0, A.length - 1).filter(i -> ints[i] + ints1[i] >=k).count();
        if(count== A.length){
            System.out.println("YES");
        }
        else System.out.println("NO");
    }
}
