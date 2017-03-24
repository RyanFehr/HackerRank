//Problem: https://www.hackerrank.com/challenges/permutation-equation
//Java 8
/*
Initial Thoughts:
We can use a hashmap to store the functions 
we get from the sequence, then all we need
to do is use it to solve in reverse the
problem x = f(f(y)) where x is given and
f is our hashmap

Time Complexity: O(n) //We have to iterate every element to build our function list
Space Complexity: O(n) //Our hash map has at most n elements

*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    public static void main(String args[] ) throws Exception {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        Map<Integer,Integer> sequenceFunction = new HashMap<>();
        for(int i = 1; i <= n; i++)
        {
            sequenceFunction.put(input.nextInt(),i);
        }
        
        for(int i = 1; i <= n; i++){
            int x = i;
            int t = sequenceFunction.get(x);
            int y = sequenceFunction.get(t);
            System.out.println(y);
        }
    }
}
