//Problem: https://www.hackerrank.com/challenges/absolute-permutation
//Java 8
/*
Find every perumation
Do a linear traversal of each perm checking if condition holds

we know that the only permutations we care about are ones that satistfy
absolute

for example
1 2 3 4 5 if k is 1 we know for every point we can only have a number 1 greater or 1 less

_ 1 2 3 4
2 3 4 5 _  

so any combinations of those values at those points

the underscore means we only have 1 choice at those points

Example:

10 2
_ _ _ _ _ _ _ _ _ _
3 _ _ _ _ _ _ _ _ 8
3 4 _ _ _ _ _ _ 7 8
3 4 1 _ _ _ _ 10 7 8
3 4 1 2 _ _ 9 10 7 8
3 4 1 2 _ _ 9 10 7 8 neither is available so failed

so it appears we can solve this in O(n) time by
working from outside in until we hit an impossibility

we want to loop n/2 times and each time check the left most
untouched index and the right most untouched index

we will also need to track what numbers we have already used

left most
check if index - k is in bounds if it is check if it is used if not use it
else if check if i + k is in bounds and is used if it is and is not use it
else not possible

right most
check if index plus k is in bounds if it is check it it is used if not use it
else check if i - k is in bounds and is used if it is and is not use it
else not possible

*/


import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        tests :
        for(int a0 = 0; a0 < t; a0++){
            int n = in.nextInt();
            int k = in.nextInt();
            int[] array = new int[n];
            Set<Integer> used = new HashSet<>();
            
            //Iterate from left and right filling in the array according to the algorithm above
            for(int i = 0; i < n/2; i++)
            {
                int leftMost = i + 1;
                int rightMost = n - i;
                //Left most
                if(leftMost - k > 0 && !used.contains(leftMost-k))
                {
                    array[i] = leftMost-k;
                    used.add(leftMost-k);
                }
                else if(i + 1 + k <= n && !used.contains(leftMost+k))
                {
                    array[i] = leftMost+k;
                    used.add(leftMost+k);
                }
                else
                {
                    System.out.println("-1");
                    continue tests;
                }
                
                //Right most
                if(rightMost + k <= n && !used.contains(rightMost+k))
                {
                    array[n-1-i] = rightMost+k;
                    used.add(rightMost+k);                    
                }
                else if(rightMost - k > 0 && !used.contains(rightMost-k))
                {
                    array[n-1-i] = rightMost-k;
                    used.add(rightMost-k);
                }
                else
                {
                    System.out.println("-1");
                    continue tests;
                }
            }
            
            //if it is odd check to see if we have a number for the middle index
            if(n % 2 == 1)
            {
                int middle = (n/2) + 1;
                
                if(!used.contains(middle+k) || !used.contains(middle-k))
                {
                    if(!used.contains((n/2) +1 + k) && middle + k <= n)
                    {
                        array[(n/2)] = (n/2) + 1 + k;
                    }
                    else if(!used.contains((n/2) +1 - k) && middle - k > 0)
                    {
                        array[(n/2)] = (n/2) + 1 - k;
                    }
                    else
                    {
                        System.out.println("-1");
                        continue tests;    
                    }
                }
                else
                {
                    System.out.println("-1");
                    continue tests;
                }
            }
            
            //Print the results of a success
            for(int num : array)
            {
                System.out.print(num+" ");
            }
            System.out.println("");
            
        }
    }
}
